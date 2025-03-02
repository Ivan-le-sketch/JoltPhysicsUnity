using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct JobSystem : IEquatable<JobSystem>
    {
        internal readonly NativeHandle<JPH_JobSystem> Handle;
        
        internal JobSystem(NativeHandle<JPH_JobSystem> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(JobSystem other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is JobSystem other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(JobSystem lhs, JobSystem rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(JobSystem lhs, JobSystem rhs) => !lhs.Equals(rhs);
        
        #endregion
        
    }
}
