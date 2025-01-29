namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_SwingTwistConstraintSettings_Init(out SwingTwistConstraintSettings settings)
        {
            fixed (SwingTwistConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_SwingTwistConstraintSettings_Init(settingsPtr);
            }
        }
    }
}