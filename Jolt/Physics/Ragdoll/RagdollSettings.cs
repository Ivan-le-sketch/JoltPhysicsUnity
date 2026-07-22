namespace Jolt
{
    [GenerateHandle("JPH_RagdollSettings"), GenerateBindings("JPH_RagdollSettings")]
    public readonly partial struct RagdollSettings
    {
        public bool IsCreated => Handle.RawValue != 0;

        [OverrideBinding("JPH_RagdollSettings_Create")]
        public static RagdollSettings Create()
        {
            return new RagdollSettings(Bindings.JPH_RagdollSettings_Create());
        }

        public void CalculateConstraintPriorities()
        {
            CalculateConstraintPriorities(0);
        }

        public void DisableParentChildCollisions()
        {
            DisableParentChildCollisions(0.0f);
        }

        public void DisableParentChildCollisions(Unity.Collections.NativeArray<Unity.Mathematics.float4x4> jointMatrices)
        {
            DisableParentChildCollisions(jointMatrices, 0.0f);
        }

        public Ragdoll CreateRagdoll(PhysicsSystem system)
        {
            return CreateRagdoll(system, 0, 0);
        }

        public Ragdoll CreateRagdoll(PhysicsSystem system, uint collisionGroup)
        {
            return CreateRagdoll(system, collisionGroup, 0);
        }
    }
}
