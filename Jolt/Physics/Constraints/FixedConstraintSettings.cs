using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct FixedConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public NativeBool autoDetectPoint;
        public rvec3 point1;
        public float3 axisX1;
        public float3 axisY1;
        public rvec3 point2;
        public float3 axisX2;
        public float3 axisY2;

        public static FixedConstraintSettings Default()
        {
            Bindings.JPH_FixedConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_FixedConstraintSettings_Init(out this);
        }
    }
}
