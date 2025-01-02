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

        public static bool JPH_NarrowPhaseQuery_CastRay2(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, RayCastSettings settings, ref RayCastResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (RayCastResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastRay2(query, &origin, &direction, &settings, RayCastResultCollector.AddResultWithEarlyOutUpdateFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CastRay3(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 origin, float3 direction, RayCastSettings settings, CollisionCollectorType collectorType, ref RayCastResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (RayCastResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastRay3(query, &origin, &direction, &settings, collectorType, RayCastResultCollector.AddResultFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CastShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, rmatrix4x4 worldTransform, float3 direction, ShapeCastSettings settings, rvec3 baseOffset, ref ShapeCastResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (ShapeCastResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastShape(query, shape, &worldTransform, &direction, &settings, &baseOffset, ShapeCastResultCollector.AddResultWithEarlyOutUpdateFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CastShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, rmatrix4x4 worldTransform, float3 direction, ShapeCastSettings settings, rvec3 baseOffset, CollisionCollectorType collectorType, ref ShapeCastResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (ShapeCastResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CastShape2(query, shape, &worldTransform, &direction, &settings, &baseOffset, collectorType, ShapeCastResultCollector.AddResultFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollidePoint(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 point, ref CollidePointResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (CollidePointResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollidePoint(query, &point, CollidePointResultCollector.AddResultWithEarlyOutUpdateFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollidePoint2(NativeHandle<JPH_NarrowPhaseQuery> query, rvec3 point, CollisionCollectorType collectorType, ref CollidePointResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (CollidePointResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollidePoint2(query, &point, collectorType, CollidePointResultCollector.AddResultFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollideShape(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, float3 scale, rmatrix4x4 centerOfMassTransform, CollideShapeSettings settings, rvec3 baseOffset, ref CollideShapeResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (CollideShapeResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollideShape(query, shape, &scale, &centerOfMassTransform, &settings, &baseOffset, CollideShapeResultCollector.AddResultWithEarlyOutUpdateFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }

        public static bool JPH_NarrowPhaseQuery_CollideShape2(NativeHandle<JPH_NarrowPhaseQuery> query, NativeHandle<JPH_Shape> shape, float3 scale, rmatrix4x4 centerOfMassTransform, CollideShapeSettings settings, rvec3 baseOffset, CollisionCollectorType collectorType, ref CollideShapeResultCollector collector, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter, NativeHandle<JPH_BodyFilter>? bodyFilter, NativeHandle<JPH_ShapeFilter>? shapeFilter)
        {
            fixed (CollideShapeResultCollector* ptr = &collector)
            {
                void* vPtr = ptr;
                return UnsafeBindings.JPH_NarrowPhaseQuery_CollideShape2(query, shape, &scale, &centerOfMassTransform, &settings, &baseOffset, collectorType, CollideShapeResultCollector.AddResultFuncPointer.Value, vPtr, broadPhaseLayerFilter, objectLayerFilter, bodyFilter, shapeFilter);
            }
        }
    }
}
