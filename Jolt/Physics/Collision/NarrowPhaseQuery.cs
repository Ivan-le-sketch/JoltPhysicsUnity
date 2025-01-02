using System;
using Unity.Mathematics;

namespace Jolt
{
    public unsafe struct NarrowPhaseQuery : IDisposable, IEquatable<NarrowPhaseQuery>
    {
        internal readonly NativeHandle<JPH_NarrowPhaseQuery> Handle;

        internal NarrowPhaseQuery(NativeHandle<JPH_NarrowPhaseQuery> handle) => Handle = handle;

        #region IEquatable

        public bool Equals(NarrowPhaseQuery other) => Handle.Equals(other.Handle);

        public override bool Equals(object obj) => obj is NarrowPhaseQuery other && Equals(other);

        public override int GetHashCode() => Handle.GetHashCode();

        public static bool operator ==(NarrowPhaseQuery lhs, NarrowPhaseQuery rhs) => lhs.Equals(rhs);

        public static bool operator !=(NarrowPhaseQuery lhs, NarrowPhaseQuery rhs) => !lhs.Equals(rhs);

        #endregion

        public void Dispose()
        {
            Handle.Dispose();
        }

        #region JPH_NarrowPhaseQuery

        public bool CastRay(float3 origin, float3 direction, out RayCastResult hit,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CastRay(Handle, origin, direction, out hit, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle);
        }

        public bool CastRay(float3 origin, float3 direction, RayCastSettings settings,
            ref RayCastResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CastRay2(Handle, origin, direction, settings, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CastRay(float3 origin, float3 direction, RayCastSettings settings,
            CollisionCollectorType collectorType, ref RayCastResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CastRay3(Handle, origin, direction, settings, collectorType, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CastShape(Shape shape, float4x4 worldTransform, float3 direction,
            ShapeCastSettings settings, rvec3 baseOffset,
            ref ShapeCastResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CastShape(Handle, shape.Handle, worldTransform, direction, settings, baseOffset, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CastShape(Shape shape, float4x4 worldTransform, float3 direction,
            ShapeCastSettings settings, rvec3 baseOffset,
            CollisionCollectorType collectorType, ref ShapeCastResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CastShape(Handle, shape.Handle, worldTransform, direction, settings, baseOffset, collectorType, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CollidePoint(float3 origin,
            ref CollidePointResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CollidePoint(Handle, origin, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CollidePoint(float3 origin,
            CollisionCollectorType collectorType, ref CollidePointResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CollidePoint2(Handle, origin, collectorType, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CollideShape(Shape shape, float3 scale, float4x4 centerOfMassTransform,
            CollideShapeSettings settings, rvec3 baseOffset,
            ref CollideShapeResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CollideShape(Handle, shape.Handle, scale, centerOfMassTransform, settings, baseOffset, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }

        public bool CollideShape(Shape shape, float3 scale, float4x4 centerOfMassTransform,
            CollideShapeSettings settings, rvec3 baseOffset,
            CollisionCollectorType collectorType, ref CollideShapeResultCollector collector,
            BroadPhaseLayerFilter? broadPhaseLayerFilter = null,
            ObjectLayerFilter? objectLayerFilter = null,
            BodyFilter? bodyFilter = null,
            ShapeFilter? shapeFilter = null)
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterHandle = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Value.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterHandle = objectLayerFilter == null ? null : objectLayerFilter.Value.Handle;
            NativeHandle<JPH_BodyFilter>? bodyFilterHandle = bodyFilter == null ? null : bodyFilter.Value.Handle;
            NativeHandle<JPH_ShapeFilter>? shapeFilterHandle = shapeFilter == null ? null : shapeFilter.Value.Handle;

            return Bindings.JPH_NarrowPhaseQuery_CollideShape2(Handle, shape.Handle, scale, centerOfMassTransform, settings, baseOffset, collectorType, ref collector, broadPhaseLayerFilterHandle, objectLayerFilterHandle, bodyFilterHandle, shapeFilterHandle);
        }
        #endregion
    }
}