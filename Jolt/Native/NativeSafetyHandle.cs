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
        private readonly static SharedStatic<NativeParallelHashMap<IntPtr, int>> safetyHandles;
        private struct SafetyHandlesKey { }

        private static readonly SharedStatic<int> spinLock;
        private struct SpinLockKey { }

        public IntPtr NativeData;

        static NativeSafetyHandle()
        {
            safetyHandles = SharedStatic<NativeParallelHashMap<IntPtr, int>>.GetOrCreate<NativeSafetyHandle, SafetyHandlesKey>();
            spinLock = SharedStatic<int>.GetOrCreate<NativeSafetyHandle, SpinLockKey>();
        }

        [RuntimeInitializeOnLoadMethod]
        internal static void Initialize()
        {
            safetyHandles.Data = new NativeParallelHashMap<IntPtr, int>(10000, Allocator.Persistent);
            spinLock.Data = 0;
        }

        /// <summary>
        /// Dispose the internal safety handle state.
        /// </summary>
        internal static void Dispose()
        {
            // TODO check for unreleased safety handles?

            if (safetyHandles.Data.IsCreated) safetyHandles.Data.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static NativeSafetyHandle Create(in IntPtr pointerToNative)
        {
            LockSpinLock();
            safetyHandles.Data.TryAdd(pointerToNative, 0);
            UnlockSpinLock();

            return new NativeSafetyHandle { NativeData = pointerToNative };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal bool Release()
        {
            Debug.Log("Attempting to release safety handle");
            LockSpinLock();
            if (safetyHandles.Data.ContainsKey(NativeData) && safetyHandles.Data[NativeData] > 0)
            {
                UnlockSpinLock();
                Debug.LogWarning($"Attempting to release a safety handle with {safetyHandles.Data[NativeData]} users. Attempt denied.");
                return false;
            }

            if (!safetyHandles.Data.Remove(NativeData))
            {
                UnlockSpinLock();
                Debug.LogWarning("Native safety handle : attempting to release a non existing safety handle.");
                return false;
            }
            
            UnlockSpinLock();

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void AddUser()
        {
            LockSpinLock();
            if (!safetyHandles.Data.ContainsKey(NativeData))
            {
                safetyHandles.Data[NativeData]++;
            }
            UnlockSpinLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void RemoveUser()
        {
            LockSpinLock();
            if (!safetyHandles.Data.ContainsKey(NativeData))
            {
                safetyHandles.Data[NativeData]--;
            }
            UnlockSpinLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void AssertExists()
        {
            LockSpinLock();
            if (!safetyHandles.Data.ContainsKey(NativeData))
            {
                throw new ObjectDisposedException("The native resource has been disposed.");
            }
            UnlockSpinLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LockSpinLock()
        {
            while (Interlocked.CompareExchange(ref spinLock.Data, 1, 0) != 0)
            {

            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void UnlockSpinLock()
        {
            Volatile.Write(ref spinLock.Data, 0);
        }
    }
#endif
}
