using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Unity.Mathematics;

namespace Jolt
{
    [Flags]
    public enum ContactCallbackFlags : uint
    {
        None = 0,
        Validate = 1u << 0,
        Added = 1u << 1,
        Persisted = 1u << 2,
        Removed = 1u << 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ContactBodyData
    {
        private const uint StaticBody = 1u << 0;

        internal nint BodyPointer;
        public ulong BodyUserData;
        public BodyID BodyID;
        public ObjectLayer ObjectLayer;
        internal uint BodyFlags;
        public float3 LinearVelocity;
        public float3 AngularVelocity;

        public Body GetBody() => new Body(new NativeHandle<JPH_Body>((JPH_Body*)BodyPointer));
        public BodyID GetID() => BodyID;
        public ulong GetUserData() => BodyUserData;
        public ObjectLayer GetObjectLayer() => ObjectLayer;
        public bool IsStatic() => (BodyFlags & StaticBody) != 0;
        public float3 GetLinearVelocity() => LinearVelocity;
        public float3 GetAngularVelocity() => AngularVelocity;

        public static implicit operator Body(ContactBodyData data) => data.GetBody();
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ContactManifoldData
    {
        internal nint ManifoldPointer;
        public float3 WorldSpaceNormal;
        public float PenetrationDepth;
        public SubShapeID SubShapeID1;
        public SubShapeID SubShapeID2;
        public uint PointCount;

        public ContactManifold GetManifold() => new ContactManifold(new NativeHandle<JPH_ContactManifold>((JPH_ContactManifold*)ManifoldPointer));
        public float3 GetWorldSpaceNormal() => WorldSpaceNormal;
        public float GetPenetrationDepth() => PenetrationDepth;
        public SubShapeID GetSubShapeID1() => SubShapeID1;
        public SubShapeID GetSubShapeID2() => SubShapeID2;
        public uint GetPointCount() => PointCount;

        public rvec3 GetWorldSpaceContactPointOn1(uint index) =>
            Bindings.JPH_ContactManifold_GetWorldSpaceContactPointOn1(new NativeHandle<JPH_ContactManifold>((JPH_ContactManifold*)ManifoldPointer), index);

        public rvec3 GetWorldSpaceContactPointOn2(uint index) =>
            Bindings.JPH_ContactManifold_GetWorldSpaceContactPointOn2(new NativeHandle<JPH_ContactManifold>((JPH_ContactManifold*)ManifoldPointer), index);

        public uint GetWorldSpaceContactPointsOn1(rvec3* results, uint capacity) =>
            Bindings.JPH_ContactManifold_GetWorldSpaceContactPointsOn1(new NativeHandle<JPH_ContactManifold>((JPH_ContactManifold*)ManifoldPointer), results, capacity);

        public uint GetWorldSpaceContactPointsOn2(rvec3* results, uint capacity) =>
            Bindings.JPH_ContactManifold_GetWorldSpaceContactPointsOn2(new NativeHandle<JPH_ContactManifold>((JPH_ContactManifold*)ManifoldPointer), results, capacity);

        public static implicit operator ContactManifold(ContactManifoldData data) => data.GetManifold();
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ContactSettingsData
    {
        public float Friction;
        public float Restitution;
        public float InvMassScale1;
        public float InvInertiaScale1;
        public float InvMassScale2;
        public float InvInertiaScale2;
        internal uint IsSensorValue;
        public float3 RelativeLinearSurfaceVelocity;
        public float3 RelativeAngularSurfaceVelocity;

        public float GetFriction() => Friction;
        public void SetFriction(float value) => Friction = value;
        public float GetRestitution() => Restitution;
        public void SetRestitution(float value) => Restitution = value;
        public float GetInvMassScale1() => InvMassScale1;
        public void SetInvMassScale1(float value) => InvMassScale1 = value;
        public float GetInvInertiaScale1() => InvInertiaScale1;
        public void SetInvInertiaScale1(float value) => InvInertiaScale1 = value;
        public float GetInvMassScale2() => InvMassScale2;
        public void SetInvMassScale2(float value) => InvMassScale2 = value;
        public float GetInvInertiaScale2() => InvInertiaScale2;
        public void SetInvInertiaScale2(float value) => InvInertiaScale2 = value;
        public bool GetIsSensor() => IsSensorValue != 0;
        public void SetIsSensor(bool value) => IsSensorValue = value ? 1u : 0u;
        public float3 GetRelativeLinearSurfaceVelocity() => RelativeLinearSurfaceVelocity;
        public void SetRelativeLinearSurfaceVelocity(float3 value) => RelativeLinearSurfaceVelocity = value;
        public float3 GetRelativeAngularSurfaceVelocity() => RelativeAngularSurfaceVelocity;
        public void SetRelativeAngularSurfaceVelocity(float3 value) => RelativeAngularSurfaceVelocity = value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ContactValidateData
    {
        public ContactBodyData Body1;
        public ContactBodyData Body2;
        internal nint CollisionResultPointer;
        public rvec3 BaseOffset;

        public CollideShapeResult GetCollisionResult() => *(CollideShapeResult*)CollisionResultPointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ContactData
    {
        public ContactBodyData Body1;
        public ContactBodyData Body2;
        public ContactManifoldData Manifold;
        public ContactSettingsData Settings;
    }

    /// <summary>
    /// Callback-scoped listener data that avoids nested native calls for common body, manifold and settings access.
    /// Do not retain the native wrappers after the callback returns.
    /// </summary>
    public interface IFastContactListenerImplementation
    {
        ValidateResult OnContactValidate(ref ContactValidateData contact);
        void OnContactAdded(ref ContactData contact);
        void OnContactPersisted(ref ContactData contact);
        void OnContactRemoved(SubShapeIDPair subShapePair);
    }

    /// <summary>
    /// Interface that mus be implemented by contact listener implementations.
    /// </summary>
    public interface IContactListenerImplementation
    {
        public ValidateResult OnContactValidate(Body body1, Body body2, rvec3 offset, CollideShapeResult result);

        public void OnContactAdded(Body body1, Body body2, ContactManifold manifold, ContactSettings settings);
        public void OnContactPersisted(Body body1, Body body2, ContactManifold manifold, ContactSettings settings);
        public void OnContactRemoved(SubShapeIDPair subShapePair);
    }

    public partial struct ContactListener
    {
        internal NativeHandle<JPH_ContactListener> Handle;

        public static ContactListener Create(IContactListenerImplementation implementation)
        {
            return new ContactListener { Handle = Bindings.JPH_ContactListener_Create(implementation) };
        }

        public static ContactListener CreateFast(IFastContactListenerImplementation implementation)
        {
            return new ContactListener { Handle = Bindings.JPH_ContactListenerFast_Create(implementation) };
        }

        public void SetBodyCallbackFlags(BodyID bodyID, ContactCallbackFlags flags)
        {
            Bindings.JPH_ContactListenerFast_SetBodyCallbackFlags(Handle, bodyID, flags);
        }

        public void Destroy()
        {
            Bindings.JPH_ContactListener_Destroy(Handle);
        }
    }
}


