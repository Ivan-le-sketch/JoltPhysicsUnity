using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_BodyCreationSettings> JPH_BodyCreationSettings_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_BodyCreationSettings_Create());
        }

        public static NativeHandle<JPH_BodyCreationSettings> JPH_BodyCreationSettings_Create(NativeHandle<JPH_ShapeSettings> settings, rvec3 position, quaternion rotation, MotionType motion, ushort layer)
        {
            return CreateHandle(UnsafeBindings.JPH_BodyCreationSettings_Create2(settings, &position, &rotation, motion, layer));
        }

        public static NativeHandle<JPH_BodyCreationSettings> JPH_BodyCreationSettings_Create(NativeHandle<JPH_Shape> shape, rvec3 position, quaternion rotation, MotionType motion, ushort layer)
        {
            return CreateHandle(UnsafeBindings.JPH_BodyCreationSettings_Create3(shape, &position, &rotation, motion, layer));
        }

        public static void JPH_BodyCreationSettings_Destroy(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            if (settings.HasUser()) return;

            UnsafeBindings.JPH_BodyCreationSettings_Destroy(settings);

            settings.Dispose();
        }

        public static rvec3 JPH_BodyCreationSettings_GetPosition(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            rvec3 result;
            UnsafeBindings.JPH_BodyCreationSettings_GetPosition(settings, &result);
            return result;
        }

        public static void JPH_BodyCreationSettings_SetPosition(NativeHandle<JPH_BodyCreationSettings> settings, rvec3 value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetPosition(settings, &value);
        }

        public static quaternion JPH_BodyCreationSettings_GetRotation(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            quaternion result;
            UnsafeBindings.JPH_BodyCreationSettings_GetRotation(settings, &result);
            return result;
        }

        public static void JPH_BodyCreationSettings_SetRotation(NativeHandle<JPH_BodyCreationSettings> settings, quaternion value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetRotation(settings, &value);
        }

        public static float3 JPH_BodyCreationSettings_GetLinearVelocity(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            float3 result;
            UnsafeBindings.JPH_BodyCreationSettings_GetLinearVelocity(settings, &result);
            return result;
        }

        public static void JPH_BodyCreationSettings_SetLinearVelocity(NativeHandle<JPH_BodyCreationSettings> settings, float3 velocity)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetLinearVelocity(settings, &velocity);
        }

        public static float3 JPH_BodyCreationSettings_GetAngularVelocity(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            float3 result;
            UnsafeBindings.JPH_BodyCreationSettings_GetAngularVelocity(settings, &result);
            return result;
        }

        public static void JPH_BodyCreationSettings_SetAngularVelocity(NativeHandle<JPH_BodyCreationSettings> settings, float3 velocity)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetAngularVelocity(settings, &velocity);
        }

        public static ulong JPH_BodyCreationSettings_GetUserData(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetUserData(settings);
        }

        public static void JPH_BodyCreationSettings_SetUserData(NativeHandle<JPH_BodyCreationSettings> settings, ulong userData)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetUserData(settings, userData);
        }

        public static ObjectLayer JPH_BodyCreationSettings_GetObjectLayer(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetObjectLayer(settings);
        }

        public static void JPH_BodyCreationSettings_SetObjectLayer(NativeHandle<JPH_BodyCreationSettings> settings, ObjectLayer objectLayer)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetObjectLayer(settings, objectLayer);
        }

        public static MotionType JPH_BodyCreationSettings_GetMotionType(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetMotionType(settings);
        }

        public static void JPH_BodyCreationSettings_SetMotionType(NativeHandle<JPH_BodyCreationSettings> settings, MotionType value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetMotionType(settings, value);
        }

        public static AllowedDOFs JPH_BodyCreationSettings_GetAllowedDOFs(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetAllowedDOFs(settings);
        }

        public static void JPH_BodyCreationSettings_SetAllowedDOFs(NativeHandle<JPH_BodyCreationSettings> settings, AllowedDOFs value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetAllowedDOFs(settings, value);
        }

        public static bool JPH_BodyCreationSettings_GetAllowDynamicOrKinematic(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetAllowDynamicOrKinematic(settings);
        }

        public static void JPH_BodyCreationSettings_SetAllowDynamicOrKinematic(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetAllowDynamicOrKinematic(settings, value);
        }
        public static bool JPH_BodyCreationSettings_GetIsSensor(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetIsSensor(settings);
        }

        public static void JPH_BodyCreationSettings_SetIsSensor(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetIsSensor(settings, value);
        }

        public static bool JPH_BodyCreationSettings_GetCollideKinematicVsNonDynamic(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetCollideKinematicVsNonDynamic(settings);
        }

        public static void JPH_BodyCreationSettings_SetCollideKinematicVsNonDynamic(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetCollideKinematicVsNonDynamic(settings, value);
        }

        public static bool JPH_BodyCreationSettings_GetUseManifoldReduction(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetUseManifoldReduction(settings);
        }

        public static void JPH_BodyCreationSettings_SetUseManifoldReduction(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetUseManifoldReduction(settings, value);
        }

        public static bool JPH_BodyCreationSettings_GetApplyGyroscopicForce(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetApplyGyroscopicForce(settings);
        }

        public static void JPH_BodyCreationSettings_SetApplyGyroscopicForce(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetApplyGyroscopicForce(settings, value);
        }

        public static MotionQuality JPH_BodyCreationSettings_GetMotionQuality(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetMotionQuality(settings);
        }

        public static void JPH_BodyCreationSettings_SetMotionQuality(NativeHandle<JPH_BodyCreationSettings> settings, MotionQuality value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetMotionQuality(settings, value);
        }

        public static bool JPH_BodyCreationSettings_GetEnhancedInternalEdgeRemoval(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetEnhancedInternalEdgeRemoval(settings);
        }

        public static void JPH_BodyCreationSettings_SetEnhancedInternalEdgeRemoval(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetEnhancedInternalEdgeRemoval(settings, value);
        }

        public static bool JPH_BodyCreationSettings_GetAllowSleeping(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetAllowSleeping(settings);
        }

        public static void JPH_BodyCreationSettings_SetAllowSleeping(NativeHandle<JPH_BodyCreationSettings> settings, bool value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetAllowSleeping(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetFriction(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetFriction(settings);
        }

        public static void JPH_BodyCreationSettings_SetFriction(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetFriction(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetRestitution(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetRestitution(settings);
        }

        public static void JPH_BodyCreationSettings_SetRestitution(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetRestitution(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetLinearDamping(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetLinearDamping(settings);
        }

        public static void JPH_BodyCreationSettings_SetLinearDamping(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetLinearDamping(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetAngularDamping(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetAngularDamping(settings);
        }

        public static void JPH_BodyCreationSettings_SetAngularDamping(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetAngularDamping(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetMaxLinearVelocity(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetMaxLinearVelocity(settings);
        }

        public static void JPH_BodyCreationSettings_SetMaxLinearVelocity(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetMaxLinearVelocity(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetMaxAngularVelocity(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetMaxAngularVelocity(settings);
        }

        public static void JPH_BodyCreationSettings_SetMaxAngularVelocity(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetMaxAngularVelocity(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetGravityFactor(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetGravityFactor(settings);
        }

        public static void JPH_BodyCreationSettings_SetGravityFactor(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetGravityFactor(settings, value);
        }

        public static uint JPH_BodyCreationSettings_GetNumVelocityStepsOverride(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetNumVelocityStepsOverride(settings);
        }

        public static void JPH_BodyCreationSettings_SetNumVelocityStepsOverride(NativeHandle<JPH_BodyCreationSettings> settings, uint value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetNumVelocityStepsOverride(settings, value);
        }

        public static uint JPH_BodyCreationSettings_GetNumPositionStepsOverride(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetNumPositionStepsOverride(settings);
        }

        public static void JPH_BodyCreationSettings_SetNumPositionStepsOverride(NativeHandle<JPH_BodyCreationSettings> settings, uint value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetNumPositionStepsOverride(settings, value);
        }

        public static OverrideMassProperties JPH_BodyCreationSettings_GetOverrideMassProperties(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetOverrideMassProperties(settings);
        }

        public static void JPH_BodyCreationSettings_SetOverrideMassProperties(NativeHandle<JPH_BodyCreationSettings> settings, OverrideMassProperties value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetOverrideMassProperties(settings, value);
        }

        public static float JPH_BodyCreationSettings_GetInertiaMultiplier(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            return UnsafeBindings.JPH_BodyCreationSettings_GetInertiaMultiplier(settings);
        }

        public static void JPH_BodyCreationSettings_SetInertiaMultiplier(NativeHandle<JPH_BodyCreationSettings> settings, float value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetInertiaMultiplier(settings, value);
        }

        public static MassProperties JPH_BodyCreationSettings_GetMassPropertiesOverride(NativeHandle<JPH_BodyCreationSettings> settings)
        {
            var massProperties = new MassProperties();
            UnsafeBindings.JPH_BodyCreationSettings_GetMassPropertiesOverride(settings, &massProperties);

            return massProperties;
        }

        public static void JPH_BodyCreationSettings_SetMassPropertiesOVerride(NativeHandle<JPH_BodyCreationSettings> settings, MassProperties value)
        {
            UnsafeBindings.JPH_BodyCreationSettings_SetMassPropertiesOverride(settings, &value);
        }
    }
}
