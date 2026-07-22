using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct Skeleton : IEquatable<Skeleton>
    {
        internal readonly NativeHandle<JPH_Skeleton> Handle;
        
        internal Skeleton(NativeHandle<JPH_Skeleton> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(Skeleton other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is Skeleton other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(Skeleton lhs, Skeleton rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(Skeleton lhs, Skeleton rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_Skeleton
        
        public void Destroy() => Bindings.JPH_Skeleton_Destroy(Handle);
        
        public uint AddJoint(string name) => Bindings.JPH_Skeleton_AddJoint(Handle, name);
        
        public uint AddJoint(string name, int parentIndex) => Bindings.JPH_Skeleton_AddJoint(Handle, name, parentIndex);
        
        public uint AddJoint(string name, string parentName) => Bindings.JPH_Skeleton_AddJoint(Handle, name, parentName);
        
        public int GetJointCount() => Bindings.JPH_Skeleton_GetJointCount(Handle);
        
        public SkeletonJoint GetJoint(int index) => Bindings.JPH_Skeleton_GetJoint(Handle, index);
        
        public int GetJointIndex(string name) => Bindings.JPH_Skeleton_GetJointIndex(Handle, name);
        
        public void CalculateParentJointIndices() => Bindings.JPH_Skeleton_CalculateParentJointIndices(Handle);
        
        public bool AreJointsCorrectlyOrdered() => Bindings.JPH_Skeleton_AreJointsCorrectlyOrdered(Handle);
        
        #endregion
        
    }
}
