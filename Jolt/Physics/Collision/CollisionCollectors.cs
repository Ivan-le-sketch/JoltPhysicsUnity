using System;
using Unity.Burst;
using Unity.Collections;

namespace Jolt
{
    [BurstCompile]
    public unsafe struct RayCastResultCollector : IDisposable
    {
        /// <summary>
        /// The collection to receive the results of a collision query.
        /// </summary>
        public NativeList<RayCastResult> Results { get; private set; }

        internal readonly static FunctionPointer<JPH_CastRayResultCallback> AddResultFuncPointer;
        internal readonly static FunctionPointer<JPH_CastRayCollector> AddResultWithEarlyOutUpdateFuncPointer;

        static RayCastResultCollector()
        {
            AddResultFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CastRayResultCallback>(AddResult);
            AddResultWithEarlyOutUpdateFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CastRayCollector>(AddResultWithEarlyOutUpdate);
        }

        public RayCastResultCollector(int initialCapacity, Allocator allocator)
        {
            Results = new NativeList<RayCastResult>(initialCapacity, allocator);
        }

        [BurstCompile]
        public static void AddResult(void* context, RayCastResult* result)
        {
            var collectorInstancePtr = (RayCastResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            collectorInstance.AddResult(result);
        }

        [BurstCompile]
        public static float AddResultWithEarlyOutUpdate(void* context, RayCastResult* result)
        {
            var collectorInstancePtr = (RayCastResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            return collectorInstance.AddResultWithEarlyOutUpdate(result);
        }

        public void Dispose()
        {
            Results.Dispose();
        }

        public void Clear()
        {
            Results.Clear();
        }

        public void AddResult(RayCastResult* result)
        {
            Results.Add(*result);
        }

        public float AddResultWithEarlyOutUpdate(RayCastResult* result)
        {
            RayCastResult res = *result;

            Results.Add(res);

            return res.Fraction;
        }
    }

    [BurstCompile]
    public unsafe struct ShapeCastResultCollector: IDisposable
    {
        /// <summary>
        /// The collection to receive the results of a collision query.
        /// </summary>
        public NativeList<ShapeCastResult> Results { get; private set; }

        internal static FunctionPointer<JPH_CastShapeResultCallback> AddResultFuncPointer;
        internal static FunctionPointer<JPH_CastShapeCollector> AddResultWithEarlyOutUpdateFuncPointer;

        static ShapeCastResultCollector()
        {
            AddResultFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CastShapeResultCallback>(AddResult);
            AddResultWithEarlyOutUpdateFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CastShapeCollector>(AddResultWithEarlyOutUpdate);
        }

        public ShapeCastResultCollector(int initialCapacity, Allocator allocator)
        {
            Results = new NativeList<ShapeCastResult>(initialCapacity, allocator);
        }

        [BurstCompile]
        public static void AddResult(void* context, ShapeCastResult* result)
        {
            var collectorInstancePtr = (ShapeCastResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            collectorInstance.AddResult(result);
        }

        [BurstCompile]
        public static float AddResultWithEarlyOutUpdate(void* context, ShapeCastResult* result)
        {
            var collectorInstancePtr = (ShapeCastResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            return collectorInstance.AddResultWithEarlyOutUpdate(result);
        }

        public void Dispose()
        {
            Results.Dispose();
        }

        public void Clear()
        {
            Results.Clear();
        }

        public void AddResult(ShapeCastResult* result)
        {
            Results.Add(*result);
        }

        public float AddResultWithEarlyOutUpdate(ShapeCastResult* result)
        {
            ShapeCastResult res = *result;

            Results.Add(res);

            return res.GetEarlyOutFraction();
        }
    }

    [BurstCompile]
    public unsafe struct CollidePointResultCollector : IDisposable
    {
        /// <summary>
        /// The collection to receive the results of a collision query.
        /// </summary>
        public NativeList<CollidePointResult> Results { get; private set; }

        internal readonly static FunctionPointer<JPH_CollidePointResultCallback> AddResultFuncPointer;
        internal readonly static FunctionPointer<JPH_CollidePointCollector> AddResultWithEarlyOutUpdateFuncPointer;

        static CollidePointResultCollector()
        {
            AddResultFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CollidePointResultCallback>(AddResult);
            AddResultWithEarlyOutUpdateFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CollidePointCollector>(AddResultWithEarlyOutUpdate);
        }

        public CollidePointResultCollector(int initialCapacity, Allocator allocator)
        {
            Results = new NativeList<CollidePointResult>(initialCapacity, allocator);
        }

        [BurstCompile]
        public static void AddResult(void* context, CollidePointResult* result)
        {
            var collectorInstancePtr = (CollidePointResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            collectorInstance.AddResult(result);
        }

        [BurstCompile]
        public static float AddResultWithEarlyOutUpdate(void* context, CollidePointResult* result)
        {
            var collectorInstancePtr = (CollidePointResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            return collectorInstance.AddResultWithEarlyOutUpdate(result);
        }

        public void Dispose()
        {
            Results.Dispose();
        }

        public void Clear()
        {
            Results.Clear();
        }

        public void AddResult(CollidePointResult* result)
        {
            Results.Add(*result);
        }

        public float AddResultWithEarlyOutUpdate(CollidePointResult* result)
        {
            CollidePointResult res = *result;

            Results.Add(res);

            return res.GetEarlyOutFraction();
        }
    }

    [BurstCompile]
    public unsafe struct CollideShapeResultCollector : IDisposable
    {
        /// <summary>
        /// The collection to receive the results of a collision query.
        /// </summary>
        public NativeList<CollideShapeResult> Results { get; private set; }

        internal readonly static FunctionPointer<JPH_CollideShapeResultCallback> AddResultFuncPointer;
        internal readonly static FunctionPointer<JPH_CollideShapeCollector> AddResultWithEarlyOutUpdateFuncPointer;

        static CollideShapeResultCollector()
        {
            AddResultFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CollideShapeResultCallback>(AddResult);
            AddResultWithEarlyOutUpdateFuncPointer = BurstCompiler.CompileFunctionPointer<JPH_CollideShapeCollector>(AddResultWithEarlyOutUpdate);
        }

        public CollideShapeResultCollector(int initialCapacity, Allocator allocator)
        {
            Results = new NativeList<CollideShapeResult>(initialCapacity, allocator);
        }

        [BurstCompile]
        public static void AddResult(void* context, CollideShapeResult* result)
        {
            var collectorInstancePtr = (CollideShapeResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            collectorInstance.AddResult(result);
        }

        [BurstCompile]
        public static float AddResultWithEarlyOutUpdate(void* context, CollideShapeResult* result)
        {
            var collectorInstancePtr = (CollideShapeResultCollector*)context;
            var collectorInstance = *collectorInstancePtr;

            return collectorInstance.AddResultWithEarlyOutUpdate(result);
        }

        public void Dispose()
        {
            Results.Dispose();
        }

        public void Clear()
        {
            Results.Clear();
        }

        public void AddResult(CollideShapeResult* result)
        {
            Results.Add(*result);
        }

        public float AddResultWithEarlyOutUpdate(CollideShapeResult* result)
        {
            CollideShapeResult res = *result;

            Results.Add(res);

            return res.GetEarlyOutFraction();
        }
    }
}