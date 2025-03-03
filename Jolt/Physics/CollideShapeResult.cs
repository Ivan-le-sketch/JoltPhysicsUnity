using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct CollideShapeResult
    {
        public float3 ContactPointOn1; 
        public float3 ContactPointOn2;  
        public float3 PenetrationAxis; 
        public float PenetrationDepth;
        public SubShapeID SubShapeID1;   
        public SubShapeID SubShapeID2;
        public BodyID BodyID2;
        public uint shape1FaceCount;
        public float3* shape1Faces;
        public uint shape2FaceCount;
        public float3* shape2Faces;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float GetEarlyOutFraction()
        {
            return -PenetrationDepth;
        }
    }
}