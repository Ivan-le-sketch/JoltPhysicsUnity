using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SkeletonMapper> JPH_SkeletonMapper_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_SkeletonMapper_Create());
        }

        public static void JPH_SkeletonMapper_Destroy(NativeHandle<JPH_SkeletonMapper> mapper)
        {
            if (mapper.HasUser()) return;
            UnsafeBindings.JPH_SkeletonMapper_Destroy(mapper);
            mapper.Dispose();
        }

        public static void JPH_SkeletonMapper_Initialize(
            NativeHandle<JPH_SkeletonMapper> mapper,
            NativeHandle<JPH_Skeleton> skeleton1,
            NativeArray<float4x4> neutralPose1,
            NativeHandle<JPH_Skeleton> skeleton2,
            NativeArray<float4x4> neutralPose2)
        {
            RequireLength(neutralPose1.Length, UnsafeBindings.JPH_Skeleton_GetJointCount(skeleton1), nameof(neutralPose1));
            RequireLength(neutralPose2.Length, UnsafeBindings.JPH_Skeleton_GetJointCount(skeleton2), nameof(neutralPose2));
            UnsafeBindings.JPH_SkeletonMapper_Initialize(
                mapper, skeleton1, (float4x4*)neutralPose1.GetUnsafePtr(),
                skeleton2, (float4x4*)neutralPose2.GetUnsafePtr());
        }

        public static void JPH_SkeletonMapper_LockAllTranslations(
            NativeHandle<JPH_SkeletonMapper> mapper,
            NativeHandle<JPH_Skeleton> skeleton,
            NativeArray<float4x4> neutralPose)
        {
            RequireLength(neutralPose.Length, UnsafeBindings.JPH_Skeleton_GetJointCount(skeleton), nameof(neutralPose));
            UnsafeBindings.JPH_SkeletonMapper_LockAllTranslations(mapper, skeleton, (float4x4*)neutralPose.GetUnsafePtr());
        }

        public static void JPH_SkeletonMapper_LockTranslations(
            NativeHandle<JPH_SkeletonMapper> mapper,
            NativeHandle<JPH_Skeleton> skeleton,
            NativeArray<NativeBool> lockedTranslations,
            NativeArray<float4x4> neutralPose)
        {
            var count = UnsafeBindings.JPH_Skeleton_GetJointCount(skeleton);
            RequireLength(lockedTranslations.Length, count, nameof(lockedTranslations));
            RequireLength(neutralPose.Length, count, nameof(neutralPose));
            UnsafeBindings.JPH_SkeletonMapper_LockTranslations(
                mapper, skeleton,
                (NativeBool*)lockedTranslations.GetUnsafePtr(),
                (float4x4*)neutralPose.GetUnsafePtr());
        }

        public static void JPH_SkeletonMapper_Map(
            NativeHandle<JPH_SkeletonMapper> mapper,
            NativeArray<float4x4> pose1ModelSpace,
            NativeArray<float4x4> pose2LocalSpace,
            NativeArray<float4x4> outPose2ModelSpace)
        {
            RequireLength(outPose2ModelSpace.Length, pose2LocalSpace.Length, nameof(outPose2ModelSpace));
            UnsafeBindings.JPH_SkeletonMapper_Map(
                mapper,
                (float4x4*)pose1ModelSpace.GetUnsafePtr(),
                (float4x4*)pose2LocalSpace.GetUnsafePtr(),
                (float4x4*)outPose2ModelSpace.GetUnsafePtr());
        }

        public static void JPH_SkeletonMapper_MapReverse(
            NativeHandle<JPH_SkeletonMapper> mapper,
            NativeArray<float4x4> pose2ModelSpace,
            NativeArray<float4x4> outPose1ModelSpace)
        {
            UnsafeBindings.JPH_SkeletonMapper_MapReverse(
                mapper,
                (float4x4*)pose2ModelSpace.GetUnsafePtr(),
                (float4x4*)outPose1ModelSpace.GetUnsafePtr());
        }

        public static int JPH_SkeletonMapper_GetMappedJointIndex(NativeHandle<JPH_SkeletonMapper> mapper, int joint1Index) => UnsafeBindings.JPH_SkeletonMapper_GetMappedJointIndex(mapper, joint1Index);
        public static bool JPH_SkeletonMapper_IsJointTranslationLocked(NativeHandle<JPH_SkeletonMapper> mapper, int joint2Index) => UnsafeBindings.JPH_SkeletonMapper_IsJointTranslationLocked(mapper, joint2Index);

        private static void RequireLength(int actual, int required, string parameterName)
        {
            if (actual < required)
                throw new ArgumentException($"Expected at least {required} elements.", parameterName);
        }
    }
}
