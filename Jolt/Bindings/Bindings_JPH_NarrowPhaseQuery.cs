using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static bool JPH_NarrowPhaseQuery_CastRay(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, out RayCastResult hit, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter)
        {
            RayCastResult hitResult = new();
            bool result = UnsafeBindings.JPH_NarrowPhaseQuery_CastRay(query, &origin, &direction, &hitResult, broadPhaseLayerFilter, objectLayerFilter, bodyFilter);

            hit = hitResult;
            return result;
        }

        public static bool JPH_NarrowPhaseQuery_CastRay2(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, RayCastSettings settings, CollisionCollector<RayCastResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastRayCollector tempDelegate = collector.AddResultWithEarlyOutUpdate2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CastRay2(query, &origin, &direction, &settings, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CastRay3(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, RayCastSettings settings, CollisionCollectorType collectorType, CollisionCollector<RayCastResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastRayResultCallback tempDelegate = collector.AddResult2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CastRay3(query, &origin, &direction, &settings, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CollidePoint(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 point, CollisionCollector<CollidePointResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollidePointCollector tempDelegate = collector.AddResultWithEarlyOutUpdate2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CollidePoint(query, &point, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CollidePoint2(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 point, CollisionCollectorType collectorType, CollisionCollector<CollidePointResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollidePointResultCallback tempDelegate = collector.AddResult2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CollidePoint2(query, &point, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CollideShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, float3 scale, rmatrix4x4 centerOfMassTransform, CollideShapeSettings settings, rvec3 baseOffset, CollisionCollector<CollideShapeResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollideShapeCollector tempDelegate = collector.AddResultWithEarlyOutUpdate2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CollideShape(query, shape, &scale, &centerOfMassTransform, &settings, &baseOffset, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CollideShape2(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, float3 scale, rmatrix4x4 centerOfMassTransform, CollideShapeSettings settings, rvec3 baseOffset, CollisionCollectorType collectorType, CollisionCollector<CollideShapeResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollideShapeResultCallback tempDelegate = collector.AddResult2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CollideShape2(query, shape, &scale, &centerOfMassTransform, &settings, &baseOffset, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CastShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, rmatrix4x4 worldTransform, float3 direction, ShapeCastSettings settings, rvec3 baseOffset, CollisionCollector<ShapeCastResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastShapeCollector tempDelegate = collector.AddResultWithEarlyOutUpdate2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CastShape(query, shape, &worldTransform, &direction, &settings, &baseOffset, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }

        public static bool JPH_NarrowPhaseQuery_CastShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, rmatrix4x4 worldTransform, float3 direction, ShapeCastSettings settings, rvec3 baseOffset, CollisionCollectorType collectorType, CollisionCollector<ShapeCastResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastShapeResultCallback tempDelegate = collector.AddResult2;

            return UnsafeBindings.JPH_NarrowPhaseQuery_CastShape2(query, shape, &worldTransform, &direction, &settings, &baseOffset, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
        }
    }
}
