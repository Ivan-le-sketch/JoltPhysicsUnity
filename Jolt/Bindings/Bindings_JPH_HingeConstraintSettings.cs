using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_HingeConstraintSettings_Init(out HingeConstraintSettings settings)
        {
            fixed (HingeConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_HingeConstraintSettings_Init(settingsPtr);
            }
        }
    }
}