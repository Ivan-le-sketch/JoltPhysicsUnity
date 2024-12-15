using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct MutableCompoundShape : IEquatable<MutableCompoundShape>
    {
        internal readonly NativeHandle<JPH_MutableCompoundShape> Handle;
        
        internal MutableCompoundShape(NativeHandle<JPH_MutableCompoundShape> handle) => Handle = handle;
        
        #region IEquatable
        
        public bool Equals(MutableCompoundShape other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is MutableCompoundShape other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(MutableCompoundShape lhs, MutableCompoundShape rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(MutableCompoundShape lhs, MutableCompoundShape rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_MutableCompoundShape
        
        public MutableCompoundShape Create() => new MutableCompoundShape(Bindings.JPH_MutableCompoundShape_Create(Handle.Reinterpret<JPH_MutableCompoundShapeSettings>()));
        
        public uint AddShape(float3 position, quaternion rotation, Shape child, uint userData) => Bindings.JPH_MutableCompoundShape_AddShape(Handle, position, rotation, child.Handle, userData);
        
        public void RemoveShape(uint index) => Bindings.JPH_MutableCompoundShape_RemoveShape(Handle, index);
        
        public void ModifyShape(uint index, float3 position, quaternion rotation) => Bindings.JPH_MutableCompoundShape_ModifyShape(Handle, index, position, rotation);
        
        public void ModifyShape2(uint index, float3 position, quaternion rotation, Shape newShape) => Bindings.JPH_MutableCompoundShape_ModifyShape2(Handle, index, position, rotation, newShape.Handle);
        
        public void AdjustCenterOfMass() => Bindings.JPH_MutableCompoundShape_AdjustCenterOfMass(Handle);
        
        #endregion
        
    }
}
