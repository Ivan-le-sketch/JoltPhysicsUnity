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

        public static bool JPH_NarrowPhaseQuery_CastRay2(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, RayCastSettings settings, ref CollisionCollector<RayCastResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastRayCollector tempDelegate = CollisionCollector<RayCastResult>.AddResultWithEarlyOutUpdate2;
            fixed (CollisionCollector<RayCastResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastRay2(query, &origin, &direction, &settings, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CastRay3(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, RayCastSettings settings, CollisionCollectorType collectorType, ref CollisionCollector<RayCastResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastRayResultCallback tempDelegate = CollisionCollector<RayCastResult>.AddResult2;
            fixed (CollisionCollector<RayCastResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastRay3(query, &origin, &direction, &settings, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollidePoint(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 point, ref CollisionCollector<CollidePointResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollidePointCollector tempDelegate = CollisionCollector<CollidePointResult>.AddResultWithEarlyOutUpdate2;
            fixed (CollisionCollector<CollidePointResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollidePoint(query, &point, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollidePoint2(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 point, CollisionCollectorType collectorType, ref CollisionCollector<CollidePointResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollidePointResultCallback tempDelegate = CollisionCollector<CollidePointResult>.AddResult2;
            fixed (CollisionCollector<CollidePointResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollidePoint2(query, &point, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollideShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, float3 scale, rmatrix4x4 centerOfMassTransform, CollideShapeSettings settings, rvec3 baseOffset, ref CollisionCollector<CollideShapeResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollideShapeCollector tempDelegate = CollisionCollector<CollideShapeResult>.AddResultWithEarlyOutUpdate2;
            fixed (CollisionCollector<CollideShapeResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollideShape(query, shape, &scale, &centerOfMassTransform, &settings, &baseOffset, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollideShape2(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, float3 scale, rmatrix4x4 centerOfMassTransform, CollideShapeSettings settings, rvec3 baseOffset, CollisionCollectorType collectorType, ref CollisionCollector<CollideShapeResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CollideShapeResultCallback tempDelegate = CollisionCollector<CollideShapeResult>.AddResult2;
            fixed (CollisionCollector<CollideShapeResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollideShape2(query, shape, &scale, &centerOfMassTransform, &settings, &baseOffset, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CastShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, rmatrix4x4 worldTransform, float3 direction, ShapeCastSettings settings, rvec3 baseOffset, ref CollisionCollector<ShapeCastResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastShapeCollector tempDelegate = CollisionCollector<ShapeCastResult>.AddResultWithEarlyOutUpdate2;
            fixed (CollisionCollector<ShapeCastResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastShape(query, shape, &worldTransform, &direction, &settings, &baseOffset, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CastShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, rmatrix4x4 worldTransform, float3 direction, ShapeCastSettings settings, rvec3 baseOffset, CollisionCollectorType collectorType, ref CollisionCollector<ShapeCastResult> collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            JPH_CastShapeResultCallback tempDelegate = CollisionCollector<ShapeCastResult>.AddResult2;
            fixed (CollisionCollector<ShapeCastResult>* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastShape2(query, shape, &worldTransform, &direction, &settings, &baseOffset, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }
    }
}
