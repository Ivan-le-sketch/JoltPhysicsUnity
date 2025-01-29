using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SwingTwistConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public rvec3 position1;
        public float3 twistAxis1;
        public float3 planeAxis1;
        public rvec3 position2;
        public float3 twistAxis2;
        public float3 planeAxis2;
        public SwingType swingType;
        public float normalHalfConeAngle;
        public float planeHalfConeAngle;
        public float twistMinAngle;
        public float twistMaxAngle;
        public float maxFrictionTorque;
        public MotorSettings swingMotorSettings;
        public MotorSettings twistMotorSettings;

        public static SwingTwistConstraintSettings Default()
        {
            Bindings.JPH_SwingTwistConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_SwingTwistConstraintSettings_Init(out this);
        }
    }
}