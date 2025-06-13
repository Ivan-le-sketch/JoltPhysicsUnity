using System;
using Unity.Mathematics;

namespace Jolt
{
    public unsafe struct BroadPhaseQuery : IEquatable<BroadPhaseQuery>
    {
        internal readonly NativeHandle<JPH_BroadPhaseQuery> Handle;

        internal BroadPhaseQuery(NativeHandle<JPH_BroadPhaseQuery> handle) => Handle = handle;

        #region IEquatable

        public bool Equals(BroadPhaseQuery other) => Handle.Equals(other.Handle);

        public override bool Equals(object obj) => obj is BroadPhaseQuery other && Equals(other);

        public override int GetHashCode() => Handle.GetHashCode();

        public static bool operator ==(BroadPhaseQuery lhs, BroadPhaseQuery rhs) => lhs.Equals(rhs);

        public static bool operator !=(BroadPhaseQuery lhs, BroadPhaseQuery rhs) => !lhs.Equals(rhs);

        #endregion

        #region JPH_BroadPhaseQuery

        /*public bool CastRay(float3 origin, float3 direction, CollisionCollector<BroadPhaseCastResult> collector, IntPtr userData, BroadPhaseLayerFilter broadPhaseLayerFilter, ObjectLayerFilter objectLayerFilter) 
        {
            NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilterPtr = broadPhaseLayerFilter == null ? null : broadPhaseLayerFilter.Handle;
            NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilterPtr = objectLayerFilter == null ? null : objectLayerFilter.Handle;

            return Bindings.JPH_BroadPhaseQuery_CastRay(Handle, origin, direction, collector, userData, broadPhaseLayerFilterPtr, objectLayerFilterPtr);
        }*/

        #endregion
    }
}
