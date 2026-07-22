using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_Skeleton> JPH_Skeleton_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_Skeleton_Create());
        }

        public static void JPH_Skeleton_Destroy(NativeHandle<JPH_Skeleton> skeleton)
        {
            if (!skeleton.OwnsNativeResource || skeleton.HasUser()) return;
            UnsafeBindings.JPH_Skeleton_Destroy(skeleton);
            skeleton.Dispose();
        }

        public static uint JPH_Skeleton_AddJoint(NativeHandle<JPH_Skeleton> skeleton, string name)
        {
            var bytes = NullTerminatedUtf8(name);
            fixed (byte* namePtr = bytes)
                return UnsafeBindings.JPH_Skeleton_AddJoint(skeleton, (sbyte*)namePtr);
        }

        public static uint JPH_Skeleton_AddJoint(NativeHandle<JPH_Skeleton> skeleton, string name, int parentIndex)
        {
            var bytes = NullTerminatedUtf8(name);
            fixed (byte* namePtr = bytes)
                return UnsafeBindings.JPH_Skeleton_AddJoint2(skeleton, (sbyte*)namePtr, parentIndex);
        }

        public static uint JPH_Skeleton_AddJoint(NativeHandle<JPH_Skeleton> skeleton, string name, string parentName)
        {
            var nameBytes = NullTerminatedUtf8(name);
            var parentBytes = NullTerminatedUtf8(parentName);
            fixed (byte* namePtr = nameBytes)
            fixed (byte* parentPtr = parentBytes)
                return UnsafeBindings.JPH_Skeleton_AddJoint3(skeleton, (sbyte*)namePtr, (sbyte*)parentPtr);
        }

        public static int JPH_Skeleton_GetJointCount(NativeHandle<JPH_Skeleton> skeleton)
        {
            return UnsafeBindings.JPH_Skeleton_GetJointCount(skeleton);
        }

        public static SkeletonJoint JPH_Skeleton_GetJoint(NativeHandle<JPH_Skeleton> skeleton, int index)
        {
            if (index < 0 || index >= UnsafeBindings.JPH_Skeleton_GetJointCount(skeleton))
                throw new ArgumentOutOfRangeException(nameof(index));

            JPH_SkeletonJoint joint;
            UnsafeBindings.JPH_Skeleton_GetJoint(skeleton, index, &joint);
            return new SkeletonJoint(
                Marshal.PtrToStringUTF8((IntPtr)joint.name),
                Marshal.PtrToStringUTF8((IntPtr)joint.parentName),
                joint.parentJointIndex);
        }

        public static int JPH_Skeleton_GetJointIndex(NativeHandle<JPH_Skeleton> skeleton, string name)
        {
            var bytes = NullTerminatedUtf8(name);
            fixed (byte* namePtr = bytes)
                return UnsafeBindings.JPH_Skeleton_GetJointIndex(skeleton, (sbyte*)namePtr);
        }

        public static void JPH_Skeleton_CalculateParentJointIndices(NativeHandle<JPH_Skeleton> skeleton)
        {
            UnsafeBindings.JPH_Skeleton_CalculateParentJointIndices(skeleton);
        }

        public static bool JPH_Skeleton_AreJointsCorrectlyOrdered(NativeHandle<JPH_Skeleton> skeleton)
        {
            return UnsafeBindings.JPH_Skeleton_AreJointsCorrectlyOrdered(skeleton);
        }

        private static byte[] NullTerminatedUtf8(string value)
        {
            return Encoding.UTF8.GetBytes((value ?? string.Empty) + '\0');
        }
    }
}
