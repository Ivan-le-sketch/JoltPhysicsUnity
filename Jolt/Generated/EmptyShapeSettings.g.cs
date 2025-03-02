using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct EmptyShapeSettings : IEquatable<EmptyShapeSettings>
    {
        internal readonly NativeHandle<JPH_EmptyShapeSettings> Handle;
        
        internal EmptyShapeSettings(NativeHandle<JPH_EmptyShapeSettings> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(EmptyShapeSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is EmptyShapeSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(EmptyShapeSettings lhs, EmptyShapeSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(EmptyShapeSettings lhs, EmptyShapeSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_EmptyShapeSettings
        
        public EmptyShape CreateShape() => new EmptyShape(Bindings.JPH_EmptyShapeSettings_CreateShape(Handle));
        
        #endregion
        
        #region JPH_ShapeSettings
        
        public void Destroy() => Bindings.JPH_ShapeSettings_Destroy(Handle.Reinterpret<JPH_ShapeSettings>());
        
        #endregion
        
    }
}
