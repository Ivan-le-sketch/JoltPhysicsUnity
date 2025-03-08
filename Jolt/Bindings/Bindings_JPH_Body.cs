using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static BodyID JPH_Body_GetID(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetID(body);
        }

        public static BodyType JPH_Body_GetBodyType(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetBodyType(body);
        }

        public static bool JPH_Body_IsRigidBody(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsRigidBody(body);
        }

        public static bool JPH_Body_IsSoftBody(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsSoftBody(body);
        }

        public static bool JPH_Body_IsActive(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsActive(body);
        }

        public static bool JPH_Body_IsStatic(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsStatic(body);
        }

        public static bool JPH_Body_IsKinematic(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsKinematic(body);
        }

        public static bool JPH_Body_IsDynamic(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsDynamic(body);
        }

        public static bool JPH_Body_CanBeKinematicOrDynamic(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_CanBeKinematicOrDynamic(body);
        }

        public static void JPH_Body_SetIsSensor(NativeHandle<JPH_Body> body, bool value)
        {
            UnsafeBindings.JPH_Body_SetIsSensor(body, value);
        }

        public static bool JPH_Body_IsSensor(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsSensor(body);
        }

        public static void JPH_Body_SetCollideKinematicVsNonDynamic(NativeHandle<JPH_Body> body, bool value)
        {
            UnsafeBindings.JPH_Body_SetCollideKinematicVsNonDynamic(body, value);
        }

        public static bool JPH_Body_GetCollideKinematicVsNonDynamic(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetCollideKinematicVsNonDynamic(body);
        }

        public static void JPH_Body_SetUseManifoldReduction(NativeHandle<JPH_Body> body, bool value)
        {
            UnsafeBindings.JPH_Body_SetUseManifoldReduction(body, value);
        }

        public static bool JPH_Body_GetUseManifoldReduction(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetUseManifoldReduction(body);
        }

        public static bool JPH_Body_GetUseManifoldReductionWithBody(NativeHandle<JPH_Body> body, NativeHandle<JPH_Body> other)
        {
            return UnsafeBindings.JPH_Body_GetUseManifoldReductionWithBody(body, other);
        }

        public static void JPH_Body_SetApplyGyroscopicForce(NativeHandle<JPH_Body> body, bool value)
        {
            UnsafeBindings.JPH_Body_SetApplyGyroscopicForce(body, value);
        }

        public static bool JPH_Body_GetApplyGyroscopicForce(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetApplyGyroscopicForce(body);
        }

        public static void JPH_Body_SetEnhancedInternalEdgeRemoval(NativeHandle<JPH_Body> body, bool value)
        {
            UnsafeBindings.JPH_Body_SetEnhancedInternalEdgeRemoval(body, value);
        }

        public static bool JPH_Body_GetEnhancedInternalEdgeRemoval(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetEnhancedInternalEdgeRemoval(body);
        }

        public static bool JPH_Body_GetEnhancedInternalEdgeRemovalWithBody(NativeHandle<JPH_Body> body, NativeHandle<JPH_Body> otherBody)
        {
            return UnsafeBindings.JPH_Body_GetEnhancedInternalEdgeRemovalWithBody(body, otherBody);
        }

        public static MotionType JPH_Body_GetMotionType(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetMotionType(body);
        }

        public static void JPH_Body_SetMotionType(NativeHandle<JPH_Body> body, MotionType motion)
        {
            UnsafeBindings.JPH_Body_SetMotionType(body, motion);
        }

        public static BroadPhaseLayer JPH_Body_GetBroadPhaseLayer(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetBroadPhaseLayer(body);
        }

        public static ObjectLayer JPH_Body_GetObjectLayer(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetObjectLayer(body);
        }

        public static bool JPH_Body_GetAllowSleeping(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetAllowSleeping(body);
        }

        public static void JPH_Body_SetAllowSleeping(NativeHandle<JPH_Body> body, bool allowSleeping)
        {
            UnsafeBindings.JPH_Body_SetAllowSleeping(body, allowSleeping);
        }

        public static void JPH_Body_ResetSleepTimer(NativeHandle<JPH_Body> body)
        {
            UnsafeBindings.JPH_Body_ResetSleepTimer(body);
        }

        public static float JPH_Body_GetFriction(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetFriction(body);
        }

        public static void JPH_Body_SetFriction(NativeHandle<JPH_Body> body, float friction)
        {
            UnsafeBindings.JPH_Body_SetFriction(body, friction);
        }

        public static float JPH_Body_GetRestitution(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetRestitution(body);
        }

        public static void JPH_Body_SetRestitution(NativeHandle<JPH_Body> body, float restitution)
        {
            UnsafeBindings.JPH_Body_SetRestitution(body, restitution);
        }

        public static float3 JPH_Body_GetLinearVelocity(NativeHandle<JPH_Body> body)
        {
            float3 result;
            UnsafeBindings.JPH_Body_GetLinearVelocity(body, &result);
            return result;
        }

        public static void JPH_Body_SetLinearVelocity(NativeHandle<JPH_Body> body, float3 velocity)
        {
            UnsafeBindings.JPH_Body_SetLinearVelocity(body, &velocity);
        }

        public static void JPH_Body_SetLinearVelocityClamped(NativeHandle<JPH_Body> body, float3 velocity)
        {
            UnsafeBindings.JPH_Body_SetLinearVelocityClamped(body, &velocity);
        }

        public static float3 JPH_Body_GetAngularVelocity(NativeHandle<JPH_Body> body)
        {
            float3 result;
            UnsafeBindings.JPH_Body_GetAngularVelocity(body, &result);
            return result;
        }

        public static void JPH_Body_SetAngularVelocity(NativeHandle<JPH_Body> body, float3 velocity)
        {
            UnsafeBindings.JPH_Body_SetAngularVelocity(body, &velocity);
        }

        public static void JPH_Body_SetAngularVelocityClamped(NativeHandle<JPH_Body> body, float3 velocity)
        {
            UnsafeBindings.JPH_Body_SetAngularVelocityClamped(body, &velocity);
        }

        public static float3 JPH_Body_GetPointVelocityCOM(NativeHandle<JPH_Body> body, float3 pointRelativeToCOM)
        {
            float3 velocity;
            UnsafeBindings.JPH_Body_GetPointVelocityCOM(body, &pointRelativeToCOM, &velocity);
            return velocity;
        }

        public static float3 JPH_Body_GetPointVelocity(NativeHandle<JPH_Body> body, rvec3 point)
        {
            float3 velocity;
            UnsafeBindings.JPH_Body_GetPointVelocity(body, &point, &velocity);
            return velocity;
        }

        public static void JPH_Body_AddForce(NativeHandle<JPH_Body> body, float3 force)
        {
            UnsafeBindings.JPH_Body_AddForce(body, &force);
        }

        public static void JPH_Body_AddForceAtPosition(NativeHandle<JPH_Body> body, float3 force, rvec3 position)
        {
            UnsafeBindings.JPH_Body_AddForceAtPosition(body, &force, &position);
        }

        public static void JPH_Body_AddTorque(NativeHandle<JPH_Body> body, float3 force)
        {
            UnsafeBindings.JPH_Body_AddTorque(body, &force);
        }

        public static float3 JPH_Body_GetAccumulatedForce(NativeHandle<JPH_Body> body)
        {
            float3 result;
            UnsafeBindings.JPH_Body_GetAccumulatedForce(body, &result);
            return result;
        }

        public static float3 JPH_Body_GetAccumulatedTorque(NativeHandle<JPH_Body> body)
        {
            float3 result;
            UnsafeBindings.JPH_Body_GetAccumulatedTorque(body, &result);
            return result;
        }

        public static void JPH_Body_ResetForce(NativeHandle<JPH_Body> body)
        {
            UnsafeBindings.JPH_Body_ResetForce(body);
        }

        public static void JPH_Body_ResetTorque(NativeHandle<JPH_Body> body)
        {
            UnsafeBindings.JPH_Body_ResetTorque(body);
        }

        public static void JPH_Body_ResetMotion(NativeHandle<JPH_Body> body)
        {
            UnsafeBindings.JPH_Body_ResetMotion(body);
        }

        public static float4x4 JPH_Body_GetInverseInertia(NativeHandle<JPH_Body> body)
        {
            float4x4 result;
            UnsafeBindings.JPH_Body_GetInverseInertia(body, &result);
            return result;
        }

        public static void JPH_Body_AddImpulse(NativeHandle<JPH_Body> body, float3 impulse)
        {
            UnsafeBindings.JPH_Body_AddImpulse(body, &impulse);
        }

        public static void JPH_Body_AddImpulseAtPosition(NativeHandle<JPH_Body> body, float3 impulse, rvec3 position)
        {
            UnsafeBindings.JPH_Body_AddImpulseAtPosition(body, &impulse, &position);
        }

        public static void JPH_Body_AddAngularImpulse(NativeHandle<JPH_Body> body, float3 angularImpulse)
        {
            UnsafeBindings.JPH_Body_AddAngularImpulse(body, &angularImpulse);
        }

        public static void JPH_Body_MoveKinematic(NativeHandle<JPH_Body> body, rvec3 targetPosition, quaternion targetRotation, float deltaTime)
        {
            UnsafeBindings.JPH_Body_MoveKinematic(body, &targetPosition, &targetRotation, deltaTime);
        }

        public static void JPH_Body_ApplyBuoyancyImpulse(NativeHandle<JPH_Body> body, rvec3 surfacePosition, float3 surfaceNormal, float buoyancy, float linearDrag, float angularDrag, float3 fluidVelocity, float3 gravity, float deltaTime)
        {
            UnsafeBindings.JPH_Body_ApplyBuoyancyImpulse(body, &surfacePosition, &surfaceNormal, buoyancy, linearDrag, angularDrag, &fluidVelocity, &gravity, deltaTime);
        }

        public static bool JPH_Body_IsInBroadPhase(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsInBroadPhase(body);
        }

        public static bool JPH_Body_IsCollisionCacheInvalid(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_IsCollisionCacheInvalid(body);
        }

        public static NativeHandle<JPH_Shape> JPH_Body_GetShape(NativeHandle<JPH_Body> body)
        {
            return CreateHandle(UnsafeBindings.JPH_Body_GetShape(body));
        }

        public static rvec3 JPH_Body_GetPosition(NativeHandle<JPH_Body> body)
        {
            rvec3 result;
            UnsafeBindings.JPH_Body_GetPosition(body, &result);
            return result;
        }

        public static quaternion JPH_Body_GetRotation(NativeHandle<JPH_Body> body)
        {
            quaternion result;
            UnsafeBindings.JPH_Body_GetRotation(body, &result);
            return result;
        }

        public static rmatrix4x4 JPH_Body_GetWorldTransform(NativeHandle<JPH_Body> body)
        {
            rmatrix4x4 result;
            UnsafeBindings.JPH_Body_GetWorldTransform(body, &result);
            return result;
        }

        public static rvec3 JPH_Body_GetCenterOfMassPosition(NativeHandle<JPH_Body> body)
        {
            rvec3 result;
            UnsafeBindings.JPH_Body_GetCenterOfMassPosition(body, &result);
            return result;
        }

        public static rmatrix4x4 JPH_Body_GetCenterOfMassTransform(NativeHandle<JPH_Body> body)
        {
            rmatrix4x4 result;
            UnsafeBindings.JPH_Body_GetCenterOfMassTransform(body, &result);
            return result;
        }

        public static AABox JPH_Body_GetWorldSpaceBounds(NativeHandle<JPH_Body> body)
        {
            AABox result;
            UnsafeBindings.JPH_Body_GetWorldSpaceBounds(body, &result);
            return result;
        }

        public static float3 JPH_Body_GetWorldSpaceSurfaceNormal(NativeHandle<JPH_Body> body, SubShapeID subShapeID, rvec3 position)
        {
            float3 result;
            UnsafeBindings.JPH_Body_GetWorldSpaceSurfaceNormal(body, subShapeID, &position, &result);
            return result;
        }

        public static NativeHandle<JPH_MotionProperties> JPH_Body_GetMotionProperties(NativeHandle<JPH_Body> body)
        {
            return CreateOwnedHandle(body, UnsafeBindings.JPH_Body_GetMotionProperties(body));
        }

        public static NativeHandle<JPH_MotionProperties> JPH_Body_GetMotionPropertiesUnchecked(NativeHandle<JPH_Body> body)
        {
            return CreateOwnedHandle(body, UnsafeBindings.JPH_Body_GetMotionPropertiesUnchecked(body));
        }

        public static void JPH_Body_SetUserData(NativeHandle<JPH_Body> body, ulong userData)
        {
            UnsafeBindings.JPH_Body_SetUserData(body, userData);
        }

        public static ulong JPH_Body_GetUserData(NativeHandle<JPH_Body> body)
        {
            return UnsafeBindings.JPH_Body_GetUserData(body);
        }

        public static NativeHandle<JPH_Body> JPH_Body_GetFixedToWorldBody()
        {
            return CreateHandle(UnsafeBindings.JPH_Body_GetFixedToWorldBody()); // TODO use single static safety handle?
        }
    }
}
