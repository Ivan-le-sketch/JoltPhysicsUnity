using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ConstraintSettings
    {
        internal NativeBool enabled;
        public uint constraintPriority;
        public uint numVelocityStepsOverride;
        public uint numPositionStepsOverride;
        public float drawConstraintSize;
        public ulong userData;

        // This property allows not exposing the internal NativeBool field. Making the NativeBool type public under consideration.
        public bool Enabled { get => enabled; set => enabled = value; }
    }
}
