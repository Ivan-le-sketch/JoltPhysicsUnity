using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    // JPH_ShapeCastResult is 4-byte aligned and has 3 bytes of tail padding after
    // isBackFaceHit. The explicit size is important when native code writes an array:
    // every element after index 0 must use the native 60-byte stride.
    [StructLayout(LayoutKind.Sequential, Pack = 4, Size = 60)]
    public struct ShapeCastResult
    {
        public float3 ContactPointOn1;
        
        public float3 ContactPointOn2;
        
        public float3 PenetrationAxis;
        
        public float PenetrationDepth;

        public SubShapeID SubShapeID1;
        
        public SubShapeID SubShapeID2;
        
        public BodyID BodyID2;

        public float Fraction;
        
        private NativeBool isBackFaceHit; // proxied by bool getter to avoid leaking NativeBool

        public bool IsBackFaceHit => isBackFaceHit;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float GetEarlyOutFraction()
        {
            return Fraction > 0f ? Fraction : -PenetrationDepth;
        }
    }
}
