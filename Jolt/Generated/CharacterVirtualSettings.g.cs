using System;
using Jolt;
using Unity.Mathematics;

namespace Jolt
{
    public readonly partial struct CharacterVirtualSettings : IEquatable<CharacterVirtualSettings>
    {
        internal readonly NativeHandle<JPH_CharacterVirtualSettings> Handle;
        
        internal CharacterVirtualSettings(NativeHandle<JPH_CharacterVirtualSettings> handle) => Handle = handle;
        
        #region IEquatable
        
        public bool Equals(CharacterVirtualSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is CharacterVirtualSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(CharacterVirtualSettings lhs, CharacterVirtualSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(CharacterVirtualSettings lhs, CharacterVirtualSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_CharacterVirtualSettings
        
        public void Init() => Bindings.JPH_CharacterVirtualSettings_Init(Handle);
        
        #endregion
        
    }
}
