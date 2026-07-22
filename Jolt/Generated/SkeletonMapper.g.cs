using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct SkeletonMapper : IEquatable<SkeletonMapper>
    {
        internal readonly NativeHandle<JPH_SkeletonMapper> Handle;
        
        internal SkeletonMapper(NativeHandle<JPH_SkeletonMapper> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(SkeletonMapper other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is SkeletonMapper other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(SkeletonMapper lhs, SkeletonMapper rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(SkeletonMapper lhs, SkeletonMapper rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_SkeletonMapper
        
        public void Destroy() => Bindings.JPH_SkeletonMapper_Destroy(Handle);
        
        public void Initialize(Skeleton skeleton1, NativeArray<float4x4> neutralPose1, Skeleton skeleton2, NativeArray<float4x4> neutralPose2) => Bindings.JPH_SkeletonMapper_Initialize(Handle, skeleton1.Handle, neutralPose1, skeleton2.Handle, neutralPose2);
        
        public void LockAllTranslations(Skeleton skeleton, NativeArray<float4x4> neutralPose) => Bindings.JPH_SkeletonMapper_LockAllTranslations(Handle, skeleton.Handle, neutralPose);
        
        public void LockTranslations(Skeleton skeleton, NativeArray<NativeBool> lockedTranslations, NativeArray<float4x4> neutralPose) => Bindings.JPH_SkeletonMapper_LockTranslations(Handle, skeleton.Handle, lockedTranslations, neutralPose);
        
        public void Map(NativeArray<float4x4> pose1ModelSpace, NativeArray<float4x4> pose2LocalSpace, NativeArray<float4x4> outPose2ModelSpace) => Bindings.JPH_SkeletonMapper_Map(Handle, pose1ModelSpace, pose2LocalSpace, outPose2ModelSpace);
        
        public void MapReverse(NativeArray<float4x4> pose2ModelSpace, NativeArray<float4x4> outPose1ModelSpace) => Bindings.JPH_SkeletonMapper_MapReverse(Handle, pose2ModelSpace, outPose1ModelSpace);
        
        public int GetMappedJointIndex(int joint1Index) => Bindings.JPH_SkeletonMapper_GetMappedJointIndex(Handle, joint1Index);
        
        public bool IsJointTranslationLocked(int joint2Index) => Bindings.JPH_SkeletonMapper_IsJointTranslationLocked(Handle, joint2Index);
        
        #endregion
        
    }
}
