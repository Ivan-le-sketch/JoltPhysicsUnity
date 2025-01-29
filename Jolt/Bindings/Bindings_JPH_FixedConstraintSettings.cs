using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_FixedConstraintSettings_Init(out FixedConstraintSettings settings)
        {
            fixed (FixedConstraintSettings* settingsPtr = &settings)
            {
                UnsafeBindings.JPH_FixedConstraintSettings_Init(settingsPtr);
            }
        }
    }
}
