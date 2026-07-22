namespace Jolt
{
    [GenerateHandle("JPH_Ragdoll"), GenerateBindings("JPH_Ragdoll")]
    public readonly partial struct Ragdoll
    {
        public bool IsCreated => Handle.RawValue != 0;

        public void AddToPhysicsSystem(Activation activationMode = Activation.Activate)
        {
            AddToPhysicsSystem(activationMode, true);
        }

        public void RemoveFromPhysicsSystem() => RemoveFromPhysicsSystem(true);
        public void Activate() => Activate(true);
        public bool IsActive() => IsActive(true);
        public void SetGroupID(uint groupID) => SetGroupID(groupID, true);
        public void SetPose(SkeletonPose pose) => SetPose(pose, true);
        public void SetPose(rvec3 rootOffset, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> jointMatrices) => SetPose(rootOffset, jointMatrices, true);
        public void GetPose(SkeletonPose pose) => GetPose(pose, true);
        public void GetPose(out rvec3 rootOffset, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> jointMatrices) => GetPose(out rootOffset, jointMatrices, true);
        public void DriveToPoseUsingKinematics(SkeletonPose pose, float deltaTime) => DriveToPoseUsingKinematics(pose, deltaTime, true);
        public void DriveToPoseUsingKinematics(rvec3 rootOffset, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> jointMatrices, float deltaTime) => DriveToPoseUsingKinematics(rootOffset, jointMatrices, deltaTime, true);
        public void SetLinearAndAngularVelocity(Unity.Mathematics.float3 linearVelocity, Unity.Mathematics.float3 angularVelocity) => SetLinearAndAngularVelocity(linearVelocity, angularVelocity, true);
        public void SetLinearVelocity(Unity.Mathematics.float3 linearVelocity) => SetLinearVelocity(linearVelocity, true);
        public void AddLinearVelocity(Unity.Mathematics.float3 linearVelocity) => AddLinearVelocity(linearVelocity, true);
        public void AddImpulse(Unity.Mathematics.float3 impulse) => AddImpulse(impulse, true);
        public void GetRootTransform(out rvec3 position, out Unity.Mathematics.quaternion rotation) => GetRootTransform(out position, out rotation, true);
        public AABox GetWorldSpaceBounds() => GetWorldSpaceBounds(true);
    }
}
