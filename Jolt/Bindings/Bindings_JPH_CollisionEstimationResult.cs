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

        public static CollisionEstimationResult JPH_EstimateCollisionResponseInto(
            NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2,
            NativeHandle<JPH_ContactManifold> manifold,
            float combinedFriction, float combinedRestitution,
            float minVelocityForRestitution,
            uint numIterations,
            CollisionEstimationResult.Impulse* impulses,
            uint impulseCapacity,
            rvec3* contactPointsOn1,
            uint contactPointCapacity,
            out uint contactPointCount)
        {
            var collisionEstimationResult = new CollisionEstimationResult();

            contactPointCount = UnsafeBindings.JPH_EstimateCollisionResponseInto(
                body1, body2, manifold,
                combinedFriction, combinedRestitution,
                minVelocityForRestitution, numIterations,
                impulses, impulseCapacity,
                contactPointsOn1, contactPointCapacity,
                &collisionEstimationResult);

            return collisionEstimationResult;
        }
    }
}
