using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct CollisionEstimationResult : IEquatable<CollisionEstimationResult>
    {
        internal readonly NativeHandle<JPH_CollisionEstimationResult> Handle;
        
        internal CollisionEstimationResult(NativeHandle<JPH_CollisionEstimationResult> handle) => Handle = handle;
        
        #region IEquatable
        
        public bool Equals(CollisionEstimationResult other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is CollisionEstimationResult other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(CollisionEstimationResult lhs, CollisionEstimationResult rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(CollisionEstimationResult lhs, CollisionEstimationResult rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_CollisionEstimationResult
        
        public void Destroy() => Bindings.JPH_CollisionEstimationResult_Destroy(Handle);
        
        public float3 GetLinearVelocity1() => Bindings.JPH_CollisionEstimationResult_GetLinearVelocity1(Handle);
        
        public float3 GetLinearVelocity2() => Bindings.JPH_CollisionEstimationResult_GetLinearVelocity2(Handle);
        
        public float3 GetAngularVelocity1() => Bindings.JPH_CollisionEstimationResult_GetAngularVelocity1(Handle);
        
        public float3 GetAngularVelocity2() => Bindings.JPH_CollisionEstimationResult_GetAngularVelocity2(Handle);
        
        public float3 GetTangent1() => Bindings.JPH_CollisionEstimationResult_GetTangent1(Handle);
        
        public float3 GetTangent2() => Bindings.JPH_CollisionEstimationResult_GetTangent2(Handle);
        
        public uint GetImpulsesCount() => Bindings.JPH_CollisionEstimationResult_GetImpulsesCount(Handle);
        
        #endregion
        
    }
}
