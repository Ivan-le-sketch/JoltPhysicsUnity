﻿using System;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_PhysicsSystem> JPH_PhysicsSystem_Create(PhysicsSystemSettings settings)
        {
            // TODO use marshalling instead of recreating native settings

            var nativeSettings = new JPH_PhysicsSystemSettings
            {
                maxBodies = settings.MaxBodies,
                numBodyMutexes = settings.NumBodyMutexes,
                maxBodyPairs = settings.MaxBodyPairs,
                maxContactConstraints = settings.MaxContactConstraints,
                objectLayerPairFilter = settings.ObjectLayerPairFilter.Handle,
                broadPhaseLayerInterface = settings.BroadPhaseLayerInterface.Handle,
                objectVsBroadPhaseLayerFilter = settings.ObjectVsBroadPhaseLayerFilter.Handle
            };

            return CreateHandle(UnsafeBindings.JPH_PhysicsSystem_Create(&nativeSettings));
        }

        public static void JPH_PhysicsSystem_Destroy(NativeHandle<JPH_PhysicsSystem> system)
        {
            if (system.HasUser()) return;

            UnsafeBindings.JPH_PhysicsSystem_Destroy(system);

            system.Dispose();
        }

        public static PhysicsSettings JPH_PhysicsSystem_GetPhysicsSettings(NativeHandle<JPH_PhysicsSystem> system)
        {
            PhysicsSettings settings;

            UnsafeBindings.JPH_PhysicsSystem_GetPhysicsSettings(system, &settings);

            return settings;
        }

        public static void JPH_PhysicsSystem_SetPhysicsSettings(NativeHandle<JPH_PhysicsSystem> system, PhysicsSettings settings)
        {
            UnsafeBindings.JPH_PhysicsSystem_SetPhysicsSettings(system, &settings);
        }

        public static void JPH_PhysicsSystem_OptimizeBroadPhase(NativeHandle<JPH_PhysicsSystem> system)
        {
            UnsafeBindings.JPH_PhysicsSystem_OptimizeBroadPhase(system);
        }

        public static PhysicsUpdateError JPH_PhysicsSystem_Update(NativeHandle<JPH_PhysicsSystem> system, float deltaTime, int collisionSteps, NativeHandle<JPH_JobSystem> jobSystem)
        {
            return UnsafeBindings.JPH_PhysicsSystem_Update(system, deltaTime, collisionSteps, jobSystem);
        }

        // JPH_PhysicsSystem_Step excluded, does same thing as JPH_PhysicsSystem_Update

        public static NativeHandle<JPH_BodyInterface> JPH_PhysicsSystem_GetBodyInterface(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateOwnedHandle(system, UnsafeBindings.JPH_PhysicsSystem_GetBodyInterface(system));
        }

        public static NativeHandle<JPH_BodyInterface> JPH_PhysicsSystem_GetBodyInterfaceNoLock(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateOwnedHandle(system, UnsafeBindings.JPH_PhysicsSystem_GetBodyInterfaceNoLock(system));
        }

        public static NativeHandle<JPH_BodyLockInterface> JPH_PhysicsSystem_GetBodyLockInterface(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateOwnedHandle(system, UnsafeBindings.JPH_PhysicsSystem_GetBodyLockInterface(system));
        }

        public static NativeHandle<JPH_BodyLockInterface> JPH_PhysicsSystem_GetBodyLockInterfaceNoLock(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateOwnedHandle(system, UnsafeBindings.JPH_PhysicsSystem_GetBodyLockInterfaceNoLock(system));
        }

        public static NativeHandle<JPH_BroadPhaseQuery> JPH_PhysicsSystem_GetBroadPhaseQuery(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateHandle(UnsafeBindings.JPH_PhysicsSystem_GetBroadPhaseQuery(system));
        }

        public static NativeHandle<JPH_NarrowPhaseQuery> JPH_PhysicsSystem_GetNarrowPhaseQuery(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateOwnedHandle(system, UnsafeBindings.JPH_PhysicsSystem_GetNarrowPhaseQuery(system));
        }

        public static NativeHandle<JPH_NarrowPhaseQuery> JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock(NativeHandle<JPH_PhysicsSystem> system)
        {
            return CreateOwnedHandle(system, UnsafeBindings.JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock(system));
        }

        public static void JPH_PhysicsSystem_SetContactListener(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_ContactListener> listener)
        {
            UnsafeBindings.JPH_PhysicsSystem_SetContactListener(system, listener);
        }

        public static void JPH_PhysicsSystem_SetBodyActivationListener(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_BodyActivationListener> listener)
        {
            UnsafeBindings.JPH_PhysicsSystem_SetBodyActivationListener(system, listener);
        }

        public static void JPH_PhysicsSystem_SetSimShapeFilter(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_SimShapeFilter> filter)
        {
            UnsafeBindings.JPH_PhysicsSystem_SetSimShapeFilter(system, filter);
        }

        public static bool JPH_PhysicsSystem_WereBodiesInContact(NativeHandle<JPH_PhysicsSystem> system, BodyID a, BodyID b)
        {
            return UnsafeBindings.JPH_PhysicsSystem_WereBodiesInContact(system, a, b);
        }

        public static uint JPH_PhysicsSystem_GetNumBodies(NativeHandle<JPH_PhysicsSystem> system)
        {
            return UnsafeBindings.JPH_PhysicsSystem_GetNumBodies(system);
        }

        public static uint JPH_PhysicsSystem_GetNumActiveBodies(NativeHandle<JPH_PhysicsSystem> system, BodyType type)
        {
            return UnsafeBindings.JPH_PhysicsSystem_GetNumActiveBodies(system, type);
        }

        public static uint JPH_PhysicsSystem_GetMaxBodies(NativeHandle<JPH_PhysicsSystem> system)
        {
            return UnsafeBindings.JPH_PhysicsSystem_GetMaxBodies(system);
        }

        public static uint JPH_PhysicsSystem_GetNumConstraints(NativeHandle<JPH_PhysicsSystem> system)
        {
            return UnsafeBindings.JPH_PhysicsSystem_GetMaxBodies(system);
        }
        
        public static void JPH_PhysicsSystem_SetGravity(NativeHandle<JPH_PhysicsSystem> system, float3 gravity)
        {
            UnsafeBindings.JPH_PhysicsSystem_SetGravity(system, &gravity);
        }

        public static float3 JPH_PhysicsSystem_GetGravity(NativeHandle<JPH_PhysicsSystem> system)
        {
            float3 gravity = default;

            UnsafeBindings.JPH_PhysicsSystem_GetGravity(system, &gravity);

            return gravity;
        }

        public static void JPH_PhysicsSystem_AddConstraint(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_Constraint> constraint)
        {
            UnsafeBindings.JPH_PhysicsSystem_AddConstraint(system, constraint);
        }

        public static void JPH_PhysicsSystem_RemoveConstraint(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_Constraint> constraint)
        {
            UnsafeBindings.JPH_PhysicsSystem_RemoveConstraint(system, constraint);
        }

        public static void JPH_PhysicsSystem_AddConstraints(NativeHandle<JPH_PhysicsSystem> system)
        {
            throw new NotImplementedException();
        }

        public static void JPH_PhysicsSystem_RemoveConstraints(NativeHandle<JPH_PhysicsSystem> system)
        {
            throw new NotImplementedException();
        }

        public static void JPH_PhysicsSystem_GetBodies(NativeHandle<JPH_PhysicsSystem> system)
        {
            throw new NotImplementedException();
        }

        public static void JPH_PhysicsSystem_GetConstraints(NativeHandle<JPH_PhysicsSystem> system)
        {
            throw new NotImplementedException();
        }

        public static void JPH_PhysicsSystem_SaveState(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_StateRecorder> recorder, JPH_StateRecorderState state, NativeHandle<JPH_StateRecorderFilter> filter)
        {
            UnsafeBindings.JPH_PhysicsSystem_SaveState(system, recorder, state, filter);
        }

        public static bool JPH_PhysicsSystem_RestoreState(NativeHandle<JPH_PhysicsSystem> system, NativeHandle<JPH_StateRecorder> recorder, NativeHandle<JPH_StateRecorderFilter> filter)
        {
            return UnsafeBindings.JPH_PhysicsSystem_RestoreState(system, recorder, filter);
        }
    }
}
