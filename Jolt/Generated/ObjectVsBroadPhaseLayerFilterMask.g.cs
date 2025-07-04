﻿using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct ObjectVsBroadPhaseLayerFilterMask : IEquatable<ObjectVsBroadPhaseLayerFilterMask>
    {
        internal readonly NativeHandle<JPH_ObjectVsBroadPhaseLayerFilter> Handle;
        
        internal ObjectVsBroadPhaseLayerFilterMask(NativeHandle<JPH_ObjectVsBroadPhaseLayerFilter> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(ObjectVsBroadPhaseLayerFilterMask other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is ObjectVsBroadPhaseLayerFilterMask other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(ObjectVsBroadPhaseLayerFilterMask lhs, ObjectVsBroadPhaseLayerFilterMask rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(ObjectVsBroadPhaseLayerFilterMask lhs, ObjectVsBroadPhaseLayerFilterMask rhs) => !lhs.Equals(rhs);
        
        #endregion
        
    }
}
