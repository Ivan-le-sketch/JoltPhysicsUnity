using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SixDOFConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public rvec3 position1;
        public float3 axisX1;
        public float3 axisY1;
        public rvec3 position2;
        public float3 axisX2;
        public float3 axisY2;
        public fixed float maxFriction[6];
        public SwingType swingType;
        public fixed float limitMin[6];
        public fixed float limitMax[6];
        public _limitsSpringSettings_e__FixedBuffer limitsSpringSettings;
        public _motorSettings_e__FixedBuffer motorSettings;

        public partial struct _limitsSpringSettings_e__FixedBuffer
        {
            public SpringSettings e0;
            public SpringSettings e1;
            public SpringSettings e2;

            public unsafe ref SpringSettings this[int index]
            {
                get
                {
                    fixed (SpringSettings* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public partial struct _motorSettings_e__FixedBuffer
        {
            public MotorSettings e0;
            public MotorSettings e1;
            public MotorSettings e2;
            public MotorSettings e3;
            public MotorSettings e4;
            public MotorSettings e5;

            public unsafe ref MotorSettings this[int index]
            {
                get
                {
                    fixed (MotorSettings* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public static SixDOFConstraintSettings Default()
        {
            Bindings.JPH_SixDOFConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_SixDOFConstraintSettings_Init(out this);
        }
    }
}