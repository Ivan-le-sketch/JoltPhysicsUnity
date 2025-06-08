using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct StaticCompoundShape : IEquatable<StaticCompoundShape>
    {
        internal readonly NativeHandle<JPH_StaticCompoundShape> Handle;
        
        internal StaticCompoundShape(NativeHandle<JPH_StaticCompoundShape> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(StaticCompoundShape other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is StaticCompoundShape other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(StaticCompoundShape lhs, StaticCompoundShape rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(StaticCompoundShape lhs, StaticCompoundShape rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_StaticCompoundShape
        
        public StaticCompoundShape Create() => new StaticCompoundShape(Bindings.JPH_StaticCompoundShape_Create(Handle.Reinterpret<JPH_StaticCompoundShapeSettings>()));
        
        #endregion
        
        #region JPH_CompoundShape
        
        public uint GetNumSubShapes() => Bindings.JPH_CompoundShape_GetNumSubShapes(Handle.Reinterpret<JPH_CompoundShape>());
        
        public uint GetSubShapeIndexFromID(SubShapeID id, out SubShapeID remainder) => Bindings.JPH_CompoundShape_GetSubShapeIndexFromID(Handle.Reinterpret<JPH_CompoundShape>(), id, out remainder);
        
        #endregion
        
        #region JPH_Shape
        
        public void Destroy() => Bindings.JPH_Shape_Destroy(Handle.Reinterpret<JPH_Shape>());
        
        public new ShapeType GetType() => Bindings.JPH_Shape_GetType(Handle.Reinterpret<JPH_Shape>());
        
        public ShapeSubType GetSubType() => Bindings.JPH_Shape_GetSubType(Handle.Reinterpret<JPH_Shape>());
        
        public ulong GetUserData() => Bindings.JPH_Shape_GetUserData(Handle.Reinterpret<JPH_Shape>());
        
        public void SetUserData(ulong userData) => Bindings.JPH_Shape_SetUserData(Handle.Reinterpret<JPH_Shape>(), userData);
        
        public bool MustBeStatic() => Bindings.JPH_Shape_MustBeStatic(Handle.Reinterpret<JPH_Shape>());
        
        public float3 GetCenterOfMass() => Bindings.JPH_Shape_GetCenterOfMass(Handle.Reinterpret<JPH_Shape>());
        
        public AABox GetLocalBounds() => Bindings.JPH_Shape_GetLocalBounds(Handle.Reinterpret<JPH_Shape>());
        
        public uint GetSubShapeIDBitsRecursive() => Bindings.JPH_Shape_GetSubShapeIDBitsRecursive(Handle.Reinterpret<JPH_Shape>());
        
        public AABox GetWorldSpaceBounds(rmatrix4x4 centerOfMassTransform, float3 scale) => Bindings.JPH_Shape_GetWorldSpaceBounds(Handle.Reinterpret<JPH_Shape>(), centerOfMassTransform, scale);
        
        public float GetInnerRadius() => Bindings.JPH_Shape_GetInnerRadius(Handle.Reinterpret<JPH_Shape>());
        
        public MassProperties GetMassProperties() => Bindings.JPH_Shape_GetMassProperties(Handle.Reinterpret<JPH_Shape>());
        
        public Shape GetLeafShape(SubShapeID subShapeID, out SubShapeID remainder) => new Shape(Bindings.JPH_Shape_GetLeafShape(Handle.Reinterpret<JPH_Shape>(), subShapeID, out remainder));
        
        public PhysicsMaterial GetMaterial(SubShapeID subShapeID) => new PhysicsMaterial(Bindings.JPH_Shape_GetMaterial(Handle.Reinterpret<JPH_Shape>(), subShapeID));
        
        public float3 GetSurfaceNormal(SubShapeID subShapeID, float3 localPosition) => Bindings.JPH_Shape_GetSurfaceNormal(Handle.Reinterpret<JPH_Shape>(), subShapeID, localPosition);
        
        public float GetVolume() => Bindings.JPH_Shape_GetVolume(Handle.Reinterpret<JPH_Shape>());
        
        public bool IsValidScale(float3 scale) => Bindings.JPH_Shape_IsValidScale(Handle.Reinterpret<JPH_Shape>(), scale);
        
        public float3 MakeScaleValid(float3 scale) => Bindings.JPH_Shape_MakeScaleValid(Handle.Reinterpret<JPH_Shape>(), scale);
        
        public Shape ScaleShape(float3 scale) => new Shape(Bindings.JPH_Shape_ScaleShape(Handle.Reinterpret<JPH_Shape>(), scale));
        
        public bool CastRay(float3 origin, float3 direction, out RayCastResult result) => Bindings.JPH_Shape_CastRay(Handle.Reinterpret<JPH_Shape>(), origin, direction, out result);
        
        public bool CollidePoint(float3 point, ShapeFilter shapeFilter) => Bindings.JPH_Shape_CollidePoint(Handle.Reinterpret<JPH_Shape>(), point, shapeFilter.Handle);
        
        #endregion
        
    }
}
