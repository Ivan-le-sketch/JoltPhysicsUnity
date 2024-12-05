using Unity.Mathematics;

namespace Jolt
{
    [GenerateHandle("JPH_Character"), GenerateBindings("JPH_Character", "JPH_CharacterBase")]
    public readonly partial struct Character
    {
        [OverrideBinding("JPH_Character_Create")]
        public static Character Create(CharacterSettings settings, rvec3 position, quaternion rotation, ulong userData, PhysicsSystem physicsSystem)
        {
            return new Character(Bindings.JPH_Character_Create(settings.Handle, position, rotation, userData, physicsSystem.Handle));
        }
    }
}
