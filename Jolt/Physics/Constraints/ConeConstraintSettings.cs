using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ConeConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public rvec3 point1;
        public float3 twistAxis1;
        public rvec3 point2;
        public float3 twistAxis2;
        public float halfConeAngle;

        public static ConeConstraintSettings Default()
        {
            Bindings.JPH_ConeConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_ConeConstraintSettings_Init(out this);
        }
    }
}