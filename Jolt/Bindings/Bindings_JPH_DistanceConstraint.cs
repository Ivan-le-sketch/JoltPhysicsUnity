﻿namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_DistanceConstraint> JPH_DistanceConstraint_Create(DistanceConstraintSettings settings, NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2)
        {
            return CreateHandle(UnsafeBindings.JPH_DistanceConstraint_Create(&settings, body1, body2));
        }

        public static DistanceConstraintSettings JPH_DistanceConstraint_GetSettings(NativeHandle<JPH_DistanceConstraint> constraint)
        {
            var settings = new DistanceConstraintSettings();
            UnsafeBindings.JPH_DistanceConstraint_GetSettings(constraint, &settings);

            return settings;
        }

        public static void JPH_DistanceConstraint_SetDistance(NativeHandle<JPH_DistanceConstraint> constraint, float minDistance, float maxDistance)
        {
            UnsafeBindings.JPH_DistanceConstraint_SetDistance(constraint, minDistance, maxDistance);
        }

        public static float JPH_DistanceConstraint_GetMinDistance(NativeHandle<JPH_DistanceConstraint> constraint)
        {
            return UnsafeBindings.JPH_DistanceConstraint_GetMinDistance(constraint);
        }

        public static float JPH_DistanceConstraint_GetMaxDistance(NativeHandle<JPH_DistanceConstraint> constraint)
        {
            return UnsafeBindings.JPH_DistanceConstraint_GetMaxDistance(constraint);
        }

        public static SpringSettings JPH_DistanceConstraint_GetLimitsSpringSettings(NativeHandle<JPH_DistanceConstraint> constraint)
        {
            SpringSettings result;
            UnsafeBindings.JPH_DistanceConstraint_GetLimitsSpringSettings(constraint, &result);
            return result;
        }

        public static void JPH_DistanceConstraint_SetLimitsSpringSettings(NativeHandle<JPH_DistanceConstraint> constraint, SpringSettings settings)
        {
            UnsafeBindings.JPH_DistanceConstraint_SetLimitsSpringSettings(constraint, &settings);
        }

        public static float JPH_DistanceConstraint_GetTotalLambdaPosition(NativeHandle<JPH_DistanceConstraint> constraint)
        {
            return UnsafeBindings.JPH_DistanceConstraint_GetTotalLambdaPosition(constraint);
        }
    }
}
