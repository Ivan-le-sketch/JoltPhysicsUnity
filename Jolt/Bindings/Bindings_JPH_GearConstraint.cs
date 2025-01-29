namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_GearConstraint> JPH_GearConstraint_Create(GearConstraintSettings settings, NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2)
        {
            return CreateHandle(UnsafeBindings.JPH_GearConstraint_Create(&settings, body1, body2));
        }

        public static GearConstraintSettings JPH_GearConstraint_GetSettings(NativeHandle<JPH_GearConstraint> constraint)
        {
            var settings = new GearConstraintSettings();
            UnsafeBindings.JPH_GearConstraint_GetSettings(constraint, &settings);

            return settings;
        }

        public static void JPH_GearConstraint_SetConstraints(NativeHandle<JPH_GearConstraint> constraint, NativeHandle<JPH_Constraint> gear1, NativeHandle<JPH_Constraint> gear2)
        {
            UnsafeBindings.JPH_GearConstraint_SetConstraints(constraint, gear1, gear2);
        }

        public static float JPH_GearConstraint_GetTotalLambda(NativeHandle<JPH_GearConstraint> constraint)
        {
            return UnsafeBindings.JPH_GearConstraint_GetTotalLambda(constraint);
        }
    }
}

