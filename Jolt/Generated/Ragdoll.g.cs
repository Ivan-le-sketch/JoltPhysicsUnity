using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct Ragdoll : IEquatable<Ragdoll>
    {
        internal readonly NativeHandle<JPH_Ragdoll> Handle;
        
        internal Ragdoll(NativeHandle<JPH_Ragdoll> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(Ragdoll other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is Ragdoll other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(Ragdoll lhs, Ragdoll rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(Ragdoll lhs, Ragdoll rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_Ragdoll
        
        public void Destroy() => Bindings.JPH_Ragdoll_Destroy(Handle);
        
        public void AddToPhysicsSystem(Activation activationMode, bool lockBodies) => Bindings.JPH_Ragdoll_AddToPhysicsSystem(Handle, activationMode, lockBodies);
        
        public void RemoveFromPhysicsSystem(bool lockBodies) => Bindings.JPH_Ragdoll_RemoveFromPhysicsSystem(Handle, lockBodies);
        
        public void Activate(bool lockBodies) => Bindings.JPH_Ragdoll_Activate(Handle, lockBodies);
        
        public bool IsActive(bool lockBodies) => Bindings.JPH_Ragdoll_IsActive(Handle, lockBodies);
        
        public void SetGroupID(uint groupID, bool lockBodies) => Bindings.JPH_Ragdoll_SetGroupID(Handle, groupID, lockBodies);
        
        public void ResetWarmStart() => Bindings.JPH_Ragdoll_ResetWarmStart(Handle);
        
        public void SetPose(SkeletonPose pose, bool lockBodies) => Bindings.JPH_Ragdoll_SetPose(Handle, pose.Handle, lockBodies);
        
        public void SetPose(rvec3 rootOffset, NativeArray<float4x4> jointMatrices, bool lockBodies) => Bindings.JPH_Ragdoll_SetPose(Handle, rootOffset, jointMatrices, lockBodies);
        
        public void GetPose(SkeletonPose pose, bool lockBodies) => Bindings.JPH_Ragdoll_GetPose(Handle, pose.Handle, lockBodies);
        
        public void GetPose(out rvec3 rootOffset, NativeArray<float4x4> jointMatrices, bool lockBodies) => Bindings.JPH_Ragdoll_GetPose(Handle, out rootOffset, jointMatrices, lockBodies);
        
        public void DriveToPoseUsingKinematics(SkeletonPose pose, float deltaTime, bool lockBodies) => Bindings.JPH_Ragdoll_DriveToPoseUsingKinematics(Handle, pose.Handle, deltaTime, lockBodies);
        
        public void DriveToPoseUsingKinematics(rvec3 rootOffset, NativeArray<float4x4> jointMatrices, float deltaTime, bool lockBodies) => Bindings.JPH_Ragdoll_DriveToPoseUsingKinematics(Handle, rootOffset, jointMatrices, deltaTime, lockBodies);
        
        public void DriveToPoseUsingMotors(SkeletonPose pose) => Bindings.JPH_Ragdoll_DriveToPoseUsingMotors(Handle, pose.Handle);
        
        public void DriveToPoseUsingMotors(SkeletonPose previousPose, SkeletonPose pose, float deltaTime) => Bindings.JPH_Ragdoll_DriveToPoseUsingMotors(Handle, previousPose.Handle, pose.Handle, deltaTime);
        
        public void SetLinearAndAngularVelocity(float3 linearVelocity, float3 angularVelocity, bool lockBodies) => Bindings.JPH_Ragdoll_SetLinearAndAngularVelocity(Handle, linearVelocity, angularVelocity, lockBodies);
        
        public void SetLinearVelocity(float3 linearVelocity, bool lockBodies) => Bindings.JPH_Ragdoll_SetLinearVelocity(Handle, linearVelocity, lockBodies);
        
        public void AddLinearVelocity(float3 linearVelocity, bool lockBodies) => Bindings.JPH_Ragdoll_AddLinearVelocity(Handle, linearVelocity, lockBodies);
        
        public void AddImpulse(float3 impulse, bool lockBodies) => Bindings.JPH_Ragdoll_AddImpulse(Handle, impulse, lockBodies);
        
        public int GetBodyCount() => Bindings.JPH_Ragdoll_GetBodyCount(Handle);
        
        public BodyID GetBodyID(int bodyIndex) => Bindings.JPH_Ragdoll_GetBodyID(Handle, bodyIndex);
        
        public int GetConstraintCount() => Bindings.JPH_Ragdoll_GetConstraintCount(Handle);
        
        public Constraint GetConstraint(int constraintIndex) => new Constraint(Bindings.JPH_Ragdoll_GetConstraint(Handle, constraintIndex));
        
        public void GetRootTransform(out rvec3 position, out quaternion rotation, bool lockBodies) => Bindings.JPH_Ragdoll_GetRootTransform(Handle, out position, out rotation, lockBodies);
        
        public AABox GetWorldSpaceBounds(bool lockBodies) => Bindings.JPH_Ragdoll_GetWorldSpaceBounds(Handle, lockBodies);
        
        public RagdollSettings GetRagdollSettings() => new RagdollSettings(Bindings.JPH_Ragdoll_GetRagdollSettings(Handle));
        
        #endregion
        
    }
}
