using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SwingTwistConstraint> JPH_SwingTwistConstraint_Create(SwingTwistConstraintSettings settings, NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2)
        {
            return CreateHandle(UnsafeBindings.JPH_SwingTwistConstraint_Create(&settings, body1, body2));
        }

        public static SwingTwistConstraintSettings JPH_SwingTwistConstraint_GetSettings(NativeHandle<JPH_SwingTwistConstraint> constraint)
        {
            var settings = new SwingTwistConstraintSettings();
            UnsafeBindings.JPH_SwingTwistConstraint_GetSettings(constraint, &settings);

            return settings;
        }

        public static float JPH_SwingTwistConstraint_GetNormalHalfConeAngle(NativeHandle<JPH_SwingTwistConstraint> constraint)
        {
            return UnsafeBindings.JPH_SwingTwistConstraint_GetNormalHalfConeAngle(constraint);
        }

        public static float3 JPH_SwingTwistConstraint_GetTotalLambdaPosition(NativeHandle<JPH_SwingTwistConstraint> constraint)
        {
            float3 result;
            UnsafeBindings.JPH_SwingTwistConstraint_GetTotalLambdaPosition(constraint, &result);
            return result;
        }

        public static float JPH_SwingTwistConstraint_GetTotalLambdaTwist(NativeHandle<JPH_SwingTwistConstraint> constraint)
        {
            return UnsafeBindings.JPH_SwingTwistConstraint_GetTotalLambdaTwist(constraint);
        }

        public static float JPH_SwingTwistConstraint_GetTotalLambdaSwingY(NativeHandle<JPH_SwingTwistConstraint> constraint) 
        {
            return UnsafeBindings.JPH_SwingTwistConstraint_GetTotalLambdaSwingY(constraint);
        }

        public static float JPH_SwingTwistConstraint_GetTotalLambdaSwingZ(NativeHandle<JPH_SwingTwistConstraint> constraint) 
        {
            return UnsafeBindings.JPH_SwingTwistConstraint_GetTotalLambdaSwingZ(constraint);
        }

        public static float3 JPH_SwingTwistConstraint_GetTotalLambdaMotor(NativeHandle<JPH_SwingTwistConstraint> constraint) 
        {
            float3 result;
            UnsafeBindings.JPH_SwingTwistConstraint_GetTotalLambdaMotor(constraint, &result);
            return result;
        }
    }
}