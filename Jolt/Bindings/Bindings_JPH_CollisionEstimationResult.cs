namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static CollisionEstimationResult JPH_EstimateCollisionResponse(
            NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2,
            NativeHandle<JPH_ContactManifold> manifold,
            float combinedFriction, float combinedRestitution,
            float minVelocityForRestitution,
            uint numIterations)
        {
            var collisionEstimationResult = new CollisionEstimationResult();

            UnsafeBindings.JPH_EstimateCollisionResponse(body1, body2, manifold, combinedFriction, combinedRestitution, minVelocityForRestitution, numIterations, &collisionEstimationResult);

            return collisionEstimationResult;
        }
    }
}
