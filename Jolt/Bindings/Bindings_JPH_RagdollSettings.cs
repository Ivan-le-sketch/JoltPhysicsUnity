using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_RagdollSettings> JPH_RagdollSettings_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_RagdollSettings_Create());
        }

        public static void JPH_RagdollSettings_Destroy(NativeHandle<JPH_RagdollSettings> settings)
        {
            if (!settings.OwnsNativeResource || settings.HasUser()) return;
            UnsafeBindings.JPH_RagdollSettings_Destroy(settings);
            settings.Dispose();
        }

        public static NativeHandle<JPH_Skeleton> JPH_RagdollSettings_GetSkeleton(NativeHandle<JPH_RagdollSettings> settings)
        {
            return CreateOwnedHandle(settings, UnsafeBindings.JPH_RagdollSettings_GetSkeleton(settings));
        }

        public static void JPH_RagdollSettings_SetSkeleton(NativeHandle<JPH_RagdollSettings> settings, NativeHandle<JPH_Skeleton> skeleton) => UnsafeBindings.JPH_RagdollSettings_SetSkeleton(settings, skeleton);
        public static bool JPH_RagdollSettings_Stabilize(NativeHandle<JPH_RagdollSettings> settings) => UnsafeBindings.JPH_RagdollSettings_Stabilize(settings);
        public static void JPH_RagdollSettings_CalculateConstraintPriorities(NativeHandle<JPH_RagdollSettings> settings, uint basePriority = 0) => UnsafeBindings.JPH_RagdollSettings_CalculateConstraintPriorities(settings, basePriority);

        public static void JPH_RagdollSettings_DisableParentChildCollisions(NativeHandle<JPH_RagdollSettings> settings, float minSeparationDistance = 0.0f)
        {
            UnsafeBindings.JPH_RagdollSettings_DisableParentChildCollisions(settings, null, minSeparationDistance);
        }

        public static void JPH_RagdollSettings_DisableParentChildCollisions(NativeHandle<JPH_RagdollSettings> settings, NativeArray<float4x4> jointMatrices, float minSeparationDistance = 0.0f)
        {
            if (jointMatrices.Length < UnsafeBindings.JPH_RagdollSettings_GetPartCount(settings))
                throw new System.ArgumentException("The pose must contain one matrix per ragdoll part.", nameof(jointMatrices));
            UnsafeBindings.JPH_RagdollSettings_DisableParentChildCollisions(settings, (float4x4*)jointMatrices.GetUnsafePtr(), minSeparationDistance);
        }

        public static void JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(NativeHandle<JPH_RagdollSettings> settings) => UnsafeBindings.JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(settings);
        public static int JPH_RagdollSettings_GetConstraintIndexForBodyIndex(NativeHandle<JPH_RagdollSettings> settings, int bodyIndex) => UnsafeBindings.JPH_RagdollSettings_GetConstraintIndexForBodyIndex(settings, bodyIndex);
        public static void JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(NativeHandle<JPH_RagdollSettings> settings) => UnsafeBindings.JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(settings);

        public static bool JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(NativeHandle<JPH_RagdollSettings> settings, int constraintIndex, out int bodyIndex1, out int bodyIndex2)
        {
            bodyIndex1 = -1;
            bodyIndex2 = -1;
            fixed (int* bodyIndex1Ptr = &bodyIndex1)
            fixed (int* bodyIndex2Ptr = &bodyIndex2)
                return UnsafeBindings.JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(settings, constraintIndex, bodyIndex1Ptr, bodyIndex2Ptr);
        }

        public static void JPH_RagdollSettings_ResizeParts(NativeHandle<JPH_RagdollSettings> settings, int count) => UnsafeBindings.JPH_RagdollSettings_ResizeParts(settings, count);
        public static int JPH_RagdollSettings_GetPartCount(NativeHandle<JPH_RagdollSettings> settings) => UnsafeBindings.JPH_RagdollSettings_GetPartCount(settings);

        public static NativeHandle<JPH_BodyCreationSettings> JPH_RagdollSettings_GetPart(NativeHandle<JPH_RagdollSettings> settings, int partIndex)
        {
            return CreateOwnedHandle(settings, UnsafeBindings.JPH_RagdollSettings_GetPart(settings, partIndex));
        }

        public static void JPH_RagdollSettings_SetPartShape(NativeHandle<JPH_RagdollSettings> settings, int partIndex, NativeHandle<JPH_Shape> shape) => UnsafeBindings.JPH_RagdollSettings_SetPartShape(settings, partIndex, shape);
        public static void JPH_RagdollSettings_SetPartPosition(NativeHandle<JPH_RagdollSettings> settings, int partIndex, rvec3 position) => UnsafeBindings.JPH_RagdollSettings_SetPartPosition(settings, partIndex, &position);
        public static void JPH_RagdollSettings_SetPartRotation(NativeHandle<JPH_RagdollSettings> settings, int partIndex, quaternion rotation) => UnsafeBindings.JPH_RagdollSettings_SetPartRotation(settings, partIndex, &rotation);
        public static void JPH_RagdollSettings_SetPartMotionType(NativeHandle<JPH_RagdollSettings> settings, int partIndex, MotionType motionType) => UnsafeBindings.JPH_RagdollSettings_SetPartMotionType(settings, partIndex, motionType);
        public static void JPH_RagdollSettings_SetPartObjectLayer(NativeHandle<JPH_RagdollSettings> settings, int partIndex, ObjectLayer layer) => UnsafeBindings.JPH_RagdollSettings_SetPartObjectLayer(settings, partIndex, layer);
        public static void JPH_RagdollSettings_SetPartMassProperties(NativeHandle<JPH_RagdollSettings> settings, int partIndex, float mass) => UnsafeBindings.JPH_RagdollSettings_SetPartMassProperties(settings, partIndex, mass);

        public static void JPH_RagdollSettings_SetPartToParent(NativeHandle<JPH_RagdollSettings> settings, int partIndex, SwingTwistConstraintSettings constraintSettings)
        {
            UnsafeBindings.JPH_RagdollSettings_SetPartToParent(settings, partIndex, &constraintSettings);
        }

        public static void JPH_RagdollSettings_ClearPartToParent(NativeHandle<JPH_RagdollSettings> settings, int partIndex)
        {
            UnsafeBindings.JPH_RagdollSettings_SetPartToParent(settings, partIndex, null);
        }

        public static bool JPH_RagdollSettings_AddAdditionalConstraint(NativeHandle<JPH_RagdollSettings> settings, int bodyIndex1, int bodyIndex2, SwingTwistConstraintSettings constraintSettings)
        {
            return UnsafeBindings.JPH_RagdollSettings_AddAdditionalConstraint(settings, bodyIndex1, bodyIndex2, &constraintSettings);
        }

        public static void JPH_RagdollSettings_ClearAdditionalConstraints(NativeHandle<JPH_RagdollSettings> settings) => UnsafeBindings.JPH_RagdollSettings_ClearAdditionalConstraints(settings);
        public static int JPH_RagdollSettings_GetAdditionalConstraintCount(NativeHandle<JPH_RagdollSettings> settings) => UnsafeBindings.JPH_RagdollSettings_GetAdditionalConstraintCount(settings);

        public static NativeHandle<JPH_Ragdoll> JPH_RagdollSettings_CreateRagdoll(NativeHandle<JPH_RagdollSettings> settings, NativeHandle<JPH_PhysicsSystem> system, uint collisionGroup = 0, ulong userData = 0)
        {
            return CreateHandle(UnsafeBindings.JPH_RagdollSettings_CreateRagdoll(settings, system, collisionGroup, userData));
        }
    }
}
