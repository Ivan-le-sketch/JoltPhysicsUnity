using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Jolt
{
    public unsafe static class CollisionDispatch
    {
        public static bool CollideShapeVsShape(
            Shape shape1, Shape shape2,
            float3 scale1, float3 scale2,
            float3 position1, float3 position2,
            quaternion rotation1, quaternion rotation2,
            CollideShapeSettings settings,
            ref CollideShapeResultCollector collector,
            ShapeFilter? shapeFilter = null
            )
        {
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            float4x4 COMTransform1 = new float4x4(rotation1, position1);
            float4x4 COMTransform2 = new float4x4(rotation2, position2);

            fixed (CollideShapeResultCollector* ptr = &collector)
            {
                return UnsafeBindings.JPH_CollisionDispatch_CollideShapeVsShape(shape1.Handle, shape2.Handle, &scale1, &scale2, &COMTransform1, &COMTransform2, &settings, CollideShapeResultCollector.AddResultFuncPointer.Value, ptr, shapeFilterHandle);
            }
        }

        public static int CollideShapeVsShape(
            Shape shape1, Shape shape2,
            float3 scale1, float3 scale2,
            float3 position1, float3 position2,
            quaternion rotation1, quaternion rotation2,
            CollideShapeSettings settings,
            CollisionCollectorType collectorType,
            ref CollideShapeResultCollector collector,
            ShapeFilter? shapeFilter = null
            )
        {
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            float4x4 COMTransform1 = new float4x4(rotation1, position1);
            float4x4 COMTransform2 = new float4x4(rotation2, position2);

            fixed (CollideShapeResultCollector* ptr = &collector)
            {
                return UnsafeBindings.JPH_CollisionDispatch_CollideShapeVsShape2(shape1.Handle, shape2.Handle, &scale1, &scale2, &COMTransform1, &COMTransform2, &settings, collectorType, collector.Results.GetUnsafePtr(), collector.Results.Length, shapeFilterHandle);
            }
        }

        public static bool CastShapeVsShapeLocalSpace(
            float3 direction,
            Shape shape1, Shape shape2,
            float3 scale1, float3 scale2,
            float4x4 COMTransform1, float4x4 COMTransform2,
            ShapeCastSettings settings,
            ref ShapeCastResultCollector collector,
            ShapeFilter? shapeFilter = null
            )
        {
            fixed (ShapeCastResultCollector* ptr = &collector)
            {
                NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

                return UnsafeBindings.JPH_CollisionDispatch_CastShapeVsShapeLocalSpace(&direction, shape1.Handle, shape2.Handle, &scale1, &scale2, &COMTransform1, &COMTransform2, &settings, ShapeCastResultCollector.AddResultFuncPointer.Value, ptr, shapeFilterHandle);
            }
        }

        public static int CastShapeVsShapeLocalSpace(
            float3 direction,
            Shape shape1, Shape shape2,
            float3 scale1, float3 scale2,
            float4x4 COMTransform1, float4x4 COMTransform2,
            ShapeCastSettings settings,
            CollisionCollectorType collectorType,
            ref ShapeCastResultCollector collector,
            ShapeFilter? shapeFilter = null
            )
        {
            fixed (ShapeCastResultCollector* ptr = &collector)
            {
                NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

                return UnsafeBindings.JPH_CollisionDispatch_CastShapeVsShapeLocalSpace2(&direction, shape1.Handle, shape2.Handle, &scale1, &scale2, &COMTransform1, &COMTransform2, &settings, collectorType, collector.Results.GetUnsafePtr(), collector.Results.Length, shapeFilterHandle);
            }
        }

        public static bool CastShapeVsShapeWorldSpace(
            float3 direction,
            Shape shape1, Shape shape2,
            float3 scale1, float3 scale2,
            float4x4 COMTransform1, float4x4 COMTransform2,
            ShapeCastSettings settings,
            ref ShapeCastResultCollector collector,
            ShapeFilter? shapeFilter = null
            )
        {
            fixed (ShapeCastResultCollector* ptr = &collector)
            {
                NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

                return UnsafeBindings.JPH_CollisionDispatch_CastShapeVsShapeWorldSpace(&direction, shape1.Handle, shape2.Handle, &scale1, &scale2, &COMTransform1, &COMTransform2, &settings, ShapeCastResultCollector.AddResultFuncPointer.Value, ptr, shapeFilterHandle);
            }
        }

        public static int CastShapeVsShapeWorldSpace(
            float3 direction,
            Shape shape1, Shape shape2,
            float3 scale1, float3 scale2,
            float4x4 COMTransform1, float4x4 COMTransform2,
            ShapeCastSettings settings,
            CollisionCollectorType collectorType,
            ref ShapeCastResultCollector collector,
            ShapeFilter? shapeFilter = null
            )
        {
            fixed (ShapeCastResultCollector* ptr = &collector)
            {
                NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

                return UnsafeBindings.JPH_CollisionDispatch_CastShapeVsShapeWorldSpace2(&direction, shape1.Handle, shape2.Handle, &scale1, &scale2, &COMTransform1, &COMTransform2, &settings, collectorType, collector.Results.GetUnsafePtr(), collector.Results.Length, shapeFilterHandle);
            }
        }
    }
}
