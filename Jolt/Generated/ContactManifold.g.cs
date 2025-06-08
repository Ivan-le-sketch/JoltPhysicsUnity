using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct ContactManifold : IEquatable<ContactManifold>
    {
        internal readonly NativeHandle<JPH_ContactManifold> Handle;
        
        internal ContactManifold(NativeHandle<JPH_ContactManifold> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(ContactManifold other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is ContactManifold other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(ContactManifold lhs, ContactManifold rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(ContactManifold lhs, ContactManifold rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_ContactManifold
        
        public float3 GetWorldSpaceNormal() => Bindings.JPH_ContactManifold_GetWorldSpaceNormal(Handle);
        
        public float GetPenetrationDepth() => Bindings.JPH_ContactManifold_GetPenetrationDepth(Handle);
        
        public SubShapeID GetSubShapeID1() => Bindings.JPH_ContactManifold_GetSubShapeID1(Handle);
        
        public SubShapeID GetSubShapeID2() => Bindings.JPH_ContactManifold_GetSubShapeID2(Handle);
        
        public uint GetPointCount() => Bindings.JPH_ContactManifold_GetPointCount(Handle);
        
        public rvec3 GetWorldSpaceContactPointOn1(uint index) => Bindings.JPH_ContactManifold_GetWorldSpaceContactPointOn1(Handle, index);
        
        public rvec3 GetWorldSpaceContactPointOn2(uint index) => Bindings.JPH_ContactManifold_GetWorldSpaceContactPointOn2(Handle, index);
        
        #endregion
        
    }
}
