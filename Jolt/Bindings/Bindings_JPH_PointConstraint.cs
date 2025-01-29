using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_PointConstraint> JPH_PointConstraint_Create(PointConstraintSettings settings, NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2)
        {
            return CreateHandle(UnsafeBindings.JPH_PointConstraint_Create(&settings, body1, body2));
        }

        public static PointConstraintSettings JPH_PointConstraint_GetSettings(NativeHandle<JPH_PointConstraint> constraint)
        {
            var settings = new PointConstraintSettings();
            UnsafeBindings.JPH_PointConstraint_GetSettings(constraint, &settings);

            return settings;
        }

        public static void JPH_PointConstraint_SetPoint1(NativeHandle<JPH_PointConstraint> constraint, ConstraintSpace space, rvec3 value)
        {
            UnsafeBindings.JPH_PointConstraint_SetPoint1(constraint, space, &value);
        }

        public static void JPH_PointConstraint_SetPoint2(NativeHandle<JPH_PointConstraint> constraint, ConstraintSpace space, rvec3 value)
        {
            UnsafeBindings.JPH_PointConstraint_SetPoint2(constraint, space, &value);
        }

        public static float3 JPH_PointConstraint_GetLocalSpacePoint1(NativeHandle<JPH_PointConstraint> constraint)
        {
            float3 result;
            UnsafeBindings.JPH_PointConstraint_GetLocalSpacePoint1(constraint, &result);

            return result;
        }

        public static float3 JPH_PointConstraint_GetLocalSpacePoint2(NativeHandle<JPH_PointConstraint> constraint)
        {
            float3 result;
            UnsafeBindings.JPH_PointConstraint_GetLocalSpacePoint2(constraint, &result);

            return result;
        }

        public static float3 JPH_PointConstraint_GetTotalLambdaPosition(NativeHandle<JPH_PointConstraint> constraint)
        {
            float3 result;
            UnsafeBindings.JPH_PointConstraint_GetTotalLambdaPosition(constraint, &result);
            return result;
        }
    }
}