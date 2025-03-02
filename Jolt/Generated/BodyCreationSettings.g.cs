using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct BodyCreationSettings : IEquatable<BodyCreationSettings>
    {
        internal readonly NativeHandle<JPH_BodyCreationSettings> Handle;
        
        internal BodyCreationSettings(NativeHandle<JPH_BodyCreationSettings> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(BodyCreationSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is BodyCreationSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(BodyCreationSettings lhs, BodyCreationSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(BodyCreationSettings lhs, BodyCreationSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_BodyCreationSettings
        
        public void Destroy() => Bindings.JPH_BodyCreationSettings_Destroy(Handle);
        
        public rvec3 GetPosition() => Bindings.JPH_BodyCreationSettings_GetPosition(Handle);
        
        public void SetPosition(rvec3 value) => Bindings.JPH_BodyCreationSettings_SetPosition(Handle, value);
        
        public quaternion GetRotation() => Bindings.JPH_BodyCreationSettings_GetRotation(Handle);
        
        public void SetRotation(quaternion value) => Bindings.JPH_BodyCreationSettings_SetRotation(Handle, value);
        
        public float3 GetLinearVelocity() => Bindings.JPH_BodyCreationSettings_GetLinearVelocity(Handle);
        
        public void SetLinearVelocity(float3 velocity) => Bindings.JPH_BodyCreationSettings_SetLinearVelocity(Handle, velocity);
        
        public float3 GetAngularVelocity() => Bindings.JPH_BodyCreationSettings_GetAngularVelocity(Handle);
        
        public void SetAngularVelocity(float3 velocity) => Bindings.JPH_BodyCreationSettings_SetAngularVelocity(Handle, velocity);
        
        public ulong GetUserData() => Bindings.JPH_BodyCreationSettings_GetUserData(Handle);
        
        public void SetUserData(ulong userData) => Bindings.JPH_BodyCreationSettings_SetUserData(Handle, userData);
        
        public ObjectLayer GetObjectLayer() => Bindings.JPH_BodyCreationSettings_GetObjectLayer(Handle);
        
        public void SetObjectLayer(ObjectLayer objectLayer) => Bindings.JPH_BodyCreationSettings_SetObjectLayer(Handle, objectLayer);
        
        public MotionType GetMotionType() => Bindings.JPH_BodyCreationSettings_GetMotionType(Handle);
        
        public void SetMotionType(MotionType value) => Bindings.JPH_BodyCreationSettings_SetMotionType(Handle, value);
        
        public AllowedDOFs GetAllowedDOFs() => Bindings.JPH_BodyCreationSettings_GetAllowedDOFs(Handle);
        
        public void SetAllowedDOFs(AllowedDOFs value) => Bindings.JPH_BodyCreationSettings_SetAllowedDOFs(Handle, value);
        
        public bool GetAllowDynamicOrKinematic() => Bindings.JPH_BodyCreationSettings_GetAllowDynamicOrKinematic(Handle);
        
        public void SetAllowDynamicOrKinematic(bool value) => Bindings.JPH_BodyCreationSettings_SetAllowDynamicOrKinematic(Handle, value);
        
        public bool GetIsSensor() => Bindings.JPH_BodyCreationSettings_GetIsSensor(Handle);
        
        public void SetIsSensor(bool value) => Bindings.JPH_BodyCreationSettings_SetIsSensor(Handle, value);
        
        public bool GetCollideKinematicVsNonDynamic() => Bindings.JPH_BodyCreationSettings_GetCollideKinematicVsNonDynamic(Handle);
        
        public void SetCollideKinematicVsNonDynamic(bool value) => Bindings.JPH_BodyCreationSettings_SetCollideKinematicVsNonDynamic(Handle, value);
        
        public bool GetUseManifoldReduction() => Bindings.JPH_BodyCreationSettings_GetUseManifoldReduction(Handle);
        
        public void SetUseManifoldReduction(bool value) => Bindings.JPH_BodyCreationSettings_SetUseManifoldReduction(Handle, value);
        
        public bool GetApplyGyroscopicForce() => Bindings.JPH_BodyCreationSettings_GetApplyGyroscopicForce(Handle);
        
        public void SetApplyGyroscopicForce(bool value) => Bindings.JPH_BodyCreationSettings_SetApplyGyroscopicForce(Handle, value);
        
        public MotionQuality GetMotionQuality() => Bindings.JPH_BodyCreationSettings_GetMotionQuality(Handle);
        
        public void SetMotionQuality(MotionQuality value) => Bindings.JPH_BodyCreationSettings_SetMotionQuality(Handle, value);
        
        public bool GetEnhancedInternalEdgeRemoval() => Bindings.JPH_BodyCreationSettings_GetEnhancedInternalEdgeRemoval(Handle);
        
        public void SetEnhancedInternalEdgeRemoval(bool value) => Bindings.JPH_BodyCreationSettings_SetEnhancedInternalEdgeRemoval(Handle, value);
        
        public bool GetAllowSleeping() => Bindings.JPH_BodyCreationSettings_GetAllowSleeping(Handle);
        
        public void SetAllowSleeping(bool value) => Bindings.JPH_BodyCreationSettings_SetAllowSleeping(Handle, value);
        
        public float GetFriction() => Bindings.JPH_BodyCreationSettings_GetFriction(Handle);
        
        public void SetFriction(float value) => Bindings.JPH_BodyCreationSettings_SetFriction(Handle, value);
        
        public float GetRestitution() => Bindings.JPH_BodyCreationSettings_GetRestitution(Handle);
        
        public void SetRestitution(float value) => Bindings.JPH_BodyCreationSettings_SetRestitution(Handle, value);
        
        public float GetLinearDamping() => Bindings.JPH_BodyCreationSettings_GetLinearDamping(Handle);
        
        public void SetLinearDamping(float value) => Bindings.JPH_BodyCreationSettings_SetLinearDamping(Handle, value);
        
        public float GetAngularDamping() => Bindings.JPH_BodyCreationSettings_GetAngularDamping(Handle);
        
        public void SetAngularDamping(float value) => Bindings.JPH_BodyCreationSettings_SetAngularDamping(Handle, value);
        
        public float GetMaxLinearVelocity() => Bindings.JPH_BodyCreationSettings_GetMaxLinearVelocity(Handle);
        
        public void SetMaxLinearVelocity(float value) => Bindings.JPH_BodyCreationSettings_SetMaxLinearVelocity(Handle, value);
        
        public float GetMaxAngularVelocity() => Bindings.JPH_BodyCreationSettings_GetMaxAngularVelocity(Handle);
        
        public void SetMaxAngularVelocity(float value) => Bindings.JPH_BodyCreationSettings_SetMaxAngularVelocity(Handle, value);
        
        public float GetGravityFactor() => Bindings.JPH_BodyCreationSettings_GetGravityFactor(Handle);
        
        public void SetGravityFactor(float value) => Bindings.JPH_BodyCreationSettings_SetGravityFactor(Handle, value);
        
        public uint GetNumVelocityStepsOverride() => Bindings.JPH_BodyCreationSettings_GetNumVelocityStepsOverride(Handle);
        
        public void SetNumVelocityStepsOverride(uint value) => Bindings.JPH_BodyCreationSettings_SetNumVelocityStepsOverride(Handle, value);
        
        public uint GetNumPositionStepsOverride() => Bindings.JPH_BodyCreationSettings_GetNumPositionStepsOverride(Handle);
        
        public void SetNumPositionStepsOverride(uint value) => Bindings.JPH_BodyCreationSettings_SetNumPositionStepsOverride(Handle, value);
        
        public OverrideMassProperties GetOverrideMassProperties() => Bindings.JPH_BodyCreationSettings_GetOverrideMassProperties(Handle);
        
        public void SetOverrideMassProperties(OverrideMassProperties value) => Bindings.JPH_BodyCreationSettings_SetOverrideMassProperties(Handle, value);
        
        public float GetInertiaMultiplier() => Bindings.JPH_BodyCreationSettings_GetInertiaMultiplier(Handle);
        
        public void SetInertiaMultiplier(float value) => Bindings.JPH_BodyCreationSettings_SetInertiaMultiplier(Handle, value);
        
        public MassProperties GetMassPropertiesOverride() => Bindings.JPH_BodyCreationSettings_GetMassPropertiesOverride(Handle);
        
        public void SetMassPropertiesOVerride(MassProperties value) => Bindings.JPH_BodyCreationSettings_SetMassPropertiesOVerride(Handle, value);
        
        #endregion
        
    }
}
