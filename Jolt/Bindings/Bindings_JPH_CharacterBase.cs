using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_CharacterBase_Destroy(NativeHandle<JPH_CharacterBase> character)
        {
            UnsafeBindings.JPH_CharacterBase_Destroy(character);
        }

        public static float JPH_CharacterBase_GetCosMaxSlopeAngle(NativeHandle<JPH_CharacterBase> character)
        {
            return UnsafeBindings.JPH_CharacterBase_GetCosMaxSlopeAngle(character);
        }

        public static void JPH_CharacterBase_SetMaxSlopeAngle(NativeHandle<JPH_CharacterBase> character, float maxSlopeAngle)
        {
            UnsafeBindings.JPH_CharacterBase_SetMaxSlopeAngle(character, maxSlopeAngle);
        }

        public static float3 JPH_CharacterBase_GetUp(NativeHandle<JPH_CharacterBase> character)
        {
            float3 result;

            UnsafeBindings.JPH_CharacterBase_GetUp(character, &result);

            return result;
        }

        public static void JPH_CharacterBase_SetUp(NativeHandle<JPH_CharacterBase> character, float3 value)
        {
            UnsafeBindings.JPH_CharacterBase_SetUp(character, &value);
        }

        public static bool JPH_CharacterBase_IsSlopeTooSteep(NativeHandle<JPH_CharacterBase> character, float3 value)
        {
            return UnsafeBindings.JPH_CharacterBase_IsSlopeTooSteep(character, &value);
        }

        public static NativeHandle<JPH_Shape> JPH_CharacterBase_GetShape(NativeHandle<JPH_CharacterBase> character)
        {
            return CreateHandle(UnsafeBindings.JPH_CharacterBase_GetShape(character));
        }

        public static GroundState JPH_CharacterBase_GetGroundState(NativeHandle<JPH_CharacterBase> character)
        {
            return UnsafeBindings.JPH_CharacterBase_GetGroundState(character);
        }

        public static bool JPH_CharacterBase_IsSupported(NativeHandle<JPH_CharacterBase> character)
        {
            return UnsafeBindings.JPH_CharacterBase_IsSupported(character);
        }

        public static rvec3 JPH_CharacterBase_GetGroundPosition(NativeHandle<JPH_CharacterBase> character)
        {
            rvec3 position;

            UnsafeBindings.JPH_CharacterBase_GetGroundPosition(character, &position);

            return position;
        }

        public static float3 JPH_CharacterBase_GetGroundNormal(NativeHandle<JPH_CharacterBase> character)
        {
            float3 normal;

            UnsafeBindings.JPH_CharacterBase_GetGroundNormal(character, &normal);

            return normal;
        }

        public static float3 JPH_CharacterBase_GetGroundVelocity(NativeHandle<JPH_CharacterBase> character)
        {
            float3 velocity;

            UnsafeBindings.JPH_CharacterBase_GetGroundVelocity(character, &velocity);

            return velocity;
        }

        public static NativeHandle<JPH_PhysicsMaterial> JPH_CharacterBase_GetGroundMaterial(NativeHandle<JPH_CharacterBase> character)
        {
            return CreateHandle(UnsafeBindings.JPH_CharacterBase_GetGroundMaterial(character));
        }

        public static BodyID JPH_CharacterBase_GetGroundBodyId(NativeHandle<JPH_CharacterBase> character)
        {
            return UnsafeBindings.JPH_CharacterBase_GetGroundBodyId(character);
        }

        public static SubShapeID JPH_CharacterBase_GetGroundSubShapeId(NativeHandle<JPH_CharacterBase> character)
        {
            return UnsafeBindings.JPH_CharacterBase_GetGroundSubShapeId(character);
        }

        public static ulong JPH_CharacterBase_GetGroundUserData(NativeHandle<JPH_CharacterBase> character)
        {
            return UnsafeBindings.JPH_CharacterBase_GetGroundUserData(character);
        }
    }
}
