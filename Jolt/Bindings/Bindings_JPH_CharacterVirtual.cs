using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_CharacterVirtual> JPH_CharacterVirtual_Create(JPH_CharacterVirtualSettings* settings, rvec3 position, quaternion rotation, ulong userData, NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateHandle(UnsafeBindings.JPH_CharacterVirtual_Create(settings, &position, &rotation, userData, system));
        }

        public static void JPH_CharacterVirtual_SetListener(NativeHandle<JPH_CharacterVirtual> character, NativeHandle<JPH_CharacterContactListener> listener)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetListener(character, listener);
        }

        public static float3 JPH_CharacterVirtual_GetLinearVelocity(NativeHandle<JPH_CharacterVirtual> character)
        {
            float3 velocity;

            UnsafeBindings.JPH_CharacterVirtual_GetLinearVelocity(character, &velocity);

            return velocity;
        }

        public static void JPH_CharacterVirtual_SetLinearVelocity(NativeHandle<JPH_CharacterVirtual> character, float3 velocity)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetLinearVelocity(character, &velocity);
        }

        public static rvec3 JPH_CharacterVirtual_GetPosition(NativeHandle<JPH_CharacterVirtual> character)
        {
            rvec3 position;

            UnsafeBindings.JPH_CharacterVirtual_GetPosition(character, &position);

            return position;
        }

        public static void JPH_CharacterVirtual_SetPosition(NativeHandle<JPH_CharacterVirtual> character, rvec3 position)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetPosition(character, &position);
        }

        public static quaternion JPH_CharacterVirtual_GetRotation(NativeHandle<JPH_CharacterVirtual> character)
        {
            quaternion rotation;

            UnsafeBindings.JPH_CharacterVirtual_GetRotation(character, &rotation);

            return rotation;
        }

        public static void JPH_CharacterVirtual_SetRotation(NativeHandle<JPH_CharacterVirtual> character, quaternion rotation)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetRotation(character, &rotation);
        }

        public static rmatrix4x4 JPH_CharacterVirtual_GetWorlTransform(NativeHandle<JPH_CharacterVirtual> character)
        {
            rmatrix4x4 result;

            UnsafeBindings.JPH_CharacterVirtual_GetWorldTransform(character, &result);

            return result;
        }

        public static rmatrix4x4 JPH_CharacterVirtual_GetCenterOfMassTransform(NativeHandle<JPH_CharacterVirtual> character)
        {
            rmatrix4x4 result;

            UnsafeBindings.JPH_CharacterVirtual_GetCenterOfMassTransform(character, &result);

            return result;
        }

        public static float JPH_CharacterVirtual_GetMass(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetMass(character);
        }

        public static void JPH_CharacterVirtual_SetMass(NativeHandle<JPH_CharacterVirtual> character, float value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetMass(character, value);
        }

        public static float JPH_CharacterVirtual_GetMaxStrength(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetMaxStrength(character);
        }

        public static void JPH_CharacterVirtual_SetMaxStrength(NativeHandle<JPH_CharacterVirtual> character, float value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetMaxStrength(character, value);
        }

        public static float JPH_CharacterVirtual_GetPenetrationRecoverySpeed(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetPenetrationRecoverySpeed(character);
        }

        public static void JPH_CharacterVirtual_SetPenetrationRecoverySpeed(NativeHandle<JPH_CharacterVirtual> character, float value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetPenetrationRecoverySpeed(character, value);
        }

        public static bool JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(character);
        }


        public static void JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(NativeHandle<JPH_CharacterVirtual > character, bool value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(character, value);
        }

        public static float JPH_CharacterVirtual_GetCharacterPadding(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetCharacterPadding(character);
        }

        public static uint JPH_CharacterVirtual_GetMaxNumHits(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetMaxNumHits(character);
        }

        public static void JPH_CharacterVirtual_SetMaxNumHits(NativeHandle<JPH_CharacterVirtual> character, uint value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetMaxNumHits(character, value);
        }

        public static float JPH_CharacterVirtual_GetHitReductionCosMaxAngle(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetHitReductionCosMaxAngle(character);
        }

        public static void JPH_CharacterVirtual_SetHitReductionCosMaxAngle(NativeHandle<JPH_CharacterVirtual> character, float value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetHitReductionCosMaxAngle(character, value);
        }

        public static bool JPH_CharacterVirtual_GetMaxHitsExceeded(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetMaxHitsExceeded(character);
        }

        public static float3 JPH_CharacterVirtual_GetShapeOffset(NativeHandle<JPH_CharacterVirtual> character)
        {
            float3 result;

            UnsafeBindings.JPH_CharacterVirtual_GetShapeOffset(character, &result);

            return result;
        }

        public static void JPH_CharacterVirtual_SetShapeOffset(NativeHandle<JPH_CharacterVirtual> character, float3 value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetShapeOffset(character, &value);
        }

        public static ulong JPH_CharacterVirtual_GetUserData(NativeHandle<JPH_CharacterVirtual> character)
        {
            return UnsafeBindings.JPH_CharacterVirtual_GetUserData(character);
        }

        public static void JPH_CharacterVirtual_SetUserData(NativeHandle<JPH_CharacterVirtual> character, ulong value)
        {
            UnsafeBindings.JPH_CharacterVirtual_SetUserData(character, value);
        }

        public static void JPH_CharacterVirtual_CancelVelocityTowardsSteepSlopes(NativeHandle<JPH_CharacterVirtual> character, float3 desiredVelocity, float3 velocity)
        {
            UnsafeBindings.JPH_CharacterVirtual_CancelVelocityTowardsSteepSlopes(character, &desiredVelocity, &velocity);
        }

        public static void JPH_CharacterVirtual_Update(NativeHandle<JPH_CharacterVirtual> character, float deltaTime, ObjectLayer layer, NativeHandle<JPH_PhysicsSystem> system)//, NativeHandle<JPH_BodyFilter> bodyFilter, NativeHandle<JPH_ShapeFilter> shapeFilter)
        {
            UnsafeBindings.JPH_CharacterVirtual_Update(character, deltaTime, layer, system, null, null);// bodyFilter, shapeFilter);
        }

        public static void JPH_CharacterVirtual_ExtendedUpdate(NativeHandle<JPH_CharacterVirtual> character, float deltaTime, ExtendedUpdateSettings settings, ObjectLayer layer, NativeHandle<JPH_PhysicsSystem> system)//, NativeHandle<JPH_BodyFilter> bodyFilter, NativeHandle<JPH_ShapeFilter> shapeFilter)
        {
            UnsafeBindings.JPH_CharacterVirtual_ExtendedUpdate(character, deltaTime, &settings, layer, system, null, null);// bodyFilter, shapeFilter);
        }

        public static void JPH_CharacterVirtual_RefreshContacts(NativeHandle<JPH_CharacterVirtual> character, ObjectLayer layer, NativeHandle<JPH_PhysicsSystem> system)//, NativeHandle<JPH_BodyFilter> bodyFilter, NativeHandle<JPH_ShapeFilter> shapeFilter)
        {
            UnsafeBindings.JPH_CharacterVirtual_RefreshContacts(character, layer, system, null, null);// bodyFilter, shapeFilter);
        }

        public static void JPH_CharacterVirtual_SaveState(NativeHandle<JPH_CharacterVirtual> character, NativeHandle<JPH_StateRecorder> recorder)
        {
            UnsafeBindings.JPH_CharacterVirtual_SaveState(character, recorder);
        }

        public static void JPH_CharacterVirtual_RestoreState(NativeHandle<JPH_CharacterVirtual> character, NativeHandle<JPH_StateRecorder> recorder)
        {
            UnsafeBindings.JPH_CharacterVirtual_RestoreState(character, recorder);
        }
    }
}