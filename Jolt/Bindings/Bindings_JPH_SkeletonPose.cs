using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SkeletonPose> JPH_SkeletonPose_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_SkeletonPose_Create());
        }

        public static void JPH_SkeletonPose_Destroy(NativeHandle<JPH_SkeletonPose> pose)
        {
            if (pose.HasUser()) return;
            UnsafeBindings.JPH_SkeletonPose_Destroy(pose);
            pose.Dispose();
        }

        public static void JPH_SkeletonPose_SetSkeleton(NativeHandle<JPH_SkeletonPose> pose, NativeHandle<JPH_Skeleton> skeleton)
        {
            UnsafeBindings.JPH_SkeletonPose_SetSkeleton(pose, skeleton);
        }

        public static NativeHandle<JPH_Skeleton> JPH_SkeletonPose_GetSkeleton(NativeHandle<JPH_SkeletonPose> pose)
        {
            return CreateOwnedHandle(pose, UnsafeBindings.JPH_SkeletonPose_GetSkeleton(pose));
        }

        public static void JPH_SkeletonPose_SetRootOffset(NativeHandle<JPH_SkeletonPose> pose, rvec3 offset)
        {
            UnsafeBindings.JPH_SkeletonPose_SetRootOffset(pose, &offset);
        }

        public static rvec3 JPH_SkeletonPose_GetRootOffset(NativeHandle<JPH_SkeletonPose> pose)
        {
            rvec3 result;
            UnsafeBindings.JPH_SkeletonPose_GetRootOffset(pose, &result);
            return result;
        }

        public static int JPH_SkeletonPose_GetJointCount(NativeHandle<JPH_SkeletonPose> pose)
        {
            return UnsafeBindings.JPH_SkeletonPose_GetJointCount(pose);
        }

        public static void JPH_SkeletonPose_GetJointState(NativeHandle<JPH_SkeletonPose> pose, int index, out float3 translation, out quaternion rotation)
        {
            translation = default;
            rotation = default;
            fixed (float3* translationPtr = &translation)
            fixed (quaternion* rotationPtr = &rotation)
                UnsafeBindings.JPH_SkeletonPose_GetJointState(pose, index, translationPtr, rotationPtr);
        }

        public static void JPH_SkeletonPose_SetJointState(NativeHandle<JPH_SkeletonPose> pose, int index, float3 translation, quaternion rotation)
        {
            UnsafeBindings.JPH_SkeletonPose_SetJointState(pose, index, &translation, &rotation);
        }

        public static float4x4 JPH_SkeletonPose_GetJointMatrix(NativeHandle<JPH_SkeletonPose> pose, int index)
        {
            float4x4 result = default;
            UnsafeBindings.JPH_SkeletonPose_GetJointMatrix(pose, index, &result);
            return result;
        }

        public static void JPH_SkeletonPose_SetJointMatrix(NativeHandle<JPH_SkeletonPose> pose, int index, float4x4 matrix)
        {
            UnsafeBindings.JPH_SkeletonPose_SetJointMatrix(pose, index, &matrix);
        }

        public static int JPH_SkeletonPose_GetJointMatrices(NativeHandle<JPH_SkeletonPose> pose, NativeArray<float4x4> matrices)
        {
            return UnsafeBindings.JPH_SkeletonPose_GetJointMatrices(pose, (float4x4*)matrices.GetUnsafePtr(), matrices.Length);
        }

        public static int JPH_SkeletonPose_SetJointMatrices(NativeHandle<JPH_SkeletonPose> pose, NativeArray<float4x4> matrices)
        {
            return UnsafeBindings.JPH_SkeletonPose_SetJointMatrices(pose, (float4x4*)matrices.GetUnsafePtr(), matrices.Length);
        }

        public static void JPH_SkeletonPose_CalculateJointMatrices(NativeHandle<JPH_SkeletonPose> pose)
        {
            UnsafeBindings.JPH_SkeletonPose_CalculateJointMatrices(pose);
        }

        public static void JPH_SkeletonPose_CalculateJointStates(NativeHandle<JPH_SkeletonPose> pose)
        {
            UnsafeBindings.JPH_SkeletonPose_CalculateJointStates(pose);
        }

        public static int JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(NativeHandle<JPH_SkeletonPose> pose, NativeArray<float4x4> matrices)
        {
            return UnsafeBindings.JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(pose, (float4x4*)matrices.GetUnsafePtr(), matrices.Length);
        }
    }
}
