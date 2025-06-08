using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct ObjectVsBroadPhaseLayerFilterTable : IEquatable<ObjectVsBroadPhaseLayerFilterTable>
    {
        internal readonly NativeHandle<JPH_ObjectVsBroadPhaseLayerFilter> Handle;
        
        internal ObjectVsBroadPhaseLayerFilterTable(NativeHandle<JPH_ObjectVsBroadPhaseLayerFilter> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(ObjectVsBroadPhaseLayerFilterTable other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is ObjectVsBroadPhaseLayerFilterTable other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(ObjectVsBroadPhaseLayerFilterTable lhs, ObjectVsBroadPhaseLayerFilterTable rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(ObjectVsBroadPhaseLayerFilterTable lhs, ObjectVsBroadPhaseLayerFilterTable rhs) => !lhs.Equals(rhs);
        
        #endregion
        
    }
}
