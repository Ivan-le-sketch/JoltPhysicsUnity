﻿using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct MutableCompoundShapeSettings : IEquatable<MutableCompoundShapeSettings>
    {
        internal readonly NativeHandle<JPH_MutableCompoundShapeSettings> Handle;
        
        internal MutableCompoundShapeSettings(NativeHandle<JPH_MutableCompoundShapeSettings> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(MutableCompoundShapeSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is MutableCompoundShapeSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(MutableCompoundShapeSettings lhs, MutableCompoundShapeSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(MutableCompoundShapeSettings lhs, MutableCompoundShapeSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_MutableCompoundShapeSettings
        
        #endregion
        
        #region JPH_CompoundShapeSettings
        
        public void AddShape(float3 position, quaternion rotation, ShapeSettings settings, uint userData) => Bindings.JPH_CompoundShapeSettings_AddShape(Handle.Reinterpret<JPH_CompoundShapeSettings>(), position, rotation, settings.Handle, userData);
        
        public void AddShape(float3 position, quaternion rotation, Shape shape, uint userData) => Bindings.JPH_CompoundShapeSettings_AddShape(Handle.Reinterpret<JPH_CompoundShapeSettings>(), position, rotation, shape.Handle, userData);
        
        #endregion
        
        #region JPH_ShapeSettings
        
        public void Destroy() => Bindings.JPH_ShapeSettings_Destroy(Handle.Reinterpret<JPH_ShapeSettings>());
        
        #endregion
        
    }
}
