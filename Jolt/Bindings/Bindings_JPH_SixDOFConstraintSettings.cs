namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_SixDOFConstraintSettings_Init(out SixDOFConstraintSettings settings)
        {
            fixed (SixDOFConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_SixDOFConstraintSettings_Init(settingsPtr);
            }
        }
    }
}