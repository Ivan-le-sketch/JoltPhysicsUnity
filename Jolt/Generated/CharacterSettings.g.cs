using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct CharacterSettings : IEquatable<CharacterSettings>
    {
        internal readonly NativeHandle<JPH_CharacterSettings> Handle;
        
        internal CharacterSettings(NativeHandle<JPH_CharacterSettings> handle) => Handle = handle;
        
        #region IEquatable
        
        public bool Equals(CharacterSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is CharacterSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(CharacterSettings lhs, CharacterSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(CharacterSettings lhs, CharacterSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_CharacterSettings
        
        public void Init() => Bindings.JPH_CharacterSettings_Init(Handle);
        
        #endregion
        
    }
}
