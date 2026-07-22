using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_Ragdoll_Destroy(NativeHandle<JPH_Ragdoll> ragdoll)
        {
            if (ragdoll.HasUser()) return;
            UnsafeBindings.JPH_Ragdoll_Destroy(ragdoll);
            ragdoll.Dispose();
        }

        public static void JPH_Ragdoll_AddToPhysicsSystem(NativeHandle<JPH_Ragdoll> ragdoll, Activation activationMode = Activation.Activate, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_AddToPhysicsSystem(ragdoll, activationMode, lockBodies);
        public static void JPH_Ragdoll_RemoveFromPhysicsSystem(NativeHandle<JPH_Ragdoll> ragdoll, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_RemoveFromPhysicsSystem(ragdoll, lockBodies);
        public static void JPH_Ragdoll_Activate(NativeHandle<JPH_Ragdoll> ragdoll, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_Activate(ragdoll, lockBodies);
        public static bool JPH_Ragdoll_IsActive(NativeHandle<JPH_Ragdoll> ragdoll, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_IsActive(ragdoll, lockBodies);
        public static void JPH_Ragdoll_SetGroupID(NativeHandle<JPH_Ragdoll> ragdoll, uint groupID, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_SetGroupID(ragdoll, groupID, lockBodies);
        public static void JPH_Ragdoll_ResetWarmStart(NativeHandle<JPH_Ragdoll> ragdoll) => UnsafeBindings.JPH_Ragdoll_ResetWarmStart(ragdoll);

        public static void JPH_Ragdoll_SetPose(NativeHandle<JPH_Ragdoll> ragdoll, NativeHandle<JPH_SkeletonPose> pose, bool lockBodies = true)
        {
            UnsafeBindings.JPH_Ragdoll_SetPose(ragdoll, pose, lockBodies);
        }

        public static void JPH_Ragdoll_SetPose(NativeHandle<JPH_Ragdoll> ragdoll, rvec3 rootOffset, NativeArray<float4x4> jointMatrices, bool lockBodies = true)
        {
            RequireRagdollPoseLength(ragdoll, jointMatrices);
            UnsafeBindings.JPH_Ragdoll_SetPose2(ragdoll, &rootOffset, (float4x4*)jointMatrices.GetUnsafePtr(), lockBodies);
        }

        public static void JPH_Ragdoll_GetPose(NativeHandle<JPH_Ragdoll> ragdoll, NativeHandle<JPH_SkeletonPose> pose, bool lockBodies = true)
        {
            UnsafeBindings.JPH_Ragdoll_GetPose(ragdoll, pose, lockBodies);
        }

        public static void JPH_Ragdoll_GetPose(NativeHandle<JPH_Ragdoll> ragdoll, out rvec3 rootOffset, NativeArray<float4x4> jointMatrices, bool lockBodies = true)
        {
            RequireRagdollPoseLength(ragdoll, jointMatrices);
            rootOffset = default;
            fixed (rvec3* rootOffsetPtr = &rootOffset)
                UnsafeBindings.JPH_Ragdoll_GetPose2(ragdoll, rootOffsetPtr, (float4x4*)jointMatrices.GetUnsafePtr(), lockBodies);
        }

        public static void JPH_Ragdoll_DriveToPoseUsingKinematics(NativeHandle<JPH_Ragdoll> ragdoll, NativeHandle<JPH_SkeletonPose> pose, float deltaTime, bool lockBodies = true)
        {
            UnsafeBindings.JPH_Ragdoll_DriveToPoseUsingKinematics(ragdoll, pose, deltaTime, lockBodies);
        }

        public static void JPH_Ragdoll_DriveToPoseUsingKinematics(NativeHandle<JPH_Ragdoll> ragdoll, rvec3 rootOffset, NativeArray<float4x4> jointMatrices, float deltaTime, bool lockBodies = true)
        {
            RequireRagdollPoseLength(ragdoll, jointMatrices);
            UnsafeBindings.JPH_Ragdoll_DriveToPoseUsingKinematics2(ragdoll, &rootOffset, (float4x4*)jointMatrices.GetUnsafePtr(), deltaTime, lockBodies);
        }

        public static void JPH_Ragdoll_DriveToPoseUsingMotors(NativeHandle<JPH_Ragdoll> ragdoll, NativeHandle<JPH_SkeletonPose> pose) => UnsafeBindings.JPH_Ragdoll_DriveToPoseUsingMotors(ragdoll, pose);

        public static void JPH_Ragdoll_DriveToPoseUsingMotors(NativeHandle<JPH_Ragdoll> ragdoll, NativeHandle<JPH_SkeletonPose> previousPose, NativeHandle<JPH_SkeletonPose> pose, float deltaTime)
        {
            UnsafeBindings.JPH_Ragdoll_DriveToPoseUsingMotors2(ragdoll, previousPose, pose, deltaTime);
        }

        public static void JPH_Ragdoll_SetLinearAndAngularVelocity(NativeHandle<JPH_Ragdoll> ragdoll, float3 linearVelocity, float3 angularVelocity, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_SetLinearAndAngularVelocity(ragdoll, &linearVelocity, &angularVelocity, lockBodies);
        public static void JPH_Ragdoll_SetLinearVelocity(NativeHandle<JPH_Ragdoll> ragdoll, float3 linearVelocity, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_SetLinearVelocity(ragdoll, &linearVelocity, lockBodies);
        public static void JPH_Ragdoll_AddLinearVelocity(NativeHandle<JPH_Ragdoll> ragdoll, float3 linearVelocity, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_AddLinearVelocity(ragdoll, &linearVelocity, lockBodies);
        public static void JPH_Ragdoll_AddImpulse(NativeHandle<JPH_Ragdoll> ragdoll, float3 impulse, bool lockBodies = true) => UnsafeBindings.JPH_Ragdoll_AddImpulse(ragdoll, &impulse, lockBodies);
        public static int JPH_Ragdoll_GetBodyCount(NativeHandle<JPH_Ragdoll> ragdoll) => UnsafeBindings.JPH_Ragdoll_GetBodyCount(ragdoll);
        public static BodyID JPH_Ragdoll_GetBodyID(NativeHandle<JPH_Ragdoll> ragdoll, int bodyIndex) => UnsafeBindings.JPH_Ragdoll_GetBodyID(ragdoll, bodyIndex);
        public static int JPH_Ragdoll_GetConstraintCount(NativeHandle<JPH_Ragdoll> ragdoll) => UnsafeBindings.JPH_Ragdoll_GetConstraintCount(ragdoll);

        public static NativeHandle<JPH_Constraint> JPH_Ragdoll_GetConstraint(NativeHandle<JPH_Ragdoll> ragdoll, int constraintIndex)
        {
            var constraint = UnsafeBindings.JPH_Ragdoll_GetConstraint(ragdoll, constraintIndex);
            return CreateOwnedHandle(ragdoll, (JPH_Constraint*)constraint);
        }

        public static void JPH_Ragdoll_GetRootTransform(NativeHandle<JPH_Ragdoll> ragdoll, out rvec3 position, out quaternion rotation, bool lockBodies = true)
        {
            position = default;
            rotation = default;
            fixed (rvec3* positionPtr = &position)
            fixed (quaternion* rotationPtr = &rotation)
                UnsafeBindings.JPH_Ragdoll_GetRootTransform(ragdoll, positionPtr, rotationPtr, lockBodies);
        }

        public static AABox JPH_Ragdoll_GetWorldSpaceBounds(NativeHandle<JPH_Ragdoll> ragdoll, bool lockBodies = true)
        {
            AABox result = default;
            UnsafeBindings.JPH_Ragdoll_GetWorldSpaceBounds(ragdoll, &result, lockBodies);
            return result;
        }

        public static NativeHandle<JPH_RagdollSettings> JPH_Ragdoll_GetRagdollSettings(NativeHandle<JPH_Ragdoll> ragdoll)
        {
            return CreateOwnedHandle(ragdoll, UnsafeBindings.JPH_Ragdoll_GetRagdollSettings(ragdoll));
        }

        private static void RequireRagdollPoseLength(NativeHandle<JPH_Ragdoll> ragdoll, NativeArray<float4x4> jointMatrices)
        {
            var required = UnsafeBindings.JPH_Ragdoll_GetBodyCount(ragdoll);
            if (jointMatrices.Length < required)
                throw new ArgumentException($"The pose must contain at least {required} matrices.", nameof(jointMatrices));
        }
    }
}
