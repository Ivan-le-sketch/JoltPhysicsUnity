namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_SliderConstraintSettings_Init(out SliderConstraintSettings settings)
        {
            fixed (SliderConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_SliderConstraintSettings_Init(settingsPtr);
            }
        }
    }
}