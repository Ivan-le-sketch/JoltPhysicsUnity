namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_PointConstraintSettings_Init(out PointConstraintSettings settings)
        {
            fixed (PointConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_PointConstraintSettings_Init(settingsPtr);
            }
        }
    }
}