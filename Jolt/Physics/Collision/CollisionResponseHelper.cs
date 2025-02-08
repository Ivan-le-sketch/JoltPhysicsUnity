namespace Jolt
{
    public static class CollisionResponseHelper
    {
        public static CollisionEstimationResult EstimateCollisionResponse(
            Body body1, Body body2,
            ContactManifold manifold,
            float combinedFriction, float combinedRestitution,
            float minVelocityForRestitution,
            uint numIterations
            )
        {
            return new CollisionEstimationResult(Bindings.JPH_EstimateCollisionResponse(
                body1.Handle, body2.Handle, 
                manifold.Handle, 
                combinedFriction, combinedRestitution, 
                minVelocityForRestitution, 
                numIterations));
        }
    }
}
