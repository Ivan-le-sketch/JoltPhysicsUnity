using System;
using Unity.Burst;
using Unity.Collections;

namespace Jolt
{
    /// <summary>
    /// A collision query result collector designed for burst compatibility.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [BurstCompile]
    public unsafe struct CollisionCollector<T> : IDisposable where T : unmanaged
    {
        /// <summary>
        /// The collection to receive the results of a collision query.
        /// </summary>
        public NativeList<T> Results { get; private set; }

        public CollisionCollector(int capacity, Allocator allocator)
        {
            Results = new NativeList<T>(capacity, allocator);
        }

        // TODO : Find better naming for methods and parameters

        [BurstCompile]
        public static void AddResult(void* context, ref T result)
        {
            var collectorInstancePtr = (CollisionCollector<T>*)context;
            var collectorInstance = *collectorInstancePtr;

            collectorInstance.AddResult(ref result);
        }

        [BurstCompile]
        public static float AddResultWithEarlyOutUpdate(void* context, ref T result)
        {
            var collectorInstancePtr = (CollisionCollector<T>*)context;
            var collectorInstance = *collectorInstancePtr;

            return collectorInstance.AddResultWithEarlyOutUpdate(ref result);
        }

        [BurstCompile]
        public static void AddResult2(void* context, T* result)
        {
            var collectorInstancePtr = (CollisionCollector<T>*)context;
            var collectorInstance = *collectorInstancePtr;

            collectorInstance.AddResult2(result);
        }

        [BurstCompile]
        public static float AddResultWithEarlyOutUpdate2(void* context, T* result)
        {
            var collectorInstancePtr = (CollisionCollector<T>*)context;
            var collectorInstance = *collectorInstancePtr;

            return collectorInstance.AddResultWithEarlyOutUpdate2(result);
        }

        public void Dispose()
        {
            Results.Dispose();
        }

        public void Clear()
        {
            Results.Clear();
        }

        public void AddResult(ref T result)
        {
            Results.Add(result);
        }

        public float AddResultWithEarlyOutUpdate(ref T result)
        {
            Results.Add(result);

            return 1f;
        }

        public void AddResult2(T* result)
        {
            Results.Add(*result);
        }

        public float AddResultWithEarlyOutUpdate2(T* result)
        {
            Results.Add(*result);

            return 1f;
        }
    }
}