using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct PhysicsMaterial : IEquatable<PhysicsMaterial>
    {
        internal readonly NativeHandle<JPH_PhysicsMaterial> Handle;
        
        internal PhysicsMaterial(NativeHandle<JPH_PhysicsMaterial> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(PhysicsMaterial other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is PhysicsMaterial other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(PhysicsMaterial lhs, PhysicsMaterial rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(PhysicsMaterial lhs, PhysicsMaterial rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_PhysicsMaterial
        
        public void Destroy() => Bindings.JPH_PhysicsMaterial_Destroy(Handle);
        
        #endregion
        
    }
}
