using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct SkeletalAnimation : IEquatable<SkeletalAnimation>
    {
        internal readonly NativeHandle<JPH_SkeletalAnimation> Handle;
        
        internal SkeletalAnimation(NativeHandle<JPH_SkeletalAnimation> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(SkeletalAnimation other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is SkeletalAnimation other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(SkeletalAnimation lhs, SkeletalAnimation rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(SkeletalAnimation lhs, SkeletalAnimation rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_SkeletalAnimation
        
        public void Destroy() => Bindings.JPH_SkeletalAnimation_Destroy(Handle);
        
        public float GetDuration() => Bindings.JPH_SkeletalAnimation_GetDuration(Handle);
        
        public bool IsLooping() => Bindings.JPH_SkeletalAnimation_IsLooping(Handle);
        
        public void SetIsLooping(bool looping) => Bindings.JPH_SkeletalAnimation_SetIsLooping(Handle, looping);
        
        public void ScaleJoints(float scale) => Bindings.JPH_SkeletalAnimation_ScaleJoints(Handle, scale);
        
        public void Sample(float time, SkeletonPose pose) => Bindings.JPH_SkeletalAnimation_Sample(Handle, time, pose.Handle);
        
        public int GetAnimatedJointCount() => Bindings.JPH_SkeletalAnimation_GetAnimatedJointCount(Handle);
        
        public int AddAnimatedJoint(string jointName) => Bindings.JPH_SkeletalAnimation_AddAnimatedJoint(Handle, jointName);
        
        public bool AddKeyframe(int jointIndex, float time, float3 translation, quaternion rotation) => Bindings.JPH_SkeletalAnimation_AddKeyframe(Handle, jointIndex, time, translation, rotation);
        
        #endregion
        
    }
}
