using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct RagdollSettings : IEquatable<RagdollSettings>
    {
        internal readonly NativeHandle<JPH_RagdollSettings> Handle;
        
        internal RagdollSettings(NativeHandle<JPH_RagdollSettings> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(RagdollSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is RagdollSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(RagdollSettings lhs, RagdollSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(RagdollSettings lhs, RagdollSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_RagdollSettings
        
        public void Destroy() => Bindings.JPH_RagdollSettings_Destroy(Handle);
        
        public Skeleton GetSkeleton() => new Skeleton(Bindings.JPH_RagdollSettings_GetSkeleton(Handle));
        
        public void SetSkeleton(Skeleton skeleton) => Bindings.JPH_RagdollSettings_SetSkeleton(Handle, skeleton.Handle);
        
        public bool Stabilize() => Bindings.JPH_RagdollSettings_Stabilize(Handle);
        
        public void CalculateConstraintPriorities(uint basePriority) => Bindings.JPH_RagdollSettings_CalculateConstraintPriorities(Handle, basePriority);
        
        public void DisableParentChildCollisions(float minSeparationDistance) => Bindings.JPH_RagdollSettings_DisableParentChildCollisions(Handle, minSeparationDistance);
        
        public void DisableParentChildCollisions(NativeArray<float4x4> jointMatrices, float minSeparationDistance) => Bindings.JPH_RagdollSettings_DisableParentChildCollisions(Handle, jointMatrices, minSeparationDistance);
        
        public void CalculateBodyIndexToConstraintIndex() => Bindings.JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(Handle);
        
        public int GetConstraintIndexForBodyIndex(int bodyIndex) => Bindings.JPH_RagdollSettings_GetConstraintIndexForBodyIndex(Handle, bodyIndex);
        
        public void CalculateConstraintIndexToBodyIdxPair() => Bindings.JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(Handle);
        
        public bool GetBodyIndicesForConstraintIndex(int constraintIndex, out int bodyIndex1, out int bodyIndex2) => Bindings.JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(Handle, constraintIndex, out bodyIndex1, out bodyIndex2);
        
        public void ResizeParts(int count) => Bindings.JPH_RagdollSettings_ResizeParts(Handle, count);
        
        public int GetPartCount() => Bindings.JPH_RagdollSettings_GetPartCount(Handle);
        
        public BodyCreationSettings GetPart(int partIndex) => new BodyCreationSettings(Bindings.JPH_RagdollSettings_GetPart(Handle, partIndex));
        
        public void SetPartShape(int partIndex, Shape shape) => Bindings.JPH_RagdollSettings_SetPartShape(Handle, partIndex, shape.Handle);
        
        public void SetPartPosition(int partIndex, rvec3 position) => Bindings.JPH_RagdollSettings_SetPartPosition(Handle, partIndex, position);
        
        public void SetPartRotation(int partIndex, quaternion rotation) => Bindings.JPH_RagdollSettings_SetPartRotation(Handle, partIndex, rotation);
        
        public void SetPartMotionType(int partIndex, MotionType motionType) => Bindings.JPH_RagdollSettings_SetPartMotionType(Handle, partIndex, motionType);
        
        public void SetPartObjectLayer(int partIndex, ObjectLayer layer) => Bindings.JPH_RagdollSettings_SetPartObjectLayer(Handle, partIndex, layer);
        
        public void SetPartMassProperties(int partIndex, float mass) => Bindings.JPH_RagdollSettings_SetPartMassProperties(Handle, partIndex, mass);
        
        public void SetPartToParent(int partIndex, SwingTwistConstraintSettings constraintSettings) => Bindings.JPH_RagdollSettings_SetPartToParent(Handle, partIndex, constraintSettings);
        
        public void ClearPartToParent(int partIndex) => Bindings.JPH_RagdollSettings_ClearPartToParent(Handle, partIndex);
        
        public bool AddAdditionalConstraint(int bodyIndex1, int bodyIndex2, SwingTwistConstraintSettings constraintSettings) => Bindings.JPH_RagdollSettings_AddAdditionalConstraint(Handle, bodyIndex1, bodyIndex2, constraintSettings);
        
        public void ClearAdditionalConstraints() => Bindings.JPH_RagdollSettings_ClearAdditionalConstraints(Handle);
        
        public int GetAdditionalConstraintCount() => Bindings.JPH_RagdollSettings_GetAdditionalConstraintCount(Handle);
        
        public Ragdoll CreateRagdoll(PhysicsSystem system, uint collisionGroup, ulong userData) => new Ragdoll(Bindings.JPH_RagdollSettings_CreateRagdoll(Handle, system.Handle, collisionGroup, userData));
        
        #endregion
        
    }
}
