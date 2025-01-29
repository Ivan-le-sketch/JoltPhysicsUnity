using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GearConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public float3 hingeAxis1;
        public float3 hingeAxis2;
        public float ratio;

        public static GearConstraintSettings Default()
        {
            Bindings.JPH_GearConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_GearConstraintSettings_Init(out this);
        }
    }
}
