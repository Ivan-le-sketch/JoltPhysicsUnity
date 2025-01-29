namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_ConeConstraintSettings_Init(out ConeConstraintSettings settings)
        {
            fixed (ConeConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_ConeConstraintSettings_Init(settingsPtr);
            }
        }
    }
}