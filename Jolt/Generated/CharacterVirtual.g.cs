using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct CharacterVirtual : IEquatable<CharacterVirtual>
    {
        internal readonly NativeHandle<JPH_CharacterVirtual> Handle;
        
        internal CharacterVirtual(NativeHandle<JPH_CharacterVirtual> handle) => Handle = handle;
        
        #region IEquatable
        
        public bool Equals(CharacterVirtual other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is CharacterVirtual other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(CharacterVirtual lhs, CharacterVirtual rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(CharacterVirtual lhs, CharacterVirtual rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_CharacterVirtual
        
        public float3 GetLinearVelocity() => Bindings.JPH_CharacterVirtual_GetLinearVelocity(Handle);
        
        public void SetLinearVelocity(float3 velocity) => Bindings.JPH_CharacterVirtual_SetLinearVelocity(Handle, velocity);
        
        public rvec3 GetPosition() => Bindings.JPH_CharacterVirtual_GetPosition(Handle);
        
        public void SetPosition(rvec3 position) => Bindings.JPH_CharacterVirtual_SetPosition(Handle, position);
        
        public quaternion GetRotation() => Bindings.JPH_CharacterVirtual_GetRotation(Handle);
        
        public void SetRotation(quaternion rotation) => Bindings.JPH_CharacterVirtual_SetRotation(Handle, rotation);
        
        public rmatrix4x4 GetWorlTransform() => Bindings.JPH_CharacterVirtual_GetWorlTransform(Handle);
        
        public rmatrix4x4 GetCenterOfMassTransform() => Bindings.JPH_CharacterVirtual_GetCenterOfMassTransform(Handle);
        
        public float GetMass() => Bindings.JPH_CharacterVirtual_GetMass(Handle);
        
        public void SetMass(float value) => Bindings.JPH_CharacterVirtual_SetMass(Handle, value);
        
        public float GetMaxStrength() => Bindings.JPH_CharacterVirtual_GetMaxStrength(Handle);
        
        public void SetMaxStrength(float value) => Bindings.JPH_CharacterVirtual_SetMaxStrength(Handle, value);
        
        public float GetPenetrationRecoverySpeed() => Bindings.JPH_CharacterVirtual_GetPenetrationRecoverySpeed(Handle);
        
        public void SetPenetrationRecoverySpeed(float value) => Bindings.JPH_CharacterVirtual_SetPenetrationRecoverySpeed(Handle, value);
        
        public bool GetEnhancedInternalEdgeRemoval() => Bindings.JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(Handle);
        
        public void SetEnhancedInternalEdgeRemoval(bool value) => Bindings.JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(Handle.Reinterpret<JPH_CharacterVirtual >(), value);
        
        public float GetCharacterPadding() => Bindings.JPH_CharacterVirtual_GetCharacterPadding(Handle);
        
        public uint GetMaxNumHits() => Bindings.JPH_CharacterVirtual_GetMaxNumHits(Handle);
        
        public void SetMaxNumHits(uint value) => Bindings.JPH_CharacterVirtual_SetMaxNumHits(Handle, value);
        
        public float GetHitReductionCosMaxAngle() => Bindings.JPH_CharacterVirtual_GetHitReductionCosMaxAngle(Handle);
        
        public void SetHitReductionCosMaxAngle(float value) => Bindings.JPH_CharacterVirtual_SetHitReductionCosMaxAngle(Handle, value);
        
        public bool GetMaxHitsExceeded() => Bindings.JPH_CharacterVirtual_GetMaxHitsExceeded(Handle);
        
        public float3 GetShapeOffset() => Bindings.JPH_CharacterVirtual_GetShapeOffset(Handle);
        
        public void SetShapeOffset(float3 value) => Bindings.JPH_CharacterVirtual_SetShapeOffset(Handle, value);
        
        public ulong GetUserData() => Bindings.JPH_CharacterVirtual_GetUserData(Handle);
        
        public void SetUserData(ulong value) => Bindings.JPH_CharacterVirtual_SetUserData(Handle, value);
        
        public void CancelVelocityTowardsSteepSlopes(float3 desiredVelocity, float3 velocity) => Bindings.JPH_CharacterVirtual_CancelVelocityTowardsSteepSlopes(Handle, desiredVelocity, velocity);
        
        public void Update(float deltaTime, ObjectLayer layer, PhysicsSystem system) => Bindings.JPH_CharacterVirtual_Update(Handle, deltaTime, layer, system.Handle);
        
        public void ExtendedUpdate(float deltaTime, ExtendedUpdateSettings settings, ObjectLayer layer, PhysicsSystem system) => Bindings.JPH_CharacterVirtual_ExtendedUpdate(Handle, deltaTime, settings, layer, system.Handle);
        
        public void RefreshContacts(ObjectLayer layer, PhysicsSystem system) => Bindings.JPH_CharacterVirtual_RefreshContacts(Handle, layer, system.Handle);
        
        #endregion
        
        #region JPH_CharacterBase
        
        public void Destroy() => Bindings.JPH_CharacterBase_Destroy(Handle.Reinterpret<JPH_CharacterBase>());
        
        public float GetCosMaxSlopeAngle() => Bindings.JPH_CharacterBase_GetCosMaxSlopeAngle(Handle.Reinterpret<JPH_CharacterBase>());
        
        public void SetMaxSlopeAngle(float maxSlopeAngle) => Bindings.JPH_CharacterBase_SetMaxSlopeAngle(Handle.Reinterpret<JPH_CharacterBase>(), maxSlopeAngle);
        
        public float3 GetUp() => Bindings.JPH_CharacterBase_GetUp(Handle.Reinterpret<JPH_CharacterBase>());
        
        public void SetUp(float3 value) => Bindings.JPH_CharacterBase_SetUp(Handle.Reinterpret<JPH_CharacterBase>(), value);
        
        public bool IsSlopeTooSteep(float3 value) => Bindings.JPH_CharacterBase_IsSlopeTooSteep(Handle.Reinterpret<JPH_CharacterBase>(), value);
        
        public Shape GetShape() => new Shape(Bindings.JPH_CharacterBase_GetShape(Handle.Reinterpret<JPH_CharacterBase>()));
        
        public GroundState GetGroundState() => Bindings.JPH_CharacterBase_GetGroundState(Handle.Reinterpret<JPH_CharacterBase>());
        
        public bool IsSupported() => Bindings.JPH_CharacterBase_IsSupported(Handle.Reinterpret<JPH_CharacterBase>());
        
        public rvec3 GetGroundPosition() => Bindings.JPH_CharacterBase_GetGroundPosition(Handle.Reinterpret<JPH_CharacterBase>());
        
        public float3 GetGroundNormal() => Bindings.JPH_CharacterBase_GetGroundNormal(Handle.Reinterpret<JPH_CharacterBase>());
        
        public float3 GetGroundVelocity() => Bindings.JPH_CharacterBase_GetGroundVelocity(Handle.Reinterpret<JPH_CharacterBase>());
        
        public PhysicsMaterial GetGroundMaterial() => new PhysicsMaterial(Bindings.JPH_CharacterBase_GetGroundMaterial(Handle.Reinterpret<JPH_CharacterBase>()));
        
        public BodyID GetGroundBodyId() => Bindings.JPH_CharacterBase_GetGroundBodyId(Handle.Reinterpret<JPH_CharacterBase>());
        
        public SubShapeID GetGroundSubShapeId() => Bindings.JPH_CharacterBase_GetGroundSubShapeId(Handle.Reinterpret<JPH_CharacterBase>());
        
        public ulong GetGroundUserData() => Bindings.JPH_CharacterBase_GetGroundUserData(Handle.Reinterpret<JPH_CharacterBase>());
        
        #endregion
        
    }
}
