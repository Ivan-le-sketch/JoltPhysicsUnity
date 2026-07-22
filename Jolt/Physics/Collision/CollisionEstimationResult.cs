using Unity.Mathematics;

namespace Jolt
{
    public unsafe struct CollisionEstimationResult
    {
        public struct Impulse
        {
            public float ContactImpulse;
            // Jolt 5.6 reports aggregate friction on the parent result. Impulse zero mirrors it for legacy sums.
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

        public float3 frictionPoint;
        public float frictionImpulse1;
        public float frictionImpulse2;
        public float angularFrictionImpulse;
    }
}
