﻿using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct BodyLockInterface : IEquatable<BodyLockInterface>
    {
        internal readonly NativeHandle<JPH_BodyLockInterface> Handle;
        
        internal BodyLockInterface(NativeHandle<JPH_BodyLockInterface> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(BodyLockInterface other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is BodyLockInterface other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(BodyLockInterface lhs, BodyLockInterface rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(BodyLockInterface lhs, BodyLockInterface rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_BodyLockInterface
        
        #endregion
        
    }
}
