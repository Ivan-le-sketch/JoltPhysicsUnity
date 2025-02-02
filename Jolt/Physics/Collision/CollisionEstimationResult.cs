namespace Jolt
{
    [GenerateHandle("JPH_CollisionEstimationResult"), GenerateBindings("JPH_CollisionEstimationResult")]
    public readonly partial struct CollisionEstimationResult
    {
        public struct Impulse
        {
            public float ContactImpulse;
            public float FrictionImpulse1;
            public float FrictionImpulse2;
        }
    }
}