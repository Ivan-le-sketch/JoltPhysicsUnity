using Unity.Mathematics;
using static Jolt.Bindings;

namespace Jolt
{
    [GenerateHandle("JPH_CharacterVirtual"), GenerateBindings("JPH_CharacterVirtual", "JPH_CharacterBase")]
    public readonly partial struct CharacterVirtual
    {
        [OverrideBinding("JPH_CharacterVirtual_Create")]
        public CharacterVirtual Create(CharacterVirtualSettings settings, rvec3 position, quaternion rotation, ulong userData, PhysicsSystem system)
        {
            return new CharacterVirtual(JPH_CharacterVirtual_Create(settings.Handle, position, rotation, userData, system.Handle));
        }

        [OverrideBinding("JPH_CharacterVirtual_SetListener")]
        public void SetListener(ICharacterContactListener listener)
        {
            var listenerNativeHandle = JPH_CharacterContactListener_Create(listener);

            JPH_CharacterVirtual_SetListener(Handle, listenerNativeHandle);
        }
    }
}
