using Unity.Mathematics;

namespace Jolt
{
    public unsafe struct CollisionEstimationResult
    {
        public struct Impulse
        {
            public float ContactImpulse;
            public float FrictionImpulse1;
            public float FrictionImpulse2;
        }

        public float3 linearVelocity1;
        public float3 angularVelocity1;
        public float3 linearVelocity2;
        public float3 angularVelocity2;
        public float3 tangent1;
        public float3 tangent2;

        public uint impulseCount;
        public Impulse* impulses;
    }
}