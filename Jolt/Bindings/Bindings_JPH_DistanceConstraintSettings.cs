namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_DistanceConstraintSettings_Init(out DistanceConstraintSettings settings)
        {
            fixed (DistanceConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_DistanceConstraintSettings_Init(settingsPtr);
            }
        }
    }
}
