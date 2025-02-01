using System;
using Unity.Mathematics;
using static Jolt.Bindings;

namespace Jolt
{
    public partial struct PhysicsSystem : IEquatable<PhysicsSystem>
    {
        internal readonly NativeHandle<JPH_PhysicsSystem> Handle;

        internal readonly NativeHandle<JPH_JobSystem> JobSystemHandle;

        /// <summary>
        /// The ObjectLayerPairFilter of the system.
        /// </summary>
        public ObjectLayerPairFilter ObjectLayerPairFilter;

        /// <summary>
        /// The BroadPhaseLayerInterface of the system.
        /// </summary>
        public BroadPhaseLayerInterface BroadPhaseLayerInterface;

        /// <summary>
        /// The ObjectVsBroadPhaseLayerFilter of the system.
        /// </summary>
        public ObjectVsBroadPhaseLayerFilter ObjectVsBroadPhaseLayerFilter;

        public PhysicsSystem(PhysicsSystemSettings settings)
        {
            Handle = JPH_PhysicsSystem_Create(settings);

            JobSystemHandle = JPH_JobSystemThreadingPool_Create();

            ObjectLayerPairFilter = settings.ObjectLayerPairFilter;

            BroadPhaseLayerInterface = settings.BroadPhaseLayerInterface;

            ObjectVsBroadPhaseLayerFilter = settings.ObjectVsBroadPhaseLayerFilter;

            var physicsSettings = JPH_PhysicsSystem_GetPhysicsSettings(Handle);
            physicsSettings.numVelocitySteps = 6;

            JPH_PhysicsSystem_SetPhysicsSettings(Handle, physicsSettings);
        }

        /// <summary>
        /// Destroys the system.
        /// </summary>
        public void Destroy()
        {
            JPH_PhysicsSystem_Destroy(Handle);
        }

        /// <summary>
        /// Optimizes the broadphase. This method should be used with caution as it is quite expensive.
        /// </summary>
        public void OptimizeBroadPhase()
        {
            JPH_PhysicsSystem_OptimizeBroadPhase(Handle);
        }

        /// <summary>
        /// Gets the body interface, which allows creating and removing bodies and changing their properties.
        /// </summary>
        public BodyInterface GetBodyInterface()
        {
            return new BodyInterface(JPH_PhysicsSystem_GetBodyInterface(Handle));
        }

        /// <summary>
        /// Gets a non-locking version of the body interface. Use with great care!
        /// </summary>
        public BodyInterface GetBodyInterfaceNoLock()
        {
            return new BodyInterface(JPH_PhysicsSystem_GetBodyInterfaceNoLock(Handle));
        }

        /// <summary>
        /// Gets the body lock interface which gives access to the system bodies.
        /// </summary>
        /// <returns></returns>
        public BodyLockInterface GetBodyLockInterface()
        {
            return new BodyLockInterface(JPH_PhysicsSystem_GetBodyLockInterface(Handle));
        }

        /// <summary>
        /// Gets the narrow phase query.
        /// </summary>
        /// <returns></returns>
        public NarrowPhaseQuery GetNarrowPhaseQuery()
        {
            return new NarrowPhaseQuery(JPH_PhysicsSystem_GetNarrowPhaseQuery(Handle));
        }

        /// <summary>
        /// Sets the contact listener.
        /// </summary>
        /// <param name="listener"></param>
        public void SetContactListener(ContactListener listener)
        {
            JPH_PhysicsSystem_SetContactListener(Handle, listener.Handle);
        }

        public void SetBodyActivationListener(BodyActivationListener listener)
        {
            JPH_PhysicsSystem_SetBodyActivationListener(Handle, listener.Handle);
        }

        /// <summary>
        /// Update the physics system. Returns true if there were no errors.
        /// </summary>
        /// <remarks>
        /// The out parameter will contain the error if any.
        /// </remarks>
        public bool Update(float deltaTime, int collisionSteps, out PhysicsUpdateError error)
        {
            return (error = JPH_PhysicsSystem_Update(Handle, deltaTime, collisionSteps, JobSystemHandle)) == PhysicsUpdateError.None;
        }

        public bool WereBodiesInContact(BodyID a, BodyID b)
        {
            return JPH_PhysicsSystem_WereBodiesInContact(Handle, a, b);
        }
        
        /// <summary>
        /// Get the current number of bodies in the body manager.
        /// </summary>
        public uint GetNumBodies()
        {
            return JPH_PhysicsSystem_GetNumBodies(Handle);
        }

        /// <summary>
        /// Get the current number of active bodies in the body manager.
        /// </summary>
        public uint GetNumActiveBodies(BodyType type)
        {
            return JPH_PhysicsSystem_GetNumActiveBodies(Handle, type);
        }

        /// <summary>
        /// Get the maximum number of bodies that this system supports.
        /// </summary>
        public uint GetMaxBodies()
        {
            return JPH_PhysicsSystem_GetMaxBodies(Handle);
        }

        public uint GetNumConstraints()
        {
            return JPH_PhysicsSystem_GetNumConstraints(Handle);
        }

        public void SetGravity(float3 gravity)
        {
            JPH_PhysicsSystem_SetGravity(Handle, gravity);
        }

        public float3 GetGravity()
        {
            return JPH_PhysicsSystem_GetGravity(Handle);
        }

        public void AddConstraint(Constraint constraint)
        {
            JPH_PhysicsSystem_AddConstraint(Handle, constraint.Handle);
        }

        public void RemoveConstraint(Constraint constraint)
        {
            JPH_PhysicsSystem_RemoveConstraint(Handle, constraint.Handle);
        }

        public void SaveState(StateRecorder recorder, StateRecorderFilter filter)//, JPH_StateRecorderState state)
        {
            JPH_PhysicsSystem_SaveState(Handle, recorder.Handle, JPH_StateRecorderState.JPH_StateRecorderState_All, filter.Handle);
        }

        public bool RestoreState(StateRecorder recorder, StateRecorderFilter filter)
        {
            return JPH_PhysicsSystem_RestoreState(Handle, recorder.Handle, filter.Handle);
        }

        #region IEquatable

        public bool Equals(PhysicsSystem other) => Handle.Equals(other.Handle);

        public override bool Equals(object obj) => obj is PhysicsSystem other && Equals(other);

        public override int GetHashCode() => Handle.GetHashCode();

        public static bool operator ==(PhysicsSystem lhs, PhysicsSystem rhs) => lhs.Equals(rhs);

        public static bool operator !=(PhysicsSystem lhs, PhysicsSystem rhs) => !lhs.Equals(rhs);

        #endregion
    }
}
