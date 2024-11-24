using Unity.Mathematics;
using static Jolt.Bindings;

namespace Jolt
{
    [GenerateHandle("JPH_CharacterVirtual"), GenerateBindings("JPH_CharacterVirtual", "JPH_CharacterBase")]
    public unsafe readonly partial struct CharacterVirtual
    {
        [OverrideBinding("JPH_CharacterVirtual_Create")]
        public static CharacterVirtual Create(CharacterVirtualSettings settings, rvec3 position, quaternion rotation, ulong userData, PhysicsSystem system)
        {
            JPH_CharacterVirtualSettings nativeSettings;
            settings.ToNative(&nativeSettings);

            return new CharacterVirtual(JPH_CharacterVirtual_Create(&nativeSettings, position, rotation, userData, system.Handle));
        }

        [OverrideBinding("JPH_CharacterVirtual_SetListener")]
        public void SetListener(CharacterContactListener listener)
        {
            JPH_CharacterVirtual_SetListener(Handle, listener.Handle);
        }
    }
}
