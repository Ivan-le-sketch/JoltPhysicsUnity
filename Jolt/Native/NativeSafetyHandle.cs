﻿using System;
using System.Runtime.CompilerServices;
using System.Threading;
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

        private static int nextHandleInternal;
        private static readonly object lockObject = new object();

        private static NativeHashSet<uint> disposed;

        [RuntimeInitializeOnLoadMethod]
        internal static void Initialize()
        {
            disposed = new NativeHashSet<uint>(1024, Allocator.Persistent);
        }

        /// <summary>
        /// Dispose the internal safety handle state.
        /// </summary>
        internal static void Dispose()
        {
            // TODO check for unreleased safety handles?

            if (disposed.IsCreated) disposed.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NativeSafetyHandle Create()
        {
            int newIndex = Interlocked.Increment(ref nextHandleInternal);
            uint safeIndex = unchecked((uint)newIndex - 1);

            return new NativeSafetyHandle { Index = safeIndex };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Release(in NativeSafetyHandle handle)
        {
            lock (lockObject)
            {
                if (disposed.Contains(handle.Index))
                {
                    Debug.LogWarning("A NativeSafetyHandle is being released for a handle index that was already released.");
                    return;
                }
                disposed.Add(handle.Index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertExists(in NativeSafetyHandle handle)
        {
            lock (lockObject)
            {
                if (disposed.Contains(handle.Index))
                {
                    throw new ObjectDisposedException("The native resource has been disposed.");
                }
            }
        }
    }

    #endif
}
