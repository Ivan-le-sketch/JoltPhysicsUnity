using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FixedConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        internal NativeBool autoDetectPoint;
        public rvec3 point1;
        public float3 axisX1;
        public float3 axisY1;
        public rvec3 point2;
        public float3 axisX2;
        public float3 axisY2;

        // This property allows not exposing the internal NativeBool field. Making the NativeBool type public under consideration.
        public bool AutoDetectPoint { get => autoDetectPoint; set => autoDetectPoint = value; }

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
