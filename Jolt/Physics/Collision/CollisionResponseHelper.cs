namespace Jolt
{
    public static unsafe class CollisionResponseHelper
    {
        public static CollisionEstimationResult EstimateCollisionResponse(
            Body body1, Body body2,
            ContactManifold manifold,
            float combinedFriction, float combinedRestitution,
            float minVelocityForRestitution,
            uint numIterations
            )
        {
            return Bindings.JPH_EstimateCollisionResponse(
                body1.Handle, body2.Handle,
                manifold.Handle,
                combinedFriction, combinedRestitution,
                minVelocityForRestitution,
                numIterations);
        }

        public static CollisionEstimationResult EstimateCollisionResponseInto(
            Body body1, Body body2,
            ContactManifold manifold,
            float combinedFriction, float combinedRestitution,
            float minVelocityForRestitution,
            uint numIterations,
            CollisionEstimationResult.Impulse* impulses,
            uint impulseCapacity,
            rvec3* contactPointsOn1,
            uint contactPointCapacity,
            out uint contactPointCount)
        {
            return Bindings.JPH_EstimateCollisionResponseInto(
                body1.Handle, body2.Handle,
                manifold.Handle,
                combinedFriction, combinedRestitution,
                minVelocityForRestitution,
                numIterations,
                impulses, impulseCapacity,
                contactPointsOn1, contactPointCapacity,
                out contactPointCount);
        }

        /// <summary>
        /// EstimateCollisionResponseInto with the friction, the restitution and the inverse mass and inertia scales of
        /// the contact settings, as the contact constraint uses them. Pass the settings an OnContactAdded override
        /// produced, so that the estimate matches the bodies whose mass it scaled.
        /// </summary>
        public static CollisionEstimationResult EstimateCollisionResponseInto(
            Body body1, Body body2,
            ContactManifold manifold,
            in ContactSettingsData settings,
            float minVelocityForRestitution,
            uint numIterations,
            CollisionEstimationResult.Impulse* impulses,
            uint impulseCapacity,
            rvec3* contactPointsOn1,
            uint contactPointCapacity,
            out uint contactPointCount)
        {
            return Bindings.JPH_EstimateCollisionResponseWithSettingsInto(
                body1.Handle, body2.Handle,
                manifold.Handle,
                settings,
                minVelocityForRestitution,
                numIterations,
                impulses, impulseCapacity,
                contactPointsOn1, contactPointCapacity,
                out contactPointCount);
        }
    }
}
