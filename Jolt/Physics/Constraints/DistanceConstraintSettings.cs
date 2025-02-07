using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct DistanceConstraintSettings
    {
        public ConstraintSettings @base;

        public ConstraintSpace space;
        public rvec3 point1;
        public rvec3 point2;
        public float minDistance;
        public float maxDistance;
        public SpringSettings limitsSpringSettings;

        public static DistanceConstraintSettings Default()
        {
            Bindings.JPH_DistanceConstraintSettings_Init(out var settings);

            return settings;
        }

        public void Init()
        {
            Bindings.JPH_DistanceConstraintSettings_Init(out this);
        }
    }
}
