﻿using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct Shape : IEquatable<Shape>
    {
        internal readonly NativeHandle<JPH_Shape> Handle;
        
        internal Shape(NativeHandle<JPH_Shape> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(Shape other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is Shape other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(Shape lhs, Shape rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(Shape lhs, Shape rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_Shape
        
        public new ShapeType GetType() => Bindings.JPH_Shape_GetType(Handle);
        
        public ShapeSubType GetSubType() => Bindings.JPH_Shape_GetSubType(Handle);
        
        public ulong GetUserData() => Bindings.JPH_Shape_GetUserData(Handle);
        
        public void SetUserData(ulong userData) => Bindings.JPH_Shape_SetUserData(Handle, userData);
        
        public bool MustBeStatic() => Bindings.JPH_Shape_MustBeStatic(Handle);
        
        public float3 GetCenterOfMass() => Bindings.JPH_Shape_GetCenterOfMass(Handle);
        
        public AABox GetLocalBounds() => Bindings.JPH_Shape_GetLocalBounds(Handle);
        
        public uint GetSubShapeIDBitsRecursive() => Bindings.JPH_Shape_GetSubShapeIDBitsRecursive(Handle);
        
        public AABox GetWorldSpaceBounds(rmatrix4x4 centerOfMassTransform, float3 scale) => Bindings.JPH_Shape_GetWorldSpaceBounds(Handle, centerOfMassTransform, scale);
        
        public float GetInnerRadius() => Bindings.JPH_Shape_GetInnerRadius(Handle);
        
        public MassProperties GetMassProperties() => Bindings.JPH_Shape_GetMassProperties(Handle);
        
        public Shape GetLeafShape(SubShapeID subShapeID, out SubShapeID remainder) => new Shape(Bindings.JPH_Shape_GetLeafShape(Handle, subShapeID, out remainder));
        
        public PhysicsMaterial GetMaterial(SubShapeID subShapeID) => new PhysicsMaterial(Bindings.JPH_Shape_GetMaterial(Handle, subShapeID));
        
        public float3 GetSurfaceNormal(SubShapeID subShapeID, float3 localPosition) => Bindings.JPH_Shape_GetSurfaceNormal(Handle, subShapeID, localPosition);
        
        public float GetVolume() => Bindings.JPH_Shape_GetVolume(Handle);
        
        public bool IsValidScale(float3 scale) => Bindings.JPH_Shape_IsValidScale(Handle, scale);
        
        public float3 MakeScaleValid(float3 scale) => Bindings.JPH_Shape_MakeScaleValid(Handle, scale);
        
        public Shape ScaleShape(float3 scale) => new Shape(Bindings.JPH_Shape_ScaleShape(Handle, scale));
        
        public bool CastRay(float3 origin, float3 direction, out RayCastResult result) => Bindings.JPH_Shape_CastRay(Handle, origin, direction, out result);
        
        public bool CollidePoint(float3 point, ShapeFilter shapeFilter) => Bindings.JPH_Shape_CollidePoint(Handle, point, shapeFilter.Handle);
        
        #endregion
        
    }
}
