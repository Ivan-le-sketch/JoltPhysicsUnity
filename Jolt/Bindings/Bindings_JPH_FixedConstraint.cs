using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_FixedConstraint> JPH_FixedConstraint_Create(FixedConstraintSettings settings, NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2)
        {
            return CreateHandle(UnsafeBindings.JPH_FixedConstraint_Create(&settings, body1, body2));
        }

        public static FixedConstraintSettings JPH_FixedConstraint_GetSettings(NativeHandle<JPH_FixedConstraint> constraint)
        {
            var settings = new FixedConstraintSettings();
            UnsafeBindings.JPH_FixedConstraint_GetSettings(constraint, &settings);

            return settings;
        }

        public static float3 JPH_FixedConstraint_GetTotalLambdaPosition(NativeHandle<JPH_FixedConstraint> constraint)
        {
            float3 result;
            UnsafeBindings.JPH_FixedConstraint_GetTotalLambdaPosition(constraint, &result);
            return result;
        }

        public static float3 JPH_FixedConstraint_GetTotalLambdaRotation(NativeHandle<JPH_FixedConstraint> constraint)
        {
            float3 result;
            UnsafeBindings.JPH_FixedConstraint_GetTotalLambdaPosition(constraint, &result);
            return result;
        }
    }
}
