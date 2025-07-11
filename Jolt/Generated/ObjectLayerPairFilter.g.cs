﻿using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct ObjectLayerPairFilter : IEquatable<ObjectLayerPairFilter>
    {
        internal readonly NativeHandle<JPH_ObjectLayerPairFilter> Handle;
        
        internal ObjectLayerPairFilter(NativeHandle<JPH_ObjectLayerPairFilter> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(ObjectLayerPairFilter other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is ObjectLayerPairFilter other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(ObjectLayerPairFilter lhs, ObjectLayerPairFilter rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(ObjectLayerPairFilter lhs, ObjectLayerPairFilter rhs) => !lhs.Equals(rhs);
        
        #endregion
        
    }
}
