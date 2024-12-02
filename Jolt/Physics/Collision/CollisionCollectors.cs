using System;
using System.Collections.Generic;
using Unity.Collections;

namespace Jolt
{
    public unsafe class CollisionCollector<T> : IDisposable where T : unmanaged
    {
        public List<T> Results { get; private set; }

        public CollisionCollector(int capacity = 32, Allocator allocator = Allocator.Persistent)
        {
            Results = new List<T>();
        }

        public void Dispose()
        {
            //Results.Dispose();
        }

        public void AddResult(void* context, T result)
        {
            Results.Add(result);
        }

        public float AddResultWithEarlyOutUpdate(void* context, T result)
        {
            Results.Add(result);

            return 1f;
        }

        public void AddResult2(void* context, T* result)
        {
            Results.Add(*result);
        }

        public float AddResultWithEarlyOutUpdate2(void* context, T* result)
        {
            Results.Add(*result);

            return 1f;
        }
    }
}