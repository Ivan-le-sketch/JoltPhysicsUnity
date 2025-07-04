﻿using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct PointConstraint : IEquatable<PointConstraint>
    {
        internal readonly NativeHandle<JPH_PointConstraint> Handle;
        
        internal PointConstraint(NativeHandle<JPH_PointConstraint> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(PointConstraint other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is PointConstraint other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(PointConstraint lhs, PointConstraint rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(PointConstraint lhs, PointConstraint rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_PointConstraint
        
        public PointConstraintSettings GetSettings() => Bindings.JPH_PointConstraint_GetSettings(Handle);
        
        public void SetPoint1(ConstraintSpace space, rvec3 value) => Bindings.JPH_PointConstraint_SetPoint1(Handle, space, value);
        
        public void SetPoint2(ConstraintSpace space, rvec3 value) => Bindings.JPH_PointConstraint_SetPoint2(Handle, space, value);
        
        public float3 GetLocalSpacePoint1() => Bindings.JPH_PointConstraint_GetLocalSpacePoint1(Handle);
        
        public float3 GetLocalSpacePoint2() => Bindings.JPH_PointConstraint_GetLocalSpacePoint2(Handle);
        
        public float3 GetTotalLambdaPosition() => Bindings.JPH_PointConstraint_GetTotalLambdaPosition(Handle);
        
        #endregion
        
        #region JPH_TwoBodyConstraint
        
        public Body GetBody1() => new Body(Bindings.JPH_TwoBodyConstraint_GetBody1(Handle.Reinterpret<JPH_TwoBodyConstraint>()));
        
        public Body GetBody2() => new Body(Bindings.JPH_TwoBodyConstraint_GetBody2(Handle.Reinterpret<JPH_TwoBodyConstraint>()));
        
        public float4x4 GetConstraintToBody1Matrix() => Bindings.JPH_TwoBodyConstraint_GetConstraintToBody1Matrix(Handle.Reinterpret<JPH_TwoBodyConstraint>());
        
        public float4x4 GetConstraintToBody2Matrix() => Bindings.JPH_TwoBodyConstraint_GetConstraintToBody2Matrix(Handle.Reinterpret<JPH_TwoBodyConstraint>());
        
        #endregion
        
        #region JPH_Constraint
        
        public void Destroy() => Bindings.JPH_Constraint_Destroy(Handle.Reinterpret<JPH_Constraint>());
        
        public new ConstraintType GetType() => Bindings.JPH_Constraint_GetType(Handle.Reinterpret<JPH_Constraint>());
        
        public ConstraintSubType GetSubType() => Bindings.JPH_Constraint_GetSubType(Handle.Reinterpret<JPH_Constraint>());
        
        public uint GetConstraintPriority() => Bindings.JPH_Constraint_GetConstraintPriority(Handle.Reinterpret<JPH_Constraint>());
        
        public void SetConstraintPriority(uint priority) => Bindings.JPH_Constraint_SetConstraintPriority(Handle.Reinterpret<JPH_Constraint>(), priority);
        
        public uint GetNumVelocityStepsOverride() => Bindings.JPH_Constraint_GetNumVelocityStepsOverride(Handle.Reinterpret<JPH_Constraint>());
        
        public void SetNumVelocityStepsOverride(uint value) => Bindings.JPH_Constraint_SetNumVelocityStepsOverride(Handle.Reinterpret<JPH_Constraint>(), value);
        
        public uint GetNumPositionStepsOverride() => Bindings.JPH_Constraint_GetNumPositionStepsOverride(Handle.Reinterpret<JPH_Constraint>());
        
        public void SetNumPositionStepsOverride(uint value) => Bindings.JPH_Constraint_SetNumPositionStepsOverride(Handle.Reinterpret<JPH_Constraint>(), value);
        
        public bool GetEnabled() => Bindings.JPH_Constraint_GetEnabled(Handle.Reinterpret<JPH_Constraint>());
        
        public void SetEnabled(bool enabled) => Bindings.JPH_Constraint_SetEnabled(Handle.Reinterpret<JPH_Constraint>(), enabled);
        
        public ulong GetUserData() => Bindings.JPH_Constraint_GetUserData(Handle.Reinterpret<JPH_Constraint>());
        
        public void SetUserData(ulong userData) => Bindings.JPH_Constraint_SetUserData(Handle.Reinterpret<JPH_Constraint>(), userData);
        
        public void NotifyShapeChanged(BodyID bodyID, float3 deltaCOM) => Bindings.JPH_Constraint_NotifyShapeChanged(Handle.Reinterpret<JPH_Constraint>(), bodyID, deltaCOM);
        
        public void ResetWarmStart() => Bindings.JPH_Constraint_ResetWarmStart(Handle.Reinterpret<JPH_Constraint>());
        
        public bool IsActive() => Bindings.JPH_Constraint_IsActive(Handle.Reinterpret<JPH_Constraint>());
        
        public void SetupVelocityConstraint(float deltaTime) => Bindings.JPH_Constraint_SetupVelocityConstraint(Handle.Reinterpret<JPH_Constraint>(), deltaTime);
        
        public void WarmStartVelocityConstraint(float warmStartInpulseRatio) => Bindings.JPH_Constraint_WarmStartVelocityConstraint(Handle.Reinterpret<JPH_Constraint>(), warmStartInpulseRatio);
        
        public bool SolveVelocityConstraint(float deltaTime) => Bindings.JPH_Constraint_SolveVelocityConstraint(Handle.Reinterpret<JPH_Constraint>(), deltaTime);
        
        public bool SolvePositionConstraint(float deltaTime, float baumgarte) => Bindings.JPH_Constraint_SolvePositionConstraint(Handle.Reinterpret<JPH_Constraint>(), deltaTime, baumgarte);
        
        #endregion
        
    }
}
