using System.Text;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SkeletalAnimation> JPH_SkeletalAnimation_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_SkeletalAnimation_Create());
        }

        public static void JPH_SkeletalAnimation_Destroy(NativeHandle<JPH_SkeletalAnimation> animation)
        {
            if (animation.HasUser()) return;
            UnsafeBindings.JPH_SkeletalAnimation_Destroy(animation);
            animation.Dispose();
        }

        public static float JPH_SkeletalAnimation_GetDuration(NativeHandle<JPH_SkeletalAnimation> animation) => UnsafeBindings.JPH_SkeletalAnimation_GetDuration(animation);
        public static bool JPH_SkeletalAnimation_IsLooping(NativeHandle<JPH_SkeletalAnimation> animation) => UnsafeBindings.JPH_SkeletalAnimation_IsLooping(animation);
        public static void JPH_SkeletalAnimation_SetIsLooping(NativeHandle<JPH_SkeletalAnimation> animation, bool looping) => UnsafeBindings.JPH_SkeletalAnimation_SetIsLooping(animation, looping);
        public static void JPH_SkeletalAnimation_ScaleJoints(NativeHandle<JPH_SkeletalAnimation> animation, float scale) => UnsafeBindings.JPH_SkeletalAnimation_ScaleJoints(animation, scale);
        public static void JPH_SkeletalAnimation_Sample(NativeHandle<JPH_SkeletalAnimation> animation, float time, NativeHandle<JPH_SkeletonPose> pose) => UnsafeBindings.JPH_SkeletalAnimation_Sample(animation, time, pose);
        public static int JPH_SkeletalAnimation_GetAnimatedJointCount(NativeHandle<JPH_SkeletalAnimation> animation) => UnsafeBindings.JPH_SkeletalAnimation_GetAnimatedJointCount(animation);

        public static int JPH_SkeletalAnimation_AddAnimatedJoint(NativeHandle<JPH_SkeletalAnimation> animation, string jointName)
        {
            var bytes = Encoding.UTF8.GetBytes((jointName ?? string.Empty) + '\0');
            fixed (byte* namePtr = bytes)
                return UnsafeBindings.JPH_SkeletalAnimation_AddAnimatedJoint(animation, (sbyte*)namePtr);
        }

        public static bool JPH_SkeletalAnimation_AddKeyframe(NativeHandle<JPH_SkeletalAnimation> animation, int jointIndex, float time, float3 translation, quaternion rotation)
        {
            return UnsafeBindings.JPH_SkeletalAnimation_AddKeyframe(animation, jointIndex, time, &translation, &rotation);
        }
    }
}
