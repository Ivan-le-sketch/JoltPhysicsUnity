using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct ContactSettings : IEquatable<ContactSettings>
    {
        internal readonly NativeHandle<JPH_ContactSettings> Handle;
        
        internal ContactSettings(NativeHandle<JPH_ContactSettings> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(ContactSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is ContactSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(ContactSettings lhs, ContactSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(ContactSettings lhs, ContactSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_ContactSettings
        
        public float GetFriction() => Bindings.JPH_ContactSettings_GetFriction(Handle);
        
        public void SetFriction(float friction) => Bindings.JPH_ContactSettings_SetFriction(Handle, friction);
        
        public float GetRestitution() => Bindings.JPH_ContactSettings_GetRestitution(Handle);
        
        public void SetRestitution(float restitution) => Bindings.JPH_ContactSettings_SetRestitution(Handle, restitution);
        
        public float GetInvMassScale1() => Bindings.JPH_ContactSettings_GetInvMassScale1(Handle);
        
        public void SetInvMassScale1(float scale) => Bindings.JPH_ContactSettings_SetInvMassScale1(Handle, scale);
        
        public float GetInvInertiaScale1() => Bindings.JPH_ContactSettings_GetInvInertiaScale1(Handle);
        
        public void SetInvInertiaScale1(float scale) => Bindings.JPH_ContactSettings_SetInvInertiaScale1(Handle, scale);
        
        public float GetInvMassScale2() => Bindings.JPH_ContactSettings_GetInvMassScale2(Handle);
        
        public void SetInvMassScale2(float scale) => Bindings.JPH_ContactSettings_SetInvMassScale2(Handle, scale);
        
        public float GetInvInertiaScale2() => Bindings.JPH_ContactSettings_GetInvInertiaScale2(Handle);
        
        public void SetInvInertiaScale2(float scale) => Bindings.JPH_ContactSettings_SetInvInertiaScale2(Handle, scale);
        
        public bool GetIsSensor() => Bindings.JPH_ContactSettings_GetIsSensor(Handle);
        
        public void SetIsSensor(bool sensor) => Bindings.JPH_ContactSettings_SetIsSensor(Handle, sensor);
        
        public float3 GetRelativeLinearSurfaceVelocity() => Bindings.JPH_ContactSettings_GetRelativeLinearSurfaceVelocity(Handle);
        
        public void SetRelativeLinearSurfaceVelocity(float3 velocity) => Bindings.JPH_ContactSettings_SetRelativeLinearSurfaceVelocity(Handle, velocity);
        
        public float3 GetRelativeAngularSurfaceVelocity() => Bindings.JPH_ContactSettings_GetRelativeAngularSurfaceVelocity(Handle);
        
        public void SetRelativeAngularSurfaceVelocity(float3 velocity) => Bindings.JPH_ContactSettings_SetRelativeAngularSurfaceVelocity(Handle, velocity);
        
        #endregion
        
    }
}
