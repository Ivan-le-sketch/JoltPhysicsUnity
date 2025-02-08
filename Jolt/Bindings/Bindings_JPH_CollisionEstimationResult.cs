using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_CollisionEstimationResult> JPH_EstimateCollisionResponse(
            NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2,
            NativeHandle<JPH_ContactManifold> manifold,
            float combinedFriction, float combinedRestitution,
            float minVelocityForRestitution,
            uint numIterations)
        {
            return CreateHandle(UnsafeBindings.JPH_EstimateCollisionResponse(body1, body2, manifold, combinedFriction, combinedRestitution, minVelocityForRestitution, numIterations));
        }

        public static void JPH_CollisionEstimationResult_Destroy(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            UnsafeBindings.JPH_CollisionEstimationResult_Destroy(collisionEstimationResult);

            collisionEstimationResult.Dispose();
        }

        public static float3 JPH_CollisionEstimationResult_GetLinearVelocity1(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            float3 linearVelocity1;
            UnsafeBindings.JPH_CollisionEstimationResult_GetLinearVelocity1(collisionEstimationResult, &linearVelocity1);

            return linearVelocity1;
        }

        public static float3 JPH_CollisionEstimationResult_GetLinearVelocity2(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            float3 linearVelocity2;
            UnsafeBindings.JPH_CollisionEstimationResult_GetLinearVelocity2(collisionEstimationResult, &linearVelocity2);

            return linearVelocity2;
        }

        public static float3 JPH_CollisionEstimationResult_GetAngularVelocity1(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            float3 angularVelocity1;
            UnsafeBindings.JPH_CollisionEstimationResult_GetAngularVelocity1(collisionEstimationResult, &angularVelocity1);

            return angularVelocity1;
        }

        public static float3 JPH_CollisionEstimationResult_GetAngularVelocity2(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            float3 angularVelocity2;
            UnsafeBindings.JPH_CollisionEstimationResult_GetAngularVelocity2(collisionEstimationResult, &angularVelocity2);

            return angularVelocity2;
        }

        public static float3 JPH_CollisionEstimationResult_GetTangent1(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            float3 tangent1;
            UnsafeBindings.JPH_CollisionEstimationResult_GetTangent1(collisionEstimationResult, &tangent1);

            return tangent1;
        }

        public static float3 JPH_CollisionEstimationResult_GetTangent2(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            float3 tangent2;
            UnsafeBindings.JPH_CollisionEstimationResult_GetTangent2(collisionEstimationResult, &tangent2);

            return tangent2;
        }

        public static uint JPH_CollisionEstimationResult_GetImpulsesCount(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult)
        {
            return UnsafeBindings.JPH_CollisionEstimationResult_GetImpulsesCount(collisionEstimationResult);
        }

        public static CollisionEstimationResult.Impulse JPH_CollisionEstimationResult_GetImpulse(NativeHandle<JPH_CollisionEstimationResult> collisionEstimationResult, uint index)
        {
            var impulse = new CollisionEstimationResult.Impulse();

            UnsafeBindings.JPH_CollisionEstimationResult_GetImpulse(collisionEstimationResult, index, &impulse);

            return impulse;
        }
    }
}
