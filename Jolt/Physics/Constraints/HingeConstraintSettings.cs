using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HingeConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public rvec3 point1;
        public float3 hingeAxis1;
        public float3 normalAxis1;
        public rvec3 point2;
        public float3 hingeAxis2;
        public float3 normalAxis2;
        public float limitsMin;
        public float limitsMax;
        public SpringSettings limitsSpringSettings;
        public float maxFrictionTorque;
        public MotorSettings motorSettings;

        public static HingeConstraintSettings Default()
        {
            Bindings.JPH_HingeConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_HingeConstraintSettings_Init(out this);
        }
    }
}
