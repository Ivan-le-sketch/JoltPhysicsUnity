using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct PointConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public rvec3 point1;
        public rvec3 point2;

        public static PointConstraintSettings Default()
        {
            Bindings.JPH_PointConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_PointConstraintSettings_Init(out this);
        }
    }
}
