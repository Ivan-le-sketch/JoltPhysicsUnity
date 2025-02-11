using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct ConstraintSettings
    {
        public NativeBool enabled;
        public uint constraintPriority;
        public uint numVelocityStepsOverride;
        public uint numPositionStepsOverride;
        public float drawConstraintSize;
        public ulong userData;
    }
}
