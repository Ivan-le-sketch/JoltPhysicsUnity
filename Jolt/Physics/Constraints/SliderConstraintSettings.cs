using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct SliderConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public NativeBool autoDetectPoint;
        public rvec3 point1;
        public float3 sliderAxis1;
        public float3 normalAxis1;
        public rvec3 point2;
        public float3 sliderAxis2;
        public float3 normalAxis2;
        public float limitsMin;
        public float limitsMax;
        public SpringSettings limitsSpringSettings;
        public float maxFrictionForce;
        public MotorSettings motorSettings;

        public static SliderConstraintSettings Default()
        {
            Bindings.JPH_SliderConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_SliderConstraintSettings_Init(out this);
        }
    }
}
