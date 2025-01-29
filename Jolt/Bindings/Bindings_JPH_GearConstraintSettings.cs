namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_GearConstraintSettings_Init(out GearConstraintSettings settings)
        {
            fixed (GearConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_GearConstraintSettings_Init(settingsPtr);
            }
        }
    }
}