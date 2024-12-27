using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

[assembly: InternalsVisibleTo("Jolt.Unity")]
[assembly: InternalsVisibleTo("Jolt.Editor")]

namespace Jolt
{
#if !JOLT_DISABLE_SAFETY_CHECkS

    /// <summary>
    /// A safety handle for detecting use-after-free access of native objects.
    /// </summary>
    public struct NativeSafetyHandle
    {
        // Initially I tried to reuse AtomicSafetyHandle to offload complexity out of the lib, but
        // AtomicSafetyHandle is tightly coupled to the ENABLE_UNITY_COLLECTIONS_CHECKS scripting
        // define, and ideally the Jolt safety checks can be enabled independently.

        // TODO investigate more sophisticated use-after-free safety checks

        public uint Index;

        private static readonly SharedStatic<int> nextHandleInternal;
        private struct NextHandleInternalKey { }

        private static readonly SharedStatic<NativeHashSet<uint>> disposed;
        private struct DisposedKey { }

        private static readonly SharedStatic<int> disposedSpinLock;
        private struct DisposedSpinLockKey { }

        static NativeSafetyHandle()
        {
            nextHandleInternal = SharedStatic<int>.GetOrCreate<NativeSafetyHandle, NextHandleInternalKey>();
            disposed = SharedStatic<NativeHashSet<uint>>.GetOrCreate<NativeSafetyHandle, DisposedKey>();
            disposedSpinLock = SharedStatic<int>.GetOrCreate<NativeSafetyHandle, DisposedSpinLockKey>();
        }

        [RuntimeInitializeOnLoadMethod]
        internal static void Initialize()
        {
            nextHandleInternal.Data = 0;
            disposed.Data = new NativeHashSet<uint>(1024, Allocator.Persistent);
            disposedSpinLock.Data = 0;
        }

        /// <summary>
        /// Dispose the internal safety handle state.
        /// </summary>
        internal static void Dispose()
        {
            // TODO check for unreleased safety handles?

            if (disposed.Data.IsCreated) disposed.Data.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NativeSafetyHandle Create()
        {
            int newIndex = Interlocked.Increment(ref nextHandleInternal.Data);
            uint safeIndex = unchecked((uint)newIndex - 1);

            return new NativeSafetyHandle { Index = safeIndex };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Release(in NativeSafetyHandle handle)
        {
            LockDisposedSpinLock();

            if (disposed.Data.Contains(handle.Index))
            {
                Debug.LogWarning("A NativeSafetyHandle is being released for a handle index that was already released.");
                return;
            }
            disposed.Data.Add(handle.Index);

            UnlockDisposedSpinLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertExists(in NativeSafetyHandle handle)
        {
            LockDisposedSpinLock();

            if (disposed.Data.Contains(handle.Index))
            {
                throw new ObjectDisposedException("The native resource has been disposed.");
            }

            UnlockDisposedSpinLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LockDisposedSpinLock()
        {
            while (Interlocked.CompareExchange(ref disposedSpinLock.Data, 1, 0) != 0)
            {

            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void UnlockDisposedSpinLock()
        {
            Volatile.Write(ref disposedSpinLock.Data, 0);
        }
    }

#endif
}
