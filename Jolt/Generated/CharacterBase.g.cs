using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct CharacterBase : IEquatable<CharacterBase>
    {
        internal readonly NativeHandle<JPH_CharacterBase> Handle;
        
        internal CharacterBase(NativeHandle<JPH_CharacterBase> handle) => Handle = handle;
        
        public void AddUser() => Handle.AddUser();
        
        public void RemoveUser() => Handle.RemoveUser();
        
        #region IEquatable
        
        public bool Equals(CharacterBase other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is CharacterBase other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(CharacterBase lhs, CharacterBase rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(CharacterBase lhs, CharacterBase rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_CharacterBase
        
        public void Destroy() => Bindings.JPH_CharacterBase_Destroy(Handle);
        
        public float GetCosMaxSlopeAngle() => Bindings.JPH_CharacterBase_GetCosMaxSlopeAngle(Handle);
        
        public void SetMaxSlopeAngle(float maxSlopeAngle) => Bindings.JPH_CharacterBase_SetMaxSlopeAngle(Handle, maxSlopeAngle);
        
        public float3 GetUp() => Bindings.JPH_CharacterBase_GetUp(Handle);
        
        public void SetUp(float3 value) => Bindings.JPH_CharacterBase_SetUp(Handle, value);
        
        public bool IsSlopeTooSteep(float3 value) => Bindings.JPH_CharacterBase_IsSlopeTooSteep(Handle, value);
        
        public Shape GetShape() => new Shape(Bindings.JPH_CharacterBase_GetShape(Handle));
        
        public GroundState GetGroundState() => Bindings.JPH_CharacterBase_GetGroundState(Handle);
        
        public bool IsSupported() => Bindings.JPH_CharacterBase_IsSupported(Handle);
        
        public rvec3 GetGroundPosition() => Bindings.JPH_CharacterBase_GetGroundPosition(Handle);
        
        public float3 GetGroundNormal() => Bindings.JPH_CharacterBase_GetGroundNormal(Handle);
        
        public float3 GetGroundVelocity() => Bindings.JPH_CharacterBase_GetGroundVelocity(Handle);
        
        public PhysicsMaterial GetGroundMaterial() => new PhysicsMaterial(Bindings.JPH_CharacterBase_GetGroundMaterial(Handle));
        
        public BodyID GetGroundBodyId() => Bindings.JPH_CharacterBase_GetGroundBodyId(Handle);
        
        public SubShapeID GetGroundSubShapeId() => Bindings.JPH_CharacterBase_GetGroundSubShapeId(Handle);
        
        public ulong GetGroundUserData() => Bindings.JPH_CharacterBase_GetGroundUserData(Handle);
        
        public void SaveState(StateRecorder recorder) => Bindings.JPH_CharacterBase_SaveState(Handle, recorder.Handle);
        
        public void RestoreState(StateRecorder recorder) => Bindings.JPH_CharacterBase_RestoreState(Handle, recorder.Handle);
        
        #endregion
        
    }
}
