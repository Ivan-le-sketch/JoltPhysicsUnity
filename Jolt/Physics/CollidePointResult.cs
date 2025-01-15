using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CollidePointResult
    {
        public BodyID BodyID;

        public SubShapeID SubShapeID;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float GetEarlyOutFraction()
        {
            return 0.0f;
        }
    }
}