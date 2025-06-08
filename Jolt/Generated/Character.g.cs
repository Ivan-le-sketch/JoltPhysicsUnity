using System;
using Jolt;
using Unity.Mathematics;
using Unity.Collections;

namespace Jolt
{
    public readonly partial struct Character : IEquatable<Character>
    {
        internal readonly NativeHandle<JPH_Character> Handle;
        
        internal Character(NativeHandle<JPH_Character> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(Character other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is Character other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(Character lhs, Character rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(Character lhs, Character rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_Character
        
        public void AddToPhysicsSystem(Activation activationMode, bool lockBodies) => Bindings.JPH_Character_AddToPhysicsSystem(Handle, activationMode, lockBodies);
        
        public void RemoveFromPhysicsSystem(bool lockBodies) => Bindings.JPH_Character_RemoveFromPhysicsSystem(Handle, lockBodies);
        
        public void Activate(bool lockBodies) => Bindings.JPH_Character_Activate(Handle, lockBodies);
        
        public void PostSimulation(float maxSeparationDistance, bool lockBodies) => Bindings.JPH_Character_PostSimulation(Handle, maxSeparationDistance, lockBodies);
        
        #endregion
        
        #region JPH_CharacterBase
        
        public void Destroy() => Bindings.JPH_CharacterBase_Destroy(Handle.Reinterpret<JPH_CharacterBase>());
        
        public float GetCosMaxSlopeAngle() => Bindings.JPH_CharacterBase_GetCosMaxSlopeAngle(Handle.Reinterpret<JPH_CharacterBase>());
        
        public void SetMaxSlopeAngle(float maxSlopeAngle) => Bindings.JPH_CharacterBase_SetMaxSlopeAngle(Handle.Reinterpret<JPH_CharacterBase>(), maxSlopeAngle);
        
        public float3 GetUp() => Bindings.JPH_CharacterBase_GetUp(Handle.Reinterpret<JPH_CharacterBase>());
        
        public void SetUp(float3 value) => Bindings.JPH_CharacterBase_SetUp(Handle.Reinterpret<JPH_CharacterBase>(), value);
        
        public bool IsSlopeTooSteep(float3 value) => Bindings.JPH_CharacterBase_IsSlopeTooSteep(Handle.Reinterpret<JPH_CharacterBase>(), value);
        
        public Shape GetShape() => new Shape(Bindings.JPH_CharacterBase_GetShape(Handle.Reinterpret<JPH_CharacterBase>()));
        
        public GroundState GetGroundState() => Bindings.JPH_CharacterBase_GetGroundState(Handle.Reinterpret<JPH_CharacterBase>());
        
        public bool IsSupported() => Bindings.JPH_CharacterBase_IsSupported(Handle.Reinterpret<JPH_CharacterBase>());
        
        public rvec3 GetGroundPosition() => Bindings.JPH_CharacterBase_GetGroundPosition(Handle.Reinterpret<JPH_CharacterBase>());
        
        public float3 GetGroundNormal() => Bindings.JPH_CharacterBase_GetGroundNormal(Handle.Reinterpret<JPH_CharacterBase>());
        
        public float3 GetGroundVelocity() => Bindings.JPH_CharacterBase_GetGroundVelocity(Handle.Reinterpret<JPH_CharacterBase>());
        
        public PhysicsMaterial GetGroundMaterial() => new PhysicsMaterial(Bindings.JPH_CharacterBase_GetGroundMaterial(Handle.Reinterpret<JPH_CharacterBase>()));
        
        public BodyID GetGroundBodyId() => Bindings.JPH_CharacterBase_GetGroundBodyId(Handle.Reinterpret<JPH_CharacterBase>());
        
        public SubShapeID GetGroundSubShapeId() => Bindings.JPH_CharacterBase_GetGroundSubShapeId(Handle.Reinterpret<JPH_CharacterBase>());
        
        public ulong GetGroundUserData() => Bindings.JPH_CharacterBase_GetGroundUserData(Handle.Reinterpret<JPH_CharacterBase>());
        
        public void SaveState(StateRecorder recorder) => Bindings.JPH_CharacterBase_SaveState(Handle.Reinterpret<JPH_CharacterBase>(), recorder.Handle);
        
        public void RestoreState(StateRecorder recorder) => Bindings.JPH_CharacterBase_RestoreState(Handle.Reinterpret<JPH_CharacterBase>(), recorder.Handle);
        
        #endregion
        
    }
}
