using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Jolt
{
    internal static class ManagedReference
    {
        private static readonly Dictionary<nint, GCHandle> lookup = new();

        public static void Add<T>(NativeHandle<T> context, GCHandle handle) where T : unmanaged
        {
            lock (lookup)
            {
                lookup.Add(context.RawValue, handle);
            }
        }

        public static bool Remove<T>(NativeHandle<T> context, out GCHandle handle) where T : unmanaged
        {
            lock (lookup)
            {
                return lookup.Remove(context.RawValue, out handle);
            }
        }

        public static T Deref<T>(IntPtr ptr)
        {
            return (T)GCHandle.FromIntPtr(ptr).Target;
        }
    }

    internal static class ManagedReference<T> where T : class
    {
        private const int MaxInstances = 4; // Pick smallest viable upper bound
        private static T[] _instances = new T[MaxInstances];
        private static int[] _usedIds = new int[MaxInstances]; // Optional: reuse IDs
        private static int _nextId = 1;

        public static int Add(T instance)
        {
            for (int i = 0; i < MaxInstances; i++)
            {
                if (_instances[i] == null)
                {
                    _instances[i] = instance;
                    int id = i + 1; // avoid 0 (invalid)
                    _usedIds[i] = id;
                    return id;
                }
            }

            throw new InvalidOperationException($"ManagedReference<{typeof(T).Name}>: MaxInstances exceeded.");
        }

        public static T Get(int id)
        {
            int index = id - 1;
            if ((uint)index >= MaxInstances) return null;
            return _instances[index];
        }

        public static void Remove(int id)
        {
            int index = id - 1;
            if ((uint)index >= MaxInstances) return;

            _instances[index] = null;
            _usedIds[index] = 0;
        }
    }
}