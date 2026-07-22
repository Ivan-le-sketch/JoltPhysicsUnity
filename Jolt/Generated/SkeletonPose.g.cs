using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct SkeletonPose : IEquatable<SkeletonPose>
    {
        internal readonly NativeHandle<JPH_SkeletonPose> Handle;
        
        internal SkeletonPose(NativeHandle<JPH_SkeletonPose> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(SkeletonPose other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is SkeletonPose other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(SkeletonPose lhs, SkeletonPose rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(SkeletonPose lhs, SkeletonPose rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_SkeletonPose
        
        public void Destroy() => Bindings.JPH_SkeletonPose_Destroy(Handle);
        
        public void SetSkeleton(Skeleton skeleton) => Bindings.JPH_SkeletonPose_SetSkeleton(Handle, skeleton.Handle);
        
        public Skeleton GetSkeleton() => new Skeleton(Bindings.JPH_SkeletonPose_GetSkeleton(Handle));
        
        public void SetRootOffset(rvec3 offset) => Bindings.JPH_SkeletonPose_SetRootOffset(Handle, offset);
        
        public rvec3 GetRootOffset() => Bindings.JPH_SkeletonPose_GetRootOffset(Handle);
        
        public int GetJointCount() => Bindings.JPH_SkeletonPose_GetJointCount(Handle);
        
        public void GetJointState(int index, out float3 translation, out quaternion rotation) => Bindings.JPH_SkeletonPose_GetJointState(Handle, index, out translation, out rotation);
        
        public void SetJointState(int index, float3 translation, quaternion rotation) => Bindings.JPH_SkeletonPose_SetJointState(Handle, index, translation, rotation);
        
        public float4x4 GetJointMatrix(int index) => Bindings.JPH_SkeletonPose_GetJointMatrix(Handle, index);
        
        public void SetJointMatrix(int index, float4x4 matrix) => Bindings.JPH_SkeletonPose_SetJointMatrix(Handle, index, matrix);
        
        public int GetJointMatrices(NativeArray<float4x4> matrices) => Bindings.JPH_SkeletonPose_GetJointMatrices(Handle, matrices);
        
        public int SetJointMatrices(NativeArray<float4x4> matrices) => Bindings.JPH_SkeletonPose_SetJointMatrices(Handle, matrices);
        
        public void CalculateJointMatrices() => Bindings.JPH_SkeletonPose_CalculateJointMatrices(Handle);
        
        public void CalculateJointStates() => Bindings.JPH_SkeletonPose_CalculateJointStates(Handle);
        
        public int CalculateLocalSpaceJointMatrices(NativeArray<float4x4> matrices) => Bindings.JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(Handle, matrices);
        
        #endregion
        
    }
}
