using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_Character> JPH_Character_Create(NativeHandle<JPH_CharacterSettings> settings, rvec3 position, quaternion rotation, ulong userData, NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateHandle(UnsafeBindings.JPH_Character_Create(settings, &position, &rotation, userData, system));
        }

        public static void JPH_Character_AddToPhysicsSystem(NativeHandle<JPH_Character> character, Activation activationMode, bool lockBodies)
        {
            UnsafeBindings.JPH_Character_AddToPhysicsSystem(character, activationMode, lockBodies);
        }

        public static void JPH_Character_RemoveFromPhysicsSystem(NativeHandle<JPH_Character> character, bool lockBodies)
        {
            UnsafeBindings.JPH_Character_RemoveFromPhysicsSystem(character, lockBodies);
        }

        public static void JPH_Character_Activate(NativeHandle<JPH_Character> character, bool lockBodies)
        {
            UnsafeBindings.JPH_Character_Activate(character, lockBodies);
        }

        public static void JPH_Character_PostSimulation(NativeHandle<JPH_Character> character, float maxSeparationDistance, bool lockBodies)
        {
            UnsafeBindings.JPH_Character_PostSimulation(character, maxSeparationDistance, lockBodies);
        }
    }
}
