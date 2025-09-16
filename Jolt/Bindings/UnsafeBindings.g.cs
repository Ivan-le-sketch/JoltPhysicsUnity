using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    internal partial struct JPH_BroadPhaseLayerInterface
    {
    }

    internal partial struct JPH_ObjectVsBroadPhaseLayerFilter
    {
    }

    internal partial struct JPH_ObjectLayerPairFilter
    {
    }

    internal partial struct JPH_BroadPhaseLayerFilter
    {
    }

    internal partial struct JPH_ObjectLayerFilter
    {
    }

    internal partial struct JPH_BodyFilter
    {
    }

    internal partial struct JPH_IgnoreSingleBodyFilter
    {
    }

    internal partial struct JPH_IgnoreMultipleBodiesFilter
    {
    }

    internal partial struct JPH_ShapeFilter
    {
    }

    internal partial struct JPH_SimShapeFilter
    {
    }

    internal partial struct JPH_PhysicsSystem
    {
    }

    internal partial struct JPH_PhysicsMaterial
    {
    }

    internal partial struct JPH_ShapeSettings
    {
    }

    internal partial struct JPH_ConvexShapeSettings
    {
    }

    internal partial struct JPH_SphereShapeSettings
    {
    }

    internal partial struct JPH_BoxShapeSettings
    {
    }

    internal partial struct JPH_PlaneShapeSettings
    {
    }

    internal partial struct JPH_TriangleShapeSettings
    {
    }

    internal partial struct JPH_CapsuleShapeSettings
    {
    }

    internal partial struct JPH_TaperedCapsuleShapeSettings
    {
    }

    internal partial struct JPH_CylinderShapeSettings
    {
    }

    internal partial struct JPH_TaperedCylinderShapeSettings
    {
    }

    internal partial struct JPH_ConvexHullShapeSettings
    {
    }

    internal partial struct JPH_CompoundShapeSettings
    {
    }

    internal partial struct JPH_StaticCompoundShapeSettings
    {
    }

    internal partial struct JPH_MutableCompoundShapeSettings
    {
    }

    internal partial struct JPH_MeshShapeSettings
    {
    }

    internal partial struct JPH_HeightFieldShapeSettings
    {
    }

    internal partial struct JPH_RotatedTranslatedShapeSettings
    {
    }

    internal partial struct JPH_ScaledShapeSettings
    {
    }

    internal partial struct JPH_OffsetCenterOfMassShapeSettings
    {
    }

    internal partial struct JPH_EmptyShapeSettings
    {
    }

    internal partial struct JPH_Shape
    {
    }

    internal partial struct JPH_ConvexShape
    {
    }

    internal partial struct JPH_SphereShape
    {
    }

    internal partial struct JPH_BoxShape
    {
    }

    internal partial struct JPH_PlaneShape
    {
    }

    internal partial struct JPH_CapsuleShape
    {
    }

    internal partial struct JPH_CylinderShape
    {
    }

    internal partial struct JPH_TaperedCylinderShape
    {
    }

    internal partial struct JPH_TriangleShape
    {
    }

    internal partial struct JPH_TaperedCapsuleShape
    {
    }

    internal partial struct JPH_ConvexHullShape
    {
    }

    internal partial struct JPH_CompoundShape
    {
    }

    internal partial struct JPH_StaticCompoundShape
    {
    }

    internal partial struct JPH_MutableCompoundShape
    {
    }

    internal partial struct JPH_MeshShape
    {
    }

    internal partial struct JPH_HeightFieldShape
    {
    }

    internal partial struct JPH_DecoratedShape
    {
    }

    internal partial struct JPH_RotatedTranslatedShape
    {
    }

    internal partial struct JPH_ScaledShape
    {
    }

    internal partial struct JPH_OffsetCenterOfMassShape
    {
    }

    internal partial struct JPH_EmptyShape
    {
    }

    internal partial struct JPH_BodyCreationSettings
    {
    }

    internal partial struct JPH_SoftBodyCreationSettings
    {
    }

    internal partial struct JPH_BodyInterface
    {
    }

    internal partial struct JPH_BodyLockInterface
    {
    }

    internal partial struct JPH_BroadPhaseQuery
    {
    }

    internal partial struct JPH_NarrowPhaseQuery
    {
    }

    internal partial struct JPH_MotionProperties
    {
    }

    internal partial struct JPH_Body
    {
    }

    internal partial struct JPH_ContactListener
    {
    }

    internal partial struct JPH_ContactManifold
    {
    }

    internal partial struct JPH_ContactSettings
    {
    }

    internal partial struct JPH_GroupFilter
    {
    }

    internal partial struct JPH_GroupFilterTable
    {
    }

    internal partial struct JPH_WheelSettingsWV
    {
    }

    internal partial struct JPH_WheelWV
    {
    }

    internal partial struct JPH_VehicleEngineSettings
    {
    }

    internal partial struct JPH_VehicleTransmissionSettings
    {
    }

    internal partial struct JPH_VehicleCollisionTester
    {
    }

    internal partial struct JPH_VehicleCollisionTesterRay
    {
    }

    internal partial struct JPH_VehicleCollisionTesterCastSphere
    {
    }

    internal partial struct JPH_VehicleCollisionTesterCastCylinder
    {
    }

    internal partial struct JPH_VehicleConstraintSettings
    {
    }

    internal partial struct JPH_VehicleConstraint
    {
    }

    internal partial struct JPH_VehicleControllerSettings
    {
    }

    internal partial struct JPH_WheeledVehicleControllerSettings
    {
    }

    internal partial struct JPH_WheeledVehicleController
    {
    }

    internal partial struct JPH_PhysicsStepListener
    {
    }

    internal enum JPH_SoftBodyConstraintColor
    {
        JPH_SoftBodyConstraintColor_ConstraintType,
        JPH_SoftBodyConstraintColor_ConstraintGroup,
        JPH_SoftBodyConstraintColor_ConstraintOrder,
        _JPH_SoftBodyConstraintColor_Count,
        _JPH_SoftBodyConstraintColor_Force32 = 0x7FFFFFFF,
    }

    internal enum JPH_BodyManager_ShapeColor
    {
        JPH_BodyManager_ShapeColor_InstanceColor,
        JPH_BodyManager_ShapeColor_ShapeTypeColor,
        JPH_BodyManager_ShapeColor_MotionTypeColor,
        JPH_BodyManager_ShapeColor_SleepColor,
        JPH_BodyManager_ShapeColor_IslandColor,
        JPH_BodyManager_ShapeColor_MaterialColor,
        _JPH_BodyManager_ShapeColor_Count,
        _JPH_BodyManager_ShapeColor_Force32 = 0x7FFFFFFF,
    }

    internal enum JPH_DebugRenderer_CastShadow
    {
        JPH_DebugRenderer_CastShadow_On = 0,
        JPH_DebugRenderer_CastShadow_Off = 1,
        _JPH_DebugRenderer_CastShadow_Count,
        _JPH_DebugRenderer_CastShadow_Force32 = 0x7FFFFFFF,
    }

    internal enum JPH_DebugRenderer_DrawMode
    {
        JPH_DebugRenderer_DrawMode_Solid = 0,
        JPH_DebugRenderer_DrawMode_Wireframe = 1,
        _JPH_DebugRenderer_DrawMode_Count,
        _JPH_DebugRenderer_DrawMode_Force32 = 0x7FFFFFFF,
    }

    internal enum JPH_Mesh_Shape_BuildQuality
    {
        JPH_Mesh_Shape_BuildQuality_FavorRuntimePerformance = 0,
        JPH_Mesh_Shape_BuildQuality_FavorBuildSpeed = 1,
        _JPH_Mesh_Shape_BuildQuality_Count,
        _JPH_Mesh_Shape_BuildQuality_Force32 = 0x7FFFFFFF,
    }

    internal enum JPH_TransmissionMode
    {
        JPH_TransmissionMode_Auto = 0,
        JPH_TransmissionMode_Manual = 1,
        _JPH_TransmissionMode_Count,
        _JPH_TransmissionMode_Force32 = 0x7FFFFFFF,
    }

    [NativeTypeName("uint8_t")]
    internal enum JPH_StateRecorderState : byte
    {
        JPH_StateRecorderState_None = 0,
        JPH_StateRecorderState_Global = 1,
        JPH_StateRecorderState_Bodies = 2,
        JPH_StateRecorderState_Contacts = 4,
        JPH_StateRecorderState_Constraints = 8,
        JPH_StateRecorderState_All = JPH_StateRecorderState_Global | JPH_StateRecorderState_Bodies | JPH_StateRecorderState_Contacts | JPH_StateRecorderState_Constraints,
    }

    internal partial struct JPH_DrawSettings
    {
        [NativeTypeName("bool")]
        public NativeBool drawGetSupportFunction;

        [NativeTypeName("bool")]
        public NativeBool drawSupportDirection;

        [NativeTypeName("bool")]
        public NativeBool drawGetSupportingFace;

        [NativeTypeName("bool")]
        public NativeBool drawShape;

        [NativeTypeName("bool")]
        public NativeBool drawShapeWireframe;

        public JPH_BodyManager_ShapeColor drawShapeColor;

        [NativeTypeName("bool")]
        public NativeBool drawBoundingBox;

        [NativeTypeName("bool")]
        public NativeBool drawCenterOfMassTransform;

        [NativeTypeName("bool")]
        public NativeBool drawWorldTransform;

        [NativeTypeName("bool")]
        public NativeBool drawVelocity;

        [NativeTypeName("bool")]
        public NativeBool drawMassAndInertia;

        [NativeTypeName("bool")]
        public NativeBool drawSleepStats;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyVertices;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyVertexVelocities;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyEdgeConstraints;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyBendConstraints;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyVolumeConstraints;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodySkinConstraints;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyLRAConstraints;

        [NativeTypeName("bool")]
        public NativeBool drawSoftBodyPredictedBounds;

        public JPH_SoftBodyConstraintColor drawSoftBodyConstraintColor;
    }

    internal partial struct JPH_SupportingFace
    {
        public uint count;

        [NativeTypeName("JPH_Vec3[32]")]
        public _vertices_e__FixedBuffer vertices;

        public partial struct _vertices_e__FixedBuffer
        {
            public float3 e0;
            public float3 e1;
            public float3 e2;
            public float3 e3;
            public float3 e4;
            public float3 e5;
            public float3 e6;
            public float3 e7;
            public float3 e8;
            public float3 e9;
            public float3 e10;
            public float3 e11;
            public float3 e12;
            public float3 e13;
            public float3 e14;
            public float3 e15;
            public float3 e16;
            public float3 e17;
            public float3 e18;
            public float3 e19;
            public float3 e20;
            public float3 e21;
            public float3 e22;
            public float3 e23;
            public float3 e24;
            public float3 e25;
            public float3 e26;
            public float3 e27;
            public float3 e28;
            public float3 e29;
            public float3 e30;
            public float3 e31;

            public unsafe ref float3 this[int index]
            {
                get
                {
                    fixed (float3* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    internal unsafe partial struct JPH_CollisionGroup
    {
        [NativeTypeName("const JPH_GroupFilter *")]
        public JPH_GroupFilter* groupFilter;

        [NativeTypeName("JPH_CollisionGroupID")]
        public uint groupID;

        [NativeTypeName("JPH_CollisionSubGroupID")]
        public uint subGroupID;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_CastRayResultCallback(void* context, [NativeTypeName("const JPH_RayCastResult *")] RayCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_RayCastBodyResultCallback(void* context, [NativeTypeName("const JPH_BroadPhaseCastResult *")] BroadPhaseCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_CollideShapeBodyResultCallback(void* context, [NativeTypeName("const JPH_BodyID")] BodyID result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_CollidePointResultCallback(void* context, [NativeTypeName("const JPH_CollidePointResult *")] CollidePointResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_CollideShapeResultCallback(void* context, [NativeTypeName("const JPH_CollideShapeResult *")] CollideShapeResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_CastShapeResultCallback(void* context, [NativeTypeName("const JPH_ShapeCastResult *")] ShapeCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CastRayCollectorCallback(void* context, [NativeTypeName("const JPH_RayCastResult *")] RayCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_RayCastBodyCollectorCallback(void* context, [NativeTypeName("const JPH_BroadPhaseCastResult *")] BroadPhaseCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CollideShapeBodyCollectorCallback(void* context, [NativeTypeName("const JPH_BodyID")] BodyID result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CollidePointCollectorCallback(void* context, [NativeTypeName("const JPH_CollidePointResult *")] CollidePointResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CollideShapeCollectorCallback(void* context, [NativeTypeName("const JPH_CollideShapeResult *")] CollideShapeResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CastShapeCollectorCallback(void* context, [NativeTypeName("const JPH_ShapeCastResult *")] ShapeCastResult* result);

    internal partial struct JPH_BodyActivationListener
    {
    }

    internal partial struct JPH_BodyDrawFilter
    {
    }

    internal partial struct JPH_SharedMutex
    {
    }

    internal partial struct JPH_DebugRenderer
    {
    }

    internal partial struct JPH_Constraint
    {
    }

    internal partial struct JPH_TwoBodyConstraint
    {
    }

    internal partial struct JPH_FixedConstraint
    {
    }

    internal partial struct JPH_DistanceConstraint
    {
    }

    internal partial struct JPH_PointConstraint
    {
    }

    internal partial struct JPH_HingeConstraint
    {
    }

    internal partial struct JPH_SliderConstraint
    {
    }

    internal partial struct JPH_ConeConstraint
    {
    }

    internal partial struct JPH_SwingTwistConstraint
    {
    }

    internal partial struct JPH_SixDOFConstraint
    {
    }

    internal partial struct JPH_GearConstraint
    {
    }

    internal partial struct JPH_StateRecorder
    {
    }

    internal partial struct JPH_StateRecorderFilter
    {
    }

    internal partial struct JPH_CharacterBase
    {
    }

    internal partial struct JPH_Character
    {
    }

    internal partial struct JPH_CharacterVirtual
    {
    }

    internal partial struct JPH_CharacterContactListener
    {
    }

    internal partial struct JPH_CharacterVsCharacterCollision
    {
    }

    internal partial struct JPH_Skeleton
    {
    }

    internal partial struct JPH_RagdollSettings
    {
    }

    internal partial struct JPH_Ragdoll
    {
    }

    internal unsafe partial struct JPH_BodyLockRead
    {
        [NativeTypeName("const JPH_BodyLockInterface *")]
        public JPH_BodyLockInterface* lockInterface;

        public JPH_SharedMutex* mutex;

        [NativeTypeName("const JPH_Body *")]
        public JPH_Body* body;
    }

    internal unsafe partial struct JPH_BodyLockWrite
    {
        [NativeTypeName("const JPH_BodyLockInterface *")]
        public JPH_BodyLockInterface* lockInterface;

        public JPH_SharedMutex* mutex;

        public JPH_Body* body;
    }

    internal partial struct JPH_BodyLockMultiRead
    {
    }

    internal partial struct JPH_BodyLockMultiWrite
    {
    }

    internal unsafe partial struct JPH_CharacterBaseSettings
    {
        [NativeTypeName("JPH_Vec3")]
        public float3 up;

        [NativeTypeName("JPH_Plane")]
        public Plane supportingVolume;

        public float maxSlopeAngle;

        [NativeTypeName("bool")]
        public NativeBool enhancedInternalEdgeRemoval;

        [NativeTypeName("const JPH_Shape *")]
        public JPH_Shape* shape;
    }

    internal partial struct JPH_CharacterSettings
    {
        public JPH_CharacterBaseSettings @base;

        [NativeTypeName("JPH_ObjectLayer")]
        public ObjectLayer layer;

        public float mass;

        public float friction;

        public float gravityFactor;

        [NativeTypeName("JPH_AllowedDOFs")]
        public AllowedDOFs allowedDOFs;
    }

    internal unsafe partial struct JPH_CharacterVirtualSettings
    {
        public JPH_CharacterBaseSettings @base;

        [NativeTypeName("JPH_CharacterID")]
        public uint ID;

        public float mass;

        public float maxStrength;

        [NativeTypeName("JPH_Vec3")]
        public float3 shapeOffset;

        [NativeTypeName("JPH_BackFaceMode")]
        public BackFaceMode backFaceMode;

        public float predictiveContactDistance;

        public uint maxCollisionIterations;

        public uint maxConstraintIterations;

        public float minTimeRemaining;

        public float collisionTolerance;

        public float characterPadding;

        public uint maxNumHits;

        public float hitReductionCosMaxAngle;

        public float penetrationRecoverySpeed;

        [NativeTypeName("const JPH_Shape *")]
        public JPH_Shape* innerBodyShape;

        [NativeTypeName("JPH_BodyID")]
        public BodyID innerBodyIDOverride;

        [NativeTypeName("JPH_ObjectLayer")]
        public ObjectLayer innerBodyLayer;
    }

    internal partial struct JPH_CharacterContactSettings
    {
        [NativeTypeName("bool")]
        public NativeBool canPushCharacter;

        [NativeTypeName("bool")]
        public NativeBool canReceiveImpulses;
    }

    internal unsafe partial struct JPH_CharacterVirtualContact
    {
        [NativeTypeName("uint64_t")]
        public ulong hash;

        [NativeTypeName("JPH_BodyID")]
        public BodyID bodyB;

        [NativeTypeName("JPH_CharacterID")]
        public uint characterIDB;

        [NativeTypeName("JPH_SubShapeID")]
        public SubShapeID subShapeIDB;

        [NativeTypeName("JPH_RVec3")]
        public rvec3 position;

        [NativeTypeName("JPH_Vec3")]
        public float3 linearVelocity;

        [NativeTypeName("JPH_Vec3")]
        public float3 contactNormal;

        [NativeTypeName("JPH_Vec3")]
        public float3 surfaceNormal;

        public float distance;

        public float fraction;

        [NativeTypeName("JPH_MotionType")]
        public MotionType motionTypeB;

        [NativeTypeName("bool")]
        public NativeBool isSensorB;

        [NativeTypeName("const JPH_CharacterVirtual *")]
        public JPH_CharacterVirtual* characterB;

        [NativeTypeName("uint64_t")]
        public ulong userData;

        [NativeTypeName("const JPH_PhysicsMaterial *")]
        public JPH_PhysicsMaterial* material;

        [NativeTypeName("bool")]
        public NativeBool hadCollision;

        [NativeTypeName("bool")]
        public NativeBool wasDiscarded;

        [NativeTypeName("bool")]
        public NativeBool canPushCharacter;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_TraceFunc([NativeTypeName("const char *")] sbyte* mssage);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("bool")]
    internal unsafe delegate NativeBool JPH_AssertFailureFunc([NativeTypeName("const char *")] sbyte* expression, [NativeTypeName("const char *")] sbyte* mssage, [NativeTypeName("const char *")] sbyte* file, uint line);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_JobFunction(void* arg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_QueueJobCallback(void* context, [NativeTypeName("JPH_JobFunction *")] IntPtr job, void* arg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void JPH_QueueJobsCallback(void* context, [NativeTypeName("JPH_JobFunction *")] IntPtr job, void** args, uint count);

    internal partial struct JobSystemThreadPoolConfig
    {
        public uint maxJobs;

        public uint maxBarriers;

        [NativeTypeName("int32_t")]
        public int numThreads;
    }

    internal unsafe partial struct JPH_JobSystemConfig
    {
        public void* context;

        [NativeTypeName("JPH_QueueJobCallback *")]
        public IntPtr queueJob;

        [NativeTypeName("JPH_QueueJobsCallback *")]
        public IntPtr queueJobs;

        public uint maxConcurrency;

        public uint maxBarriers;
    }

    internal partial struct JPH_JobSystem
    {
    }

    internal unsafe partial struct JPH_PhysicsSystemSettings
    {
        public uint maxBodies;

        public uint numBodyMutexes;

        public uint maxBodyPairs;

        public uint maxContactConstraints;

        public uint _padding;

        public JPH_BroadPhaseLayerInterface* broadPhaseLayerInterface;

        public JPH_ObjectLayerPairFilter* objectLayerPairFilter;

        public JPH_ObjectVsBroadPhaseLayerFilter* objectVsBroadPhaseLayerFilter;
    }

    internal partial struct JPH_ShapeFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, const JPH_Shape *, const JPH_SubShapeID *) __attribute__((cdecl))")]
        public IntPtr ShouldCollide;

        [NativeTypeName("bool (*)(void *, const JPH_Shape *, const JPH_SubShapeID *, const JPH_Shape *, const JPH_SubShapeID *) __attribute__((cdecl))")]
        public IntPtr ShouldCollide2;
    }

    internal partial struct JPH_SimShapeFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, const JPH_Body *, const JPH_Shape *, const JPH_SubShapeID *, const JPH_Body *, const JPH_Shape *, const JPH_SubShapeID *) __attribute__((cdecl))")]
        public IntPtr ShouldCollide;
    }

    internal partial struct JPH_ContactListener_Procs
    {
        [NativeTypeName("JPH_ValidateResult (*)(void *, const JPH_Body *, const JPH_Body *, const JPH_RVec3 *, const JPH_CollideShapeResult *) __attribute__((cdecl))")]
        public IntPtr OnContactValidate;

        [NativeTypeName("void (*)(void *, const JPH_Body *, const JPH_Body *, const JPH_ContactManifold *, JPH_ContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnContactAdded;

        [NativeTypeName("void (*)(void *, const JPH_Body *, const JPH_Body *, const JPH_ContactManifold *, JPH_ContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnContactPersisted;

        [NativeTypeName("void (*)(void *, const JPH_SubShapeIDPair *) __attribute__((cdecl))")]
        public IntPtr OnContactRemoved;
    }

    internal partial struct JPH_BodyActivationListener_Procs
    {
        [NativeTypeName("void (*)(void *, JPH_BodyID, uint64_t) __attribute__((cdecl))")]
        public IntPtr OnBodyActivated;

        [NativeTypeName("void (*)(void *, JPH_BodyID, uint64_t) __attribute__((cdecl))")]
        public IntPtr OnBodyDeactivated;
    }

    internal partial struct JPH_BodyDrawFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, const JPH_Body *) __attribute__((cdecl))")]
        public IntPtr ShouldDraw;
    }

    internal partial struct JPH_CharacterContactListener_Procs
    {
        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_Body *, JPH_Vec3 *, JPH_Vec3 *) __attribute__((cdecl))")]
        public IntPtr OnAdjustBodyVelocity;

        [NativeTypeName("bool (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID) __attribute__((cdecl))")]
        public IntPtr OnContactValidate;

        [NativeTypeName("bool (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactValidate;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, JPH_CharacterContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnContactAdded;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, JPH_CharacterContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnContactPersisted;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID) __attribute__((cdecl))")]
        public IntPtr OnContactRemoved;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, JPH_CharacterContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactAdded;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, JPH_CharacterContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactPersisted;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterID, const JPH_SubShapeID) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactRemoved;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, const JPH_Vec3 *, const JPH_PhysicsMaterial *, const JPH_Vec3 *, JPH_Vec3 *) __attribute__((cdecl))")]
        public IntPtr OnContactSolve;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, const JPH_Vec3 *, const JPH_PhysicsMaterial *, const JPH_Vec3 *, JPH_Vec3 *) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactSolve;
    }

    internal partial struct JPH_CharacterVsCharacterCollision_Procs
    {
        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_RMatrix4x4 *, const JPH_CollideShapeSettings *, const JPH_RVec3 *) __attribute__((cdecl))")]
        public IntPtr CollideCharacter;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_RMatrix4x4 *, const JPH_Vec3 *, const JPH_ShapeCastSettings *, const JPH_RVec3 *) __attribute__((cdecl))")]
        public IntPtr CastCharacter;
    }

    internal partial struct JPH_DebugRenderer_Procs
    {
        [NativeTypeName("void (*)(void *, const JPH_RVec3 *, const JPH_RVec3 *, JPH_Color) __attribute__((cdecl))")]
        public IntPtr DrawLine;

        [NativeTypeName("void (*)(void *, const JPH_RVec3 *, const JPH_RVec3 *, const JPH_RVec3 *, JPH_Color, JPH_DebugRenderer_CastShadow) __attribute__((cdecl))")]
        public IntPtr DrawTriangle;

        [NativeTypeName("void (*)(void *, const JPH_RVec3 *, const char *, JPH_Color, float) __attribute__((cdecl))")]
        public IntPtr DrawText3D;
    }

    internal unsafe partial struct JPH_SkeletonJoint
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* parentName;

        public int parentJointIndex;
    }

    internal partial struct JPH_StateRecorderFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, const JPH_Body *) __attribute__((cdecl))")]
        public IntPtr ShouldSaveBody;

        [NativeTypeName("bool (*)(void *, const JPH_Constraint *) __attribute__((cdecl))")]
        public IntPtr ShouldSaveConstraint;

        [NativeTypeName("bool (*)(void *, const JPH_BodyID, const JPH_BodyID) __attribute__((cdecl))")]
        public IntPtr ShouldSaveContact;

        [NativeTypeName("bool (*)(void *, const JPH_BodyID, const JPH_BodyID) __attribute__((cdecl))")]
        public IntPtr ShouldRestoreContact;
    }

    internal static unsafe partial class UnsafeBindings
    {
        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_JobSystem* JPH_JobSystemThreadPool_Create([NativeTypeName("const JobSystemThreadPoolConfig *")] JobSystemThreadPoolConfig* config);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_JobSystem* JPH_JobSystemCallback_Create([NativeTypeName("const JPH_JobSystemConfig *")] JPH_JobSystemConfig* config);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_JobSystem_Destroy(JPH_JobSystem* jobSystem);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Init();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shutdown();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SetTraceHandler([NativeTypeName("JPH_TraceFunc")] IntPtr handler);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SetAssertFailureHandler([NativeTypeName("JPH_AssertFailureFunc")] IntPtr handler);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CollideShapeResult_FreeMembers([NativeTypeName("JPH_CollideShapeResult *")] CollideShapeResult* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CollisionEstimationResult_FreeMembers([NativeTypeName("JPH_CollisionEstimationResult *")] CollisionEstimationResult* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BroadPhaseLayerInterface* JPH_BroadPhaseLayerInterfaceMask_Create(uint numBroadPhaseLayers);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer(JPH_BroadPhaseLayerInterface* bpInterface, [NativeTypeName("JPH_BroadPhaseLayer")] BroadPhaseLayer broadPhaseLayer, uint groupsToInclude, uint groupsToExclude);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BroadPhaseLayerInterface* JPH_BroadPhaseLayerInterfaceTable_Create(uint numObjectLayers, uint numBroadPhaseLayers);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer(JPH_BroadPhaseLayerInterface* bpInterface, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer objectLayer, [NativeTypeName("JPH_BroadPhaseLayer")] BroadPhaseLayer broadPhaseLayer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectLayerPairFilter* JPH_ObjectLayerPairFilterMask_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ObjectLayer")]
        public static extern ObjectLayer JPH_ObjectLayerPairFilterMask_GetObjectLayer(uint group, uint mask);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ObjectLayerPairFilterMask_GetGroup([NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ObjectLayerPairFilterMask_GetMask([NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectLayerPairFilter* JPH_ObjectLayerPairFilterTable_Create(uint numObjectLayers);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ObjectLayerPairFilterTable_DisableCollision(JPH_ObjectLayerPairFilter* objectFilter, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer1, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ObjectLayerPairFilterTable_EnableCollision(JPH_ObjectLayerPairFilter* objectFilter, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer1, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_ObjectLayerPairFilterTable_ShouldCollide(JPH_ObjectLayerPairFilter* objectFilter, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer1, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectVsBroadPhaseLayerFilter* JPH_ObjectVsBroadPhaseLayerFilterMask_Create([NativeTypeName("const JPH_BroadPhaseLayerInterface *")] JPH_BroadPhaseLayerInterface* broadPhaseLayerInterface);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectVsBroadPhaseLayerFilter* JPH_ObjectVsBroadPhaseLayerFilterTable_Create(JPH_BroadPhaseLayerInterface* broadPhaseLayerInterface, uint numBroadPhaseLayers, JPH_ObjectLayerPairFilter* objectLayerPairFilter, uint numObjectLayers);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DrawSettings_InitDefault(JPH_DrawSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PhysicsSystem* JPH_PhysicsSystem_Create([NativeTypeName("const JPH_PhysicsSystemSettings *")] JPH_PhysicsSystemSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_Destroy(JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_SetPhysicsSettings(JPH_PhysicsSystem* system, [NativeTypeName("JPH_PhysicsSettings *")] PhysicsSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_GetPhysicsSettings(JPH_PhysicsSystem* system, [NativeTypeName("JPH_PhysicsSettings *")] PhysicsSettings* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_OptimizeBroadPhase(JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_PhysicsUpdateError")]
        public static extern PhysicsUpdateError JPH_PhysicsSystem_Update(JPH_PhysicsSystem* system, float deltaTime, int collisionSteps, JPH_JobSystem* jobSystem);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyInterface* JPH_PhysicsSystem_GetBodyInterface(JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyInterface* JPH_PhysicsSystem_GetBodyInterfaceNoLock(JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_BodyLockInterface *")]
        public static extern JPH_BodyLockInterface* JPH_PhysicsSystem_GetBodyLockInterface([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_BodyLockInterface *")]
        public static extern JPH_BodyLockInterface* JPH_PhysicsSystem_GetBodyLockInterfaceNoLock([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_BroadPhaseQuery *")]
        public static extern JPH_BroadPhaseQuery* JPH_PhysicsSystem_GetBroadPhaseQuery([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_NarrowPhaseQuery *")]
        public static extern JPH_NarrowPhaseQuery* JPH_PhysicsSystem_GetNarrowPhaseQuery([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_NarrowPhaseQuery *")]
        public static extern JPH_NarrowPhaseQuery* JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_SetContactListener(JPH_PhysicsSystem* system, JPH_ContactListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_SetBodyActivationListener(JPH_PhysicsSystem* system, JPH_BodyActivationListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_SetSimShapeFilter(JPH_PhysicsSystem* system, JPH_SimShapeFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_PhysicsSystem_WereBodiesInContact([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system, [NativeTypeName("JPH_BodyID")] BodyID body1, [NativeTypeName("JPH_BodyID")] BodyID body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_PhysicsSystem_GetNumBodies([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_PhysicsSystem_GetNumActiveBodies([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system, [NativeTypeName("JPH_BodyType")] BodyType type);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_PhysicsSystem_GetMaxBodies([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_PhysicsSystem_GetNumConstraints([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_SetGravity(JPH_PhysicsSystem* system, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_GetGravity(JPH_PhysicsSystem* system, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_AddConstraint(JPH_PhysicsSystem* system, JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_RemoveConstraint(JPH_PhysicsSystem* system, JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_AddConstraints(JPH_PhysicsSystem* system, JPH_Constraint** constraints, uint count);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_RemoveConstraints(JPH_PhysicsSystem* system, JPH_Constraint** constraints, uint count);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_AddStepListener(JPH_PhysicsSystem* system, JPH_PhysicsStepListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_RemoveStepListener(JPH_PhysicsSystem* system, JPH_PhysicsStepListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_GetBodies([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system, [NativeTypeName("JPH_BodyID *")] BodyID* ids, uint count);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_GetConstraints([NativeTypeName("const JPH_PhysicsSystem *")] JPH_PhysicsSystem* system, [NativeTypeName("const JPH_Constraint **")] JPH_Constraint** constraints, uint count);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_SaveState(JPH_PhysicsSystem* system, JPH_StateRecorder* recorder, JPH_StateRecorderState state, [NativeTypeName("const JPH_StateRecorderFilter *")] JPH_StateRecorderFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_PhysicsSystem_RestoreState(JPH_PhysicsSystem* system, JPH_StateRecorder* recorder, [NativeTypeName("const JPH_StateRecorderFilter *")] JPH_StateRecorderFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_DrawBodies(JPH_PhysicsSystem* system, [NativeTypeName("const JPH_DrawSettings *")] JPH_DrawSettings* settings, JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_BodyDrawFilter *")] JPH_BodyDrawFilter* bodyFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_DrawConstraints(JPH_PhysicsSystem* system, JPH_DebugRenderer* renderer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_DrawConstraintLimits(JPH_PhysicsSystem* system, JPH_DebugRenderer* renderer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_DrawConstraintReferenceFrame(JPH_PhysicsSystem* system, JPH_DebugRenderer* renderer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quaternion_FromTo([NativeTypeName("const JPH_Vec3 *")] float3* from, [NativeTypeName("const JPH_Vec3 *")] float3* to, [NativeTypeName("JPH_Quat *")] quaternion* quat);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_GetAxisAngle([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Vec3 *")] float3* outAxis, float* outAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_GetEulerAngles([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_RotateAxisX([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_RotateAxisY([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_RotateAxisZ([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Inversed([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_GetPerpendicular([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Quat_GetRotationAngle([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("const JPH_Vec3 *")] float3* axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_FromEulerAngles([NativeTypeName("const JPH_Vec3 *")] float3* angles, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Add([NativeTypeName("const JPH_Quat *")] quaternion* q1, [NativeTypeName("const JPH_Quat *")] quaternion* q2, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Subtract([NativeTypeName("const JPH_Quat *")] quaternion* q1, [NativeTypeName("const JPH_Quat *")] quaternion* q2, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Multiply([NativeTypeName("const JPH_Quat *")] quaternion* q1, [NativeTypeName("const JPH_Quat *")] quaternion* q2, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_MultiplyScalar([NativeTypeName("const JPH_Quat *")] quaternion* q, float scalar, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Divide([NativeTypeName("const JPH_Quat *")] quaternion* q1, [NativeTypeName("const JPH_Quat *")] quaternion* q2, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Dot([NativeTypeName("const JPH_Quat *")] quaternion* q1, [NativeTypeName("const JPH_Quat *")] quaternion* q2, float* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Conjugated([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_GetTwist([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("const JPH_Vec3 *")] float3* axis, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_GetSwingTwist([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("JPH_Quat *")] quaternion* outSwing, [NativeTypeName("JPH_Quat *")] quaternion* outTwist);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_LERP([NativeTypeName("const JPH_Quat *")] quaternion* from, [NativeTypeName("const JPH_Quat *")] quaternion* to, float fraction, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_SLERP([NativeTypeName("const JPH_Quat *")] quaternion* from, [NativeTypeName("const JPH_Quat *")] quaternion* to, float fraction, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_Rotate([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("const JPH_Vec3 *")] float3* vec, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Quat_InverseRotate([NativeTypeName("const JPH_Quat *")] quaternion* quat, [NativeTypeName("const JPH_Vec3 *")] float3* vec, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Vec3_IsClose([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, float maxDistSq);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Vec3_IsNearZero([NativeTypeName("const JPH_Vec3 *")] float3* v, float maxDistSq);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Vec3_IsNormalized([NativeTypeName("const JPH_Vec3 *")] float3* v, float tolerance);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Vec3_IsNaN([NativeTypeName("const JPH_Vec3 *")] float3* v);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Negate([NativeTypeName("const JPH_Vec3 *")] float3* v, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Normalized([NativeTypeName("const JPH_Vec3 *")] float3* v, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Cross([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Abs([NativeTypeName("const JPH_Vec3 *")] float3* v, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Vec3_Length([NativeTypeName("const JPH_Vec3 *")] float3* v);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Vec3_LengthSquared([NativeTypeName("const JPH_Vec3 *")] float3* v);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_DotProduct([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, float* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Normalize([NativeTypeName("const JPH_Vec3 *")] float3* v, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Add([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Subtract([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Multiply([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_MultiplyScalar([NativeTypeName("const JPH_Vec3 *")] float3* v, float scalar, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_Divide([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Vec3_DivideScalar([NativeTypeName("const JPH_Vec3 *")] float3* v, float scalar, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Add([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Subtract([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Multiply([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_MultiplyScalar([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m, float scalar, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Zero([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Identity([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Rotation([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result, [NativeTypeName("const JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Translation([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result, [NativeTypeName("const JPH_Vec3 *")] float3* translation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_RotationTranslation([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Vec3 *")] float3* translation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_InverseRotationTranslation([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Vec3 *")] float3* translation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Scale([NativeTypeName("JPH_Matrix4x4 *")] float4x4* result, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Inversed([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_Transposed([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* m, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_Zero([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_Identity([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_Rotation([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result, [NativeTypeName("const JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_Translation([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result, [NativeTypeName("const JPH_RVec3 *")] rvec3* translation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_RotationTranslation([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_RVec3 *")] rvec3* translation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_InverseRotationTranslation([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_RVec3 *")] rvec3* translation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_Scale([NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RMatrix4x4_Inversed([NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* m, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_GetAxisX([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* matrix, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_GetAxisY([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* matrix, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_GetAxisZ([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* matrix, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_GetTranslation([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* matrix, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Matrix4x4_GetQuaternion([NativeTypeName("const JPH_Matrix4x4 *")] float4x4* matrix, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PhysicsMaterial* JPH_PhysicsMaterial_Create([NativeTypeName("const char *")] sbyte* name, uint color);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsMaterial_Destroy(JPH_PhysicsMaterial* material);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JPH_PhysicsMaterial_GetDebugName([NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_PhysicsMaterial_GetDebugColor([NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_GroupFilter_Destroy(JPH_GroupFilter* groupFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_GroupFilter_CanCollide(JPH_GroupFilter* groupFilter, [NativeTypeName("const JPH_CollisionGroup *")] JPH_CollisionGroup* group1, [NativeTypeName("const JPH_CollisionGroup *")] JPH_CollisionGroup* group2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_GroupFilterTable* JPH_GroupFilterTable_Create(uint numSubGroups);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_GroupFilterTable_DisableCollision(JPH_GroupFilterTable* table, [NativeTypeName("JPH_CollisionSubGroupID")] uint subGroup1, [NativeTypeName("JPH_CollisionSubGroupID")] uint subGroup2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_GroupFilterTable_EnableCollision(JPH_GroupFilterTable* table, [NativeTypeName("JPH_CollisionSubGroupID")] uint subGroup1, [NativeTypeName("JPH_CollisionSubGroupID")] uint subGroup2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_GroupFilterTable_IsCollisionEnabled(JPH_GroupFilterTable* table, [NativeTypeName("JPH_CollisionSubGroupID")] uint subGroup1, [NativeTypeName("JPH_CollisionSubGroupID")] uint subGroup2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeSettings_Destroy(JPH_ShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_ShapeSettings_GetUserData([NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeSettings_SetUserData(JPH_ShapeSettings* settings, [NativeTypeName("uint64_t")] ulong userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_Destroy(JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ShapeType")]
        public static extern ShapeType JPH_Shape_GetType([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ShapeSubType")]
        public static extern ShapeSubType JPH_Shape_GetSubType([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_Shape_GetUserData([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_SetUserData(JPH_Shape* shape, [NativeTypeName("uint64_t")] ulong userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Shape_MustBeStatic([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_GetCenterOfMass([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_GetLocalBounds([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_AABox *")] AABox* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Shape_GetSubShapeIDBitsRecursive([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_GetWorldSpaceBounds([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("JPH_Vec3 *")] float3* scale, [NativeTypeName("JPH_AABox *")] AABox* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Shape_GetInnerRadius([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_GetMassProperties([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_MassProperties *")] MassProperties* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Shape *")]
        public static extern JPH_Shape* JPH_Shape_GetLeafShape([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_SubShapeID")] SubShapeID subShapeID, [NativeTypeName("JPH_SubShapeID *")] SubShapeID* remainder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_PhysicsMaterial *")]
        public static extern JPH_PhysicsMaterial* JPH_Shape_GetMaterial([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_SubShapeID")] SubShapeID subShapeID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_GetSurfaceNormal([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("JPH_SubShapeID")] SubShapeID subShapeID, [NativeTypeName("JPH_Vec3 *")] float3* localPosition, [NativeTypeName("JPH_Vec3 *")] float3* normal);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_GetSupportingFace([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_SubShapeID")] SubShapeID subShapeID, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassTransform, JPH_SupportingFace* outVertices);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Shape_GetVolume([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Shape_IsValidScale([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Shape_MakeScaleValid([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Shape* JPH_Shape_ScaleShape([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Shape_CastRay([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_RayCastResult *")] RayCastResult* hit);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Shape_CastRay2([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_RayCastSettings *")] RayCastSettings* rayCastSettings, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CastRayResultCallback *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Shape_CollidePoint([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* point, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Shape_CollidePoint2([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* point, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollidePointResultCallback *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConvexShapeSettings_GetDensity([NativeTypeName("const JPH_ConvexShapeSettings *")] JPH_ConvexShapeSettings* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConvexShapeSettings_SetDensity(JPH_ConvexShapeSettings* shape, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConvexShape_GetDensity([NativeTypeName("const JPH_ConvexShape *")] JPH_ConvexShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConvexShape_SetDensity(JPH_ConvexShape* shape, float inDensity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BoxShapeSettings* JPH_BoxShapeSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* halfExtent, float convexRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BoxShape* JPH_BoxShapeSettings_CreateShape([NativeTypeName("const JPH_BoxShapeSettings *")] JPH_BoxShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BoxShape* JPH_BoxShape_Create([NativeTypeName("const JPH_Vec3 *")] float3* halfExtent, float convexRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BoxShape_GetHalfExtent([NativeTypeName("const JPH_BoxShape *")] JPH_BoxShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* halfExtent);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BoxShape_GetConvexRadius([NativeTypeName("const JPH_BoxShape *")] JPH_BoxShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SphereShapeSettings* JPH_SphereShapeSettings_Create(float radius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SphereShape* JPH_SphereShapeSettings_CreateShape([NativeTypeName("const JPH_SphereShapeSettings *")] JPH_SphereShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SphereShapeSettings_GetRadius([NativeTypeName("const JPH_SphereShapeSettings *")] JPH_SphereShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SphereShapeSettings_SetRadius(JPH_SphereShapeSettings* settings, float radius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SphereShape* JPH_SphereShape_Create(float radius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SphereShape_GetRadius([NativeTypeName("const JPH_SphereShape *")] JPH_SphereShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PlaneShapeSettings* JPH_PlaneShapeSettings_Create([NativeTypeName("const JPH_Plane *")] Plane* plane, [NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material, float halfExtent);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PlaneShape* JPH_PlaneShapeSettings_CreateShape([NativeTypeName("const JPH_PlaneShapeSettings *")] JPH_PlaneShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PlaneShape* JPH_PlaneShape_Create([NativeTypeName("const JPH_Plane *")] Plane* plane, [NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material, float halfExtent);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PlaneShape_GetPlane([NativeTypeName("const JPH_PlaneShape *")] JPH_PlaneShape* shape, [NativeTypeName("JPH_Plane *")] Plane* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_PlaneShape_GetHalfExtent([NativeTypeName("const JPH_PlaneShape *")] JPH_PlaneShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TriangleShapeSettings* JPH_TriangleShapeSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("const JPH_Vec3 *")] float3* v3, float convexRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TriangleShape* JPH_TriangleShapeSettings_CreateShape([NativeTypeName("const JPH_TriangleShapeSettings *")] JPH_TriangleShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TriangleShape* JPH_TriangleShape_Create([NativeTypeName("const JPH_Vec3 *")] float3* v1, [NativeTypeName("const JPH_Vec3 *")] float3* v2, [NativeTypeName("const JPH_Vec3 *")] float3* v3, float convexRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TriangleShape_GetConvexRadius([NativeTypeName("const JPH_TriangleShape *")] JPH_TriangleShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TriangleShape_GetVertex1([NativeTypeName("const JPH_TriangleShape *")] JPH_TriangleShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TriangleShape_GetVertex2([NativeTypeName("const JPH_TriangleShape *")] JPH_TriangleShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TriangleShape_GetVertex3([NativeTypeName("const JPH_TriangleShape *")] JPH_TriangleShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CapsuleShapeSettings* JPH_CapsuleShapeSettings_Create(float halfHeightOfCylinder, float radius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CapsuleShape* JPH_CapsuleShapeSettings_CreateShape([NativeTypeName("const JPH_CapsuleShapeSettings *")] JPH_CapsuleShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CapsuleShape* JPH_CapsuleShape_Create(float halfHeightOfCylinder, float radius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CapsuleShape_GetRadius([NativeTypeName("const JPH_CapsuleShape *")] JPH_CapsuleShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CapsuleShape_GetHalfHeightOfCylinder([NativeTypeName("const JPH_CapsuleShape *")] JPH_CapsuleShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CylinderShapeSettings* JPH_CylinderShapeSettings_Create(float halfHeight, float radius, float convexRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CylinderShape* JPH_CylinderShapeSettings_CreateShape([NativeTypeName("const JPH_CylinderShapeSettings *")] JPH_CylinderShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CylinderShape* JPH_CylinderShape_Create(float halfHeight, float radius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CylinderShape_GetRadius([NativeTypeName("const JPH_CylinderShape *")] JPH_CylinderShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CylinderShape_GetHalfHeight([NativeTypeName("const JPH_CylinderShape *")] JPH_CylinderShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TaperedCylinderShapeSettings* JPH_TaperedCylinderShapeSettings_Create(float halfHeightOfTaperedCylinder, float topRadius, float bottomRadius, float convexRadius, [NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TaperedCylinderShape* JPH_TaperedCylinderShapeSettings_CreateShape([NativeTypeName("const JPH_TaperedCylinderShapeSettings *")] JPH_TaperedCylinderShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCylinderShape_GetTopRadius([NativeTypeName("const JPH_TaperedCylinderShape *")] JPH_TaperedCylinderShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCylinderShape_GetBottomRadius([NativeTypeName("const JPH_TaperedCylinderShape *")] JPH_TaperedCylinderShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCylinderShape_GetConvexRadius([NativeTypeName("const JPH_TaperedCylinderShape *")] JPH_TaperedCylinderShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCylinderShape_GetHalfHeight([NativeTypeName("const JPH_TaperedCylinderShape *")] JPH_TaperedCylinderShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ConvexHullShapeSettings* JPH_ConvexHullShapeSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* points, uint pointsCount, float maxConvexRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ConvexHullShape* JPH_ConvexHullShapeSettings_CreateShape([NativeTypeName("const JPH_ConvexHullShapeSettings *")] JPH_ConvexHullShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConvexHullShape_GetNumPoints([NativeTypeName("const JPH_ConvexHullShape *")] JPH_ConvexHullShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConvexHullShape_GetPoint([NativeTypeName("const JPH_ConvexHullShape *")] JPH_ConvexHullShape* shape, uint index, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConvexHullShape_GetNumFaces([NativeTypeName("const JPH_ConvexHullShape *")] JPH_ConvexHullShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConvexHullShape_GetNumVerticesInFace([NativeTypeName("const JPH_ConvexHullShape *")] JPH_ConvexHullShape* shape, uint faceIndex);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConvexHullShape_GetFaceVertices([NativeTypeName("const JPH_ConvexHullShape *")] JPH_ConvexHullShape* shape, uint faceIndex, uint maxVertices, [NativeTypeName(" *")] uint* vertices);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MeshShapeSettings* JPH_MeshShapeSettings_Create([NativeTypeName("const JPH_Triangle *")] Triangle* triangles, uint triangleCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MeshShapeSettings* JPH_MeshShapeSettings_Create2([NativeTypeName("const JPH_Vec3 *")] float3* vertices, uint verticesCount, [NativeTypeName("const JPH_IndexedTriangle *")] IndexedTriangle* triangles, uint triangleCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_MeshShapeSettings_GetMaxTrianglesPerLeaf([NativeTypeName("const JPH_MeshShapeSettings *")] JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MeshShapeSettings_SetMaxTrianglesPerLeaf(JPH_MeshShapeSettings* settings, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_MeshShapeSettings_GetActiveEdgeCosThresholdAngle([NativeTypeName("const JPH_MeshShapeSettings *")] JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MeshShapeSettings_SetActiveEdgeCosThresholdAngle(JPH_MeshShapeSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_MeshShapeSettings_GetPerTriangleUserData([NativeTypeName("const JPH_MeshShapeSettings *")] JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MeshShapeSettings_SetPerTriangleUserData(JPH_MeshShapeSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Mesh_Shape_BuildQuality JPH_MeshShapeSettings_GetBuildQuality([NativeTypeName("const JPH_MeshShapeSettings *")] JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MeshShapeSettings_SetBuildQuality(JPH_MeshShapeSettings* settings, JPH_Mesh_Shape_BuildQuality value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MeshShapeSettings_Sanitize(JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MeshShape* JPH_MeshShapeSettings_CreateShape([NativeTypeName("const JPH_MeshShapeSettings *")] JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_MeshShape_GetTriangleUserData([NativeTypeName("const JPH_MeshShape *")] JPH_MeshShape* shape, [NativeTypeName("JPH_SubShapeID")] SubShapeID id);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_HeightFieldShapeSettings* JPH_HeightFieldShapeSettings_Create([NativeTypeName("const float *")] float* samples, [NativeTypeName("const JPH_Vec3 *")] float3* offset, [NativeTypeName("const JPH_Vec3 *")] float3* scale, uint sampleCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_HeightFieldShape* JPH_HeightFieldShapeSettings_CreateShape(JPH_HeightFieldShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample([NativeTypeName("const JPH_HeightFieldShapeSettings *")] JPH_HeightFieldShapeSettings* settings, float* pOutMinValue, float* pOutMaxValue, float* pOutQuantizationScale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError([NativeTypeName("const JPH_HeightFieldShapeSettings *")] JPH_HeightFieldShapeSettings* settings, float maxError);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_HeightFieldShape_GetSampleCount([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_HeightFieldShape_GetBlockSize([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_PhysicsMaterial *")]
        public static extern JPH_PhysicsMaterial* JPH_HeightFieldShape_GetMaterial([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape, uint x, uint y);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HeightFieldShape_GetPosition([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape, uint x, uint y, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_HeightFieldShape_IsNoCollision([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape, uint x, uint y);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_HeightFieldShape_ProjectOntoSurface([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* localPosition, [NativeTypeName("JPH_Vec3 *")] float3* outSurfacePosition, [NativeTypeName("JPH_SubShapeID *")] SubShapeID* outSubShapeID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HeightFieldShape_GetMinHeightValue([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HeightFieldShape_GetMaxHeightValue([NativeTypeName("const JPH_HeightFieldShape *")] JPH_HeightFieldShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TaperedCapsuleShapeSettings* JPH_TaperedCapsuleShapeSettings_Create(float halfHeightOfTaperedCylinder, float topRadius, float bottomRadius);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_TaperedCapsuleShape* JPH_TaperedCapsuleShapeSettings_CreateShape(JPH_TaperedCapsuleShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCapsuleShape_GetTopRadius([NativeTypeName("const JPH_TaperedCapsuleShape *")] JPH_TaperedCapsuleShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCapsuleShape_GetBottomRadius([NativeTypeName("const JPH_TaperedCapsuleShape *")] JPH_TaperedCapsuleShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_TaperedCapsuleShape_GetHalfHeight([NativeTypeName("const JPH_TaperedCapsuleShape *")] JPH_TaperedCapsuleShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CompoundShapeSettings_AddShape(JPH_CompoundShapeSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* shapeSettings, uint userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CompoundShapeSettings_AddShape2(JPH_CompoundShapeSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, uint userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_CompoundShape_GetNumSubShapes([NativeTypeName("const JPH_CompoundShape *")] JPH_CompoundShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CompoundShape_GetSubShape([NativeTypeName("const JPH_CompoundShape *")] JPH_CompoundShape* shape, uint index, [NativeTypeName("const JPH_Shape **")] JPH_Shape** subShape, [NativeTypeName("JPH_Vec3 *")] float3* positionCOM, [NativeTypeName("JPH_Quat *")] quaternion* rotation, [NativeTypeName(" *")] uint* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_CompoundShape_GetSubShapeIndexFromID([NativeTypeName("const JPH_CompoundShape *")] JPH_CompoundShape* shape, [NativeTypeName("JPH_SubShapeID")] SubShapeID id, [NativeTypeName("JPH_SubShapeID *")] SubShapeID* remainder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_StaticCompoundShapeSettings* JPH_StaticCompoundShapeSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_StaticCompoundShape* JPH_StaticCompoundShape_Create([NativeTypeName("const JPH_StaticCompoundShapeSettings *")] JPH_StaticCompoundShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MutableCompoundShapeSettings* JPH_MutableCompoundShapeSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MutableCompoundShape* JPH_MutableCompoundShape_Create([NativeTypeName("const JPH_MutableCompoundShapeSettings *")] JPH_MutableCompoundShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_MutableCompoundShape_AddShape(JPH_MutableCompoundShape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Shape *")] JPH_Shape* child, uint userData, uint index);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MutableCompoundShape_RemoveShape(JPH_MutableCompoundShape* shape, uint index);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MutableCompoundShape_ModifyShape(JPH_MutableCompoundShape* shape, uint index, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MutableCompoundShape_ModifyShape2(JPH_MutableCompoundShape* shape, uint index, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Shape *")] JPH_Shape* newShape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MutableCompoundShape_AdjustCenterOfMass(JPH_MutableCompoundShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Shape *")]
        public static extern JPH_Shape* JPH_DecoratedShape_GetInnerShape([NativeTypeName("const JPH_DecoratedShape *")] JPH_DecoratedShape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_RotatedTranslatedShapeSettings* JPH_RotatedTranslatedShapeSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* shapeSettings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_RotatedTranslatedShapeSettings* JPH_RotatedTranslatedShapeSettings_Create2([NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_RotatedTranslatedShape* JPH_RotatedTranslatedShapeSettings_CreateShape([NativeTypeName("const JPH_RotatedTranslatedShapeSettings *")] JPH_RotatedTranslatedShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_RotatedTranslatedShape* JPH_RotatedTranslatedShape_Create([NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RotatedTranslatedShape_GetPosition([NativeTypeName("const JPH_RotatedTranslatedShape *")] JPH_RotatedTranslatedShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RotatedTranslatedShape_GetRotation([NativeTypeName("const JPH_RotatedTranslatedShape *")] JPH_RotatedTranslatedShape* shape, [NativeTypeName("JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ScaledShapeSettings* JPH_ScaledShapeSettings_Create([NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* shapeSettings, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ScaledShapeSettings* JPH_ScaledShapeSettings_Create2([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ScaledShape* JPH_ScaledShapeSettings_CreateShape([NativeTypeName("const JPH_ScaledShapeSettings *")] JPH_ScaledShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ScaledShape* JPH_ScaledShape_Create([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ScaledShape_GetScale([NativeTypeName("const JPH_ScaledShape *")] JPH_ScaledShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_OffsetCenterOfMassShapeSettings* JPH_OffsetCenterOfMassShapeSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* offset, [NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* shapeSettings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_OffsetCenterOfMassShapeSettings* JPH_OffsetCenterOfMassShapeSettings_Create2([NativeTypeName("const JPH_Vec3 *")] float3* offset, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_OffsetCenterOfMassShape* JPH_OffsetCenterOfMassShapeSettings_CreateShape([NativeTypeName("const JPH_OffsetCenterOfMassShapeSettings *")] JPH_OffsetCenterOfMassShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_OffsetCenterOfMassShape* JPH_OffsetCenterOfMassShape_Create([NativeTypeName("const JPH_Vec3 *")] float3* offset, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_OffsetCenterOfMassShape_GetOffset([NativeTypeName("const JPH_OffsetCenterOfMassShape *")] JPH_OffsetCenterOfMassShape* shape, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_EmptyShapeSettings* JPH_EmptyShapeSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* centerOfMass);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_EmptyShape* JPH_EmptyShapeSettings_CreateShape([NativeTypeName("const JPH_EmptyShapeSettings *")] JPH_EmptyShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyCreationSettings* JPH_BodyCreationSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyCreationSettings* JPH_BodyCreationSettings_Create2([NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_MotionType")] MotionType motionType, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer objectLayer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyCreationSettings* JPH_BodyCreationSettings_Create3([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_MotionType")] MotionType motionType, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer objectLayer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_Destroy(JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_GetPosition(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetPosition(JPH_BodyCreationSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_GetRotation(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetRotation(JPH_BodyCreationSettings* settings, [NativeTypeName("const JPH_Quat *")] quaternion* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_GetLinearVelocity(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetLinearVelocity(JPH_BodyCreationSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_GetAngularVelocity(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetAngularVelocity(JPH_BodyCreationSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_BodyCreationSettings_GetUserData([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetUserData(JPH_BodyCreationSettings* settings, [NativeTypeName("uint64_t")] ulong value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ObjectLayer")]
        public static extern ObjectLayer JPH_BodyCreationSettings_GetObjectLayer([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetObjectLayer(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_GetCollissionGroup([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings, JPH_CollisionGroup* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetCollissionGroup(JPH_BodyCreationSettings* settings, [NativeTypeName("const JPH_CollisionGroup *")] JPH_CollisionGroup* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotionType")]
        public static extern MotionType JPH_BodyCreationSettings_GetMotionType([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMotionType(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_MotionType")] MotionType value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_AllowedDOFs")]
        public static extern AllowedDOFs JPH_BodyCreationSettings_GetAllowedDOFs([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetAllowedDOFs(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_AllowedDOFs")] AllowedDOFs value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetAllowDynamicOrKinematic([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetAllowDynamicOrKinematic(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetIsSensor([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetIsSensor(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetCollideKinematicVsNonDynamic([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetCollideKinematicVsNonDynamic(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetUseManifoldReduction([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetUseManifoldReduction(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetApplyGyroscopicForce([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetApplyGyroscopicForce(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotionQuality")]
        public static extern MotionQuality JPH_BodyCreationSettings_GetMotionQuality([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMotionQuality(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_MotionQuality")] MotionQuality value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetEnhancedInternalEdgeRemoval([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetEnhancedInternalEdgeRemoval(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyCreationSettings_GetAllowSleeping([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetAllowSleeping(JPH_BodyCreationSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetFriction([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetFriction(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetRestitution([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetRestitution(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetLinearDamping([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetLinearDamping(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetAngularDamping([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetAngularDamping(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetMaxLinearVelocity([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMaxLinearVelocity(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetMaxAngularVelocity([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMaxAngularVelocity(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetGravityFactor([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetGravityFactor(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_BodyCreationSettings_GetNumVelocityStepsOverride([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetNumVelocityStepsOverride(JPH_BodyCreationSettings* settings, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_BodyCreationSettings_GetNumPositionStepsOverride([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetNumPositionStepsOverride(JPH_BodyCreationSettings* settings, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_OverrideMassProperties")]
        public static extern OverrideMassProperties JPH_BodyCreationSettings_GetOverrideMassProperties([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetOverrideMassProperties(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_OverrideMassProperties")] OverrideMassProperties value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyCreationSettings_GetInertiaMultiplier([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetInertiaMultiplier(JPH_BodyCreationSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_GetMassPropertiesOverride([NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_MassProperties *")] MassProperties* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMassPropertiesOverride(JPH_BodyCreationSettings* settings, [NativeTypeName("const JPH_MassProperties *")] MassProperties* massProperties);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SoftBodyCreationSettings* JPH_SoftBodyCreationSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SoftBodyCreationSettings_Destroy(JPH_SoftBodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_Destroy(JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ConstraintType")]
        public static extern ConstraintType JPH_Constraint_GetType([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ConstraintSubType")]
        public static extern ConstraintSubType JPH_Constraint_GetSubType([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Constraint_GetConstraintPriority([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_SetConstraintPriority(JPH_Constraint* constraint, uint priority);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Constraint_GetNumVelocityStepsOverride([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_SetNumVelocityStepsOverride(JPH_Constraint* constraint, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Constraint_GetNumPositionStepsOverride([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_SetNumPositionStepsOverride(JPH_Constraint* constraint, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Constraint_GetEnabled([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_SetEnabled(JPH_Constraint* constraint, [NativeTypeName("bool")] NativeBool enabled);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_Constraint_GetUserData([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_SetUserData(JPH_Constraint* constraint, [NativeTypeName("uint64_t")] ulong userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_NotifyShapeChanged(JPH_Constraint* constraint, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("JPH_Vec3 *")] float3* deltaCOM);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_ResetWarmStart(JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Constraint_IsActive([NativeTypeName("const JPH_Constraint *")] JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_SetupVelocityConstraint(JPH_Constraint* constraint, float deltaTime);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Constraint_WarmStartVelocityConstraint(JPH_Constraint* constraint, float warmStartImpulseRatio);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Constraint_SolveVelocityConstraint(JPH_Constraint* constraint, float deltaTime);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Constraint_SolvePositionConstraint(JPH_Constraint* constraint, float deltaTime, float baumgarte);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_TwoBodyConstraint_GetBody1([NativeTypeName("const JPH_TwoBodyConstraint *")] JPH_TwoBodyConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_TwoBodyConstraint_GetBody2([NativeTypeName("const JPH_TwoBodyConstraint *")] JPH_TwoBodyConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TwoBodyConstraint_GetConstraintToBody1Matrix([NativeTypeName("const JPH_TwoBodyConstraint *")] JPH_TwoBodyConstraint* constraint, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TwoBodyConstraint_GetConstraintToBody2Matrix([NativeTypeName("const JPH_TwoBodyConstraint *")] JPH_TwoBodyConstraint* constraint, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_Init([NativeTypeName("JPH_FixedConstraintSettings *")] FixedConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_FixedConstraint* JPH_FixedConstraint_Create([NativeTypeName("const JPH_FixedConstraintSettings *")] FixedConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraint_GetSettings([NativeTypeName("const JPH_FixedConstraint *")] JPH_FixedConstraint* constraint, [NativeTypeName("JPH_FixedConstraintSettings *")] FixedConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_FixedConstraint *")] JPH_FixedConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_FixedConstraint *")] JPH_FixedConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraintSettings_Init([NativeTypeName("JPH_DistanceConstraintSettings *")] DistanceConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_DistanceConstraint* JPH_DistanceConstraint_Create([NativeTypeName("const JPH_DistanceConstraintSettings *")] DistanceConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraint_GetSettings([NativeTypeName("const JPH_DistanceConstraint *")] JPH_DistanceConstraint* constraint, [NativeTypeName("JPH_DistanceConstraintSettings *")] DistanceConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraint_SetDistance(JPH_DistanceConstraint* constraint, float minDistance, float maxDistance);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_DistanceConstraint_GetMinDistance(JPH_DistanceConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_DistanceConstraint_GetMaxDistance(JPH_DistanceConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraint_GetLimitsSpringSettings(JPH_DistanceConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraint_SetLimitsSpringSettings(JPH_DistanceConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_DistanceConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_DistanceConstraint *")] JPH_DistanceConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraintSettings_Init([NativeTypeName("JPH_PointConstraintSettings *")] PointConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PointConstraint* JPH_PointConstraint_Create([NativeTypeName("const JPH_PointConstraintSettings *")] PointConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_GetSettings([NativeTypeName("const JPH_PointConstraint *")] JPH_PointConstraint* constraint, [NativeTypeName("JPH_PointConstraintSettings *")] PointConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_SetPoint1(JPH_PointConstraint* constraint, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space, [NativeTypeName("JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_SetPoint2(JPH_PointConstraint* constraint, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space, [NativeTypeName("JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_GetLocalSpacePoint1([NativeTypeName("const JPH_PointConstraint *")] JPH_PointConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_GetLocalSpacePoint2([NativeTypeName("const JPH_PointConstraint *")] JPH_PointConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_PointConstraint *")] JPH_PointConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_Init([NativeTypeName("JPH_HingeConstraintSettings *")] HingeConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_HingeConstraint* JPH_HingeConstraint_Create([NativeTypeName("const JPH_HingeConstraintSettings *")] HingeConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetSettings(JPH_HingeConstraint* constraint, [NativeTypeName("JPH_HingeConstraintSettings *")] HingeConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLocalSpacePoint1([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLocalSpacePoint2([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLocalSpaceHingeAxis1([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLocalSpaceHingeAxis2([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLocalSpaceNormalAxis1([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLocalSpaceNormalAxis2([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetCurrentAngle(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetMaxFrictionTorque(JPH_HingeConstraint* constraint, float frictionTorque);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetMaxFrictionTorque(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetMotorSettings(JPH_HingeConstraint* constraint, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetMotorSettings(JPH_HingeConstraint* constraint, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetMotorState(JPH_HingeConstraint* constraint, [NativeTypeName("JPH_MotorState")] MotorState state);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotorState")]
        public static extern MotorState JPH_HingeConstraint_GetMotorState(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetTargetAngularVelocity(JPH_HingeConstraint* constraint, float angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetTargetAngularVelocity(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetTargetAngle(JPH_HingeConstraint* constraint, float angle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetTargetAngle(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetLimits(JPH_HingeConstraint* constraint, float inLimitsMin, float inLimitsMax);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetLimitsMin(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetLimitsMax(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_HingeConstraint_HasLimits(JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetLimitsSpringSettings(JPH_HingeConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_SetLimitsSpringSettings(JPH_HingeConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, [NativeTypeName("float[2]")] float* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetTotalLambdaRotationLimits([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetTotalLambdaMotor([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_Init([NativeTypeName("JPH_SliderConstraintSettings *")] SliderConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetSliderAxis([NativeTypeName("JPH_SliderConstraintSettings *")] SliderConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SliderConstraint* JPH_SliderConstraint_Create([NativeTypeName("const JPH_SliderConstraintSettings *")] SliderConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetSettings(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_SliderConstraintSettings *")] SliderConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetCurrentPosition(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetMaxFrictionForce(JPH_SliderConstraint* constraint, float frictionForce);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetMaxFrictionForce(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetMotorSettings(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetMotorSettings([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetMotorState(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_MotorState")] MotorState state);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotorState")]
        public static extern MotorState JPH_SliderConstraint_GetMotorState(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetTargetVelocity(JPH_SliderConstraint* constraint, float velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetTargetVelocity(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetTargetPosition(JPH_SliderConstraint* constraint, float position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetTargetPosition(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetLimits(JPH_SliderConstraint* constraint, float inLimitsMin, float inLimitsMax);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetLimitsMin(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetLimitsMax(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_SliderConstraint_HasLimits(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetLimitsSpringSettings(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetLimitsSpringSettings(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint, [NativeTypeName("float[2]")] float* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetTotalLambdaPositionLimits([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetTotalLambdaMotor([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_Init([NativeTypeName("JPH_ConeConstraintSettings *")] ConeConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ConeConstraint* JPH_ConeConstraint_Create([NativeTypeName("const JPH_ConeConstraintSettings *")] ConeConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraint_GetSettings(JPH_ConeConstraint* constraint, [NativeTypeName("JPH_ConeConstraintSettings *")] ConeConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraint_SetHalfConeAngle(JPH_ConeConstraint* constraint, float halfConeAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConeConstraint_GetCosHalfConeAngle([NativeTypeName("const JPH_ConeConstraint *")] JPH_ConeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_ConeConstraint *")] JPH_ConeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConeConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_ConeConstraint *")] JPH_ConeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SwingTwistConstraintSettings_Init([NativeTypeName("JPH_SwingTwistConstraintSettings *")] SwingTwistConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SwingTwistConstraint* JPH_SwingTwistConstraint_Create([NativeTypeName("const JPH_SwingTwistConstraintSettings *")] SwingTwistConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SwingTwistConstraint_GetSettings(JPH_SwingTwistConstraint* constraint, [NativeTypeName("JPH_SwingTwistConstraintSettings *")] SwingTwistConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SwingTwistConstraint_GetNormalHalfConeAngle(JPH_SwingTwistConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SwingTwistConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_SwingTwistConstraint *")] JPH_SwingTwistConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SwingTwistConstraint_GetTotalLambdaTwist([NativeTypeName("const JPH_SwingTwistConstraint *")] JPH_SwingTwistConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SwingTwistConstraint_GetTotalLambdaSwingY([NativeTypeName("const JPH_SwingTwistConstraint *")] JPH_SwingTwistConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SwingTwistConstraint_GetTotalLambdaSwingZ([NativeTypeName("const JPH_SwingTwistConstraint *")] JPH_SwingTwistConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SwingTwistConstraint_GetTotalLambdaMotor([NativeTypeName("const JPH_SwingTwistConstraint *")] JPH_SwingTwistConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraintSettings_Init([NativeTypeName("JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraintSettings_MakeFreeAxis([NativeTypeName("JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_SixDOFConstraintSettings_IsFreeAxis([NativeTypeName("const JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraintSettings_MakeFixedAxis([NativeTypeName("JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_SixDOFConstraintSettings_IsFixedAxis([NativeTypeName("const JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraintSettings_SetLimitedAxis([NativeTypeName("JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis, float min, float max);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SixDOFConstraint* JPH_SixDOFConstraint_Create([NativeTypeName("const JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetSettings(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintSettings *")] SixDOFConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SixDOFConstraint_GetLimitsMin(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SixDOFConstraint_GetLimitsMax(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTotalLambdaMotorRotation([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTranslationLimitsMin([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTranslationLimitsMax([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetRotationLimitsMin([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetRotationLimitsMax([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_SixDOFConstraint_IsFixedAxis([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_SixDOFConstraint_IsFreeAxis([NativeTypeName("const JPH_SixDOFConstraint *")] JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetLimitsSpringSettings(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* result, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetLimitsSpringSettings(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SpringSettings *")] SpringSettings* settings, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetMaxFriction(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis, float inFriction);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SixDOFConstraint_GetMaxFriction(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetRotationInConstraintSpace(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetMotorSettings(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetMotorState(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis, [NativeTypeName("JPH_MotorState")] MotorState state);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotorState")]
        public static extern MotorState JPH_SixDOFConstraint_GetMotorState(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_SixDOFConstraintAxis")] SixDOFConstraintAxis axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetTargetVelocityCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* inVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTargetVelocityCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetTargetAngularVelocityCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* inAngularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTargetAngularVelocityCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetTargetPositionCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* inPosition);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTargetPositionCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetTargetOrientationCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Quat *")] quaternion* inOrientation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_GetTargetOrientationCS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SixDOFConstraint_SetTargetOrientationBS(JPH_SixDOFConstraint* constraint, [NativeTypeName("JPH_Quat *")] quaternion* inOrientation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_GearConstraintSettings_Init([NativeTypeName("JPH_GearConstraintSettings *")] GearConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_GearConstraint* JPH_GearConstraint_Create([NativeTypeName("const JPH_GearConstraintSettings *")] GearConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_GearConstraint_GetSettings(JPH_GearConstraint* constraint, [NativeTypeName("JPH_GearConstraintSettings *")] GearConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_GearConstraint_SetConstraints(JPH_GearConstraint* constraint, [NativeTypeName("const JPH_Constraint *")] JPH_Constraint* gear1, [NativeTypeName("const JPH_Constraint *")] JPH_Constraint* gear2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_GearConstraint_GetTotalLambda([NativeTypeName("const JPH_GearConstraint *")] JPH_GearConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_DestroyBody(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_BodyInterface_CreateAndAddBody(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_CreateBody(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_CreateBodyWithID(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_CreateBodyWithoutID(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_BodyCreationSettings *")] JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_DestroyBodyWithoutID(JPH_BodyInterface* @interface, JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyInterface_AssignBodyID(JPH_BodyInterface* @interface, JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyInterface_AssignBodyID2(JPH_BodyInterface* @interface, JPH_Body* body, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_UnassignBodyID(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_CreateSoftBody(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_SoftBodyCreationSettings *")] JPH_SoftBodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_CreateSoftBodyWithID(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("const JPH_SoftBodyCreationSettings *")] JPH_SoftBodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyInterface_CreateSoftBodyWithoutID(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_SoftBodyCreationSettings *")] JPH_SoftBodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_BodyInterface_CreateAndAddSoftBody(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_SoftBodyCreationSettings *")] JPH_SoftBodyCreationSettings* settings, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddBody(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_RemoveBody(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_RemoveAndDestroyBody(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* JPH_BodyInterface_AddBodiesPrepare(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID *")] BodyID* bodyIDs, [NativeTypeName("int32_t")] int number);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddBodiesFinalize(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID *")] BodyID* bodyIDs, [NativeTypeName("int32_t")] int number, void* addState, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddBodiesAbort(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID *")] BodyID* bodyIDs, [NativeTypeName("int32_t")] int number, void* addState);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_RemoveBodies(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID *")] BodyID* bodyIDs, [NativeTypeName("int32_t")] int number);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_DestroyBodies(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID *")] BodyID* bodyIDs, [NativeTypeName("int32_t")] int number);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyInterface_IsActive(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyInterface_IsAdded(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyType")]
        public static extern BodyType JPH_BodyInterface_GetBodyType(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetLinearVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetLinearVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetCenterOfMassPosition(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotionType")]
        public static extern MotionType JPH_BodyInterface_GetMotionType(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetMotionType(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, [NativeTypeName("JPH_MotionType")] MotionType motionType, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyInterface_GetRestitution([NativeTypeName("const JPH_BodyInterface *")] JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetRestitution(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, float restitution);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyInterface_GetFriction([NativeTypeName("const JPH_BodyInterface *")] JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetFriction(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, float friction);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetPosition(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetPosition(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetRotation(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetRotation(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetPositionAndRotation(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetPositionAndRotationWhenChanged(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetPositionAndRotation(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetPositionRotationAndVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_Vec3 *")] float3* linearVelocity, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetCollissionGroup(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, JPH_CollisionGroup* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetCollissionGroup(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("const JPH_CollisionGroup *")] JPH_CollisionGroup* group);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Shape *")]
        public static extern JPH_Shape* JPH_BodyInterface_GetShape(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetShape(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("bool")] NativeBool updateMassProperties, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_NotifyShapeChanged(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* previousCenterOfMass, [NativeTypeName("bool")] NativeBool updateMassProperties, [NativeTypeName("JPH_Activation")] Activation activationMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_ActivateBody(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_DeactivateBody(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_ActivateBodiesInAABox(JPH_BodyInterface* @interface, [NativeTypeName("const JPH_AABox *")] AABox* box, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ObjectLayer")]
        public static extern ObjectLayer JPH_BodyInterface_GetObjectLayer(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetObjectLayer(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetWorldTransform(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetCenterOfMassTransform(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_MoveKinematic(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RVec3 *")] rvec3* targetPosition, [NativeTypeName("JPH_Quat *")] quaternion* targetRotation, float deltaTime);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyInterface_ApplyBuoyancyImpulse(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("const JPH_RVec3 *")] rvec3* surfacePosition, [NativeTypeName("const JPH_Vec3 *")] float3* surfaceNormal, float buoyancy, float linearDrag, float angularDrag, [NativeTypeName("const JPH_Vec3 *")] float3* fluidVelocity, [NativeTypeName("const JPH_Vec3 *")] float3* gravity, float deltaTime);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetLinearAndAngularVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* linearVelocity, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetLinearAndAngularVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* linearVelocity, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddLinearVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* linearVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddLinearAndAngularVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* linearVelocity, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetAngularVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetAngularVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetPointVelocity(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_RVec3 *")] rvec3* point, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddForce(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* force);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddForce2(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* force, [NativeTypeName("JPH_RVec3 *")] rvec3* point);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddTorque(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* torque);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddForceAndTorque(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* force, [NativeTypeName("JPH_Vec3 *")] float3* torque);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddImpulse(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* impulse);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddImpulse2(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* impulse, [NativeTypeName("JPH_RVec3 *")] rvec3* point);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_AddAngularImpulse(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Vec3 *")] float3* angularImpulse);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetMotionQuality(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_MotionQuality")] MotionQuality quality);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotionQuality")]
        public static extern MotionQuality JPH_BodyInterface_GetMotionQuality(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_GetInverseInertia(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetGravityFactor(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_BodyInterface_GetGravityFactor(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetUseManifoldReduction(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BodyInterface_GetUseManifoldReduction(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_SetUserData(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("uint64_t")] ulong inUserData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_BodyInterface_GetUserData(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_PhysicsMaterial *")]
        public static extern JPH_PhysicsMaterial* JPH_BodyInterface_GetMaterial(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId, [NativeTypeName("JPH_SubShapeID")] SubShapeID subShapeID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyInterface_InvalidateContactCache(JPH_BodyInterface* @interface, [NativeTypeName("JPH_BodyID")] BodyID bodyId);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyLockInterface_LockRead([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, JPH_BodyLockRead* outLock);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyLockInterface_UnlockRead([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, JPH_BodyLockRead* ioLock);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyLockInterface_LockWrite([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, [NativeTypeName("JPH_BodyID")] BodyID bodyID, JPH_BodyLockWrite* outLock);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyLockInterface_UnlockWrite([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, JPH_BodyLockWrite* ioLock);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyLockMultiRead* JPH_BodyLockInterface_LockMultiRead([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, [NativeTypeName("const JPH_BodyID *")] BodyID* bodyIDs, uint count);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyLockMultiRead_Destroy(JPH_BodyLockMultiRead* ioLock);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Body *")]
        public static extern JPH_Body* JPH_BodyLockMultiRead_GetBody(JPH_BodyLockMultiRead* ioLock, uint bodyIndex);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyLockMultiWrite* JPH_BodyLockInterface_LockMultiWrite([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, [NativeTypeName("const JPH_BodyID *")] BodyID* bodyIDs, uint count);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyLockMultiWrite_Destroy(JPH_BodyLockMultiWrite* ioLock);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyLockMultiWrite_GetBody(JPH_BodyLockMultiWrite* ioLock, uint bodyIndex);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_BodyLockInterface_TryGetBody([NativeTypeName("const JPH_BodyLockInterface *")] JPH_BodyLockInterface* lockInterface, [NativeTypeName("const JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_AllowedDOFs")]
        public static extern AllowedDOFs JPH_MotionProperties_GetAllowedDOFs([NativeTypeName("const JPH_MotionProperties *")] JPH_MotionProperties* properties);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_SetLinearDamping(JPH_MotionProperties* properties, float damping);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_MotionProperties_GetLinearDamping([NativeTypeName("const JPH_MotionProperties *")] JPH_MotionProperties* properties);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_SetAngularDamping(JPH_MotionProperties* properties, float damping);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_MotionProperties_GetAngularDamping([NativeTypeName("const JPH_MotionProperties *")] JPH_MotionProperties* properties);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_SetMassProperties(JPH_MotionProperties* properties, [NativeTypeName("JPH_AllowedDOFs")] AllowedDOFs allowedDOFs, [NativeTypeName("const JPH_MassProperties *")] MassProperties* massProperties);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_MotionProperties_GetInverseMassUnchecked(JPH_MotionProperties* properties);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_SetInverseMass(JPH_MotionProperties* properties, float inverseMass);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_GetInverseInertiaDiagonal(JPH_MotionProperties* properties, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_GetInertiaRotation(JPH_MotionProperties* properties, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_SetInverseInertia(JPH_MotionProperties* properties, [NativeTypeName("JPH_Vec3 *")] float3* diagonal, [NativeTypeName("JPH_Quat *")] quaternion* rot);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MotionProperties_ScaleToMass(JPH_MotionProperties* properties, float mass);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RayCast_GetPointOnRay([NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, float fraction, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RRayCast_GetPointOnRay([NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, float fraction, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MassProperties_DecomposePrincipalMomentsOfInertia([NativeTypeName("JPH_MassProperties *")] MassProperties* properties, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* rotation, [NativeTypeName("JPH_Vec3 *")] float3* diagonal);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MassProperties_ScaleToMass([NativeTypeName("JPH_MassProperties *")] MassProperties* properties, float mass);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MassProperties_GetEquivalentSolidBoxSize(float mass, [NativeTypeName("const JPH_Vec3 *")] float3* inertiaDiagonal, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CollideShapeSettings_Init([NativeTypeName("JPH_CollideShapeSettings *")] CollideShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeCastSettings_Init([NativeTypeName("JPH_ShapeCastSettings *")] ShapeCastSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CastRay([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_RayCastBodyCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CastRay2([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_RayCastBodyResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CollideAABox([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_AABox *")] AABox* box, [NativeTypeName("JPH_CollideShapeBodyCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CollideSphere([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* center, float radius, [NativeTypeName("JPH_CollideShapeBodyCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CollidePoint([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* point, [NativeTypeName("JPH_CollideShapeBodyCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastRay([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_RayCastResult *")] RayCastResult* hit, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastRay2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_RayCastSettings *")] RayCastSettings* rayCastSettings, [NativeTypeName("JPH_CastRayCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_NarrowPhaseQuery_CastRay3([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_RayCastSettings *")] RayCastSettings* rayCastSettings, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_RayCastResult *")] RayCastResult* resultArray, int resultArraySize, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollidePoint([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* point, [NativeTypeName("JPH_CollidePointCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_NarrowPhaseQuery_CollidePoint2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* point, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollidePointResult *")] CollidePointResult* resultArray, int resultArraySize, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollideShape([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollideShapeCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_NarrowPhaseQuery_CollideShape2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollideShapeResult *")] CollideShapeResult* resultArray, int resultArraySize, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollideShapeWithInternalEdgeRemoval([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollideShapeCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_NarrowPhaseQuery_CollideShapeWithInternalEdgeRemoval2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollideShapeResult *")] CollideShapeResult* resultArray, int resultArraySize, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastShape([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CastShapeCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_NarrowPhaseQuery_CastShape2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_ShapeCastResult *")] ShapeCastResult* resultArray, int resultArraySize, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastShapeIgnoreInitialOverlap([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CastShapeCollectorCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_NarrowPhaseQuery_CastShapeIgnoreInitialOverlap2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_ShapeCastResult *")] ShapeCastResult* resultArray, int resultArraySize, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_Body_GetID([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyType")]
        public static extern BodyType JPH_Body_GetBodyType([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsRigidBody([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsSoftBody([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsActive([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsStatic([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsKinematic([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsDynamic([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_CanBeKinematicOrDynamic([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetIsSensor(JPH_Body* body, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsSensor([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetCollideKinematicVsNonDynamic(JPH_Body* body, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetCollideKinematicVsNonDynamic([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetUseManifoldReduction(JPH_Body* body, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetUseManifoldReduction([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetUseManifoldReductionWithBody([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("const JPH_Body *")] JPH_Body* other);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetApplyGyroscopicForce(JPH_Body* body, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetApplyGyroscopicForce([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetEnhancedInternalEdgeRemoval(JPH_Body* body, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetEnhancedInternalEdgeRemoval([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetEnhancedInternalEdgeRemovalWithBody([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("const JPH_Body *")] JPH_Body* other);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotionType")]
        public static extern MotionType JPH_Body_GetMotionType([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetMotionType(JPH_Body* body, [NativeTypeName("JPH_MotionType")] MotionType motionType);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BroadPhaseLayer")]
        public static extern BroadPhaseLayer JPH_Body_GetBroadPhaseLayer([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ObjectLayer")]
        public static extern ObjectLayer JPH_Body_GetObjectLayer([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetCollissionGroup([NativeTypeName("const JPH_Body *")] JPH_Body* body, JPH_CollisionGroup* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetCollissionGroup(JPH_Body* body, [NativeTypeName("const JPH_CollisionGroup *")] JPH_CollisionGroup* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_GetAllowSleeping(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetAllowSleeping(JPH_Body* body, [NativeTypeName("bool")] NativeBool allowSleeping);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_ResetSleepTimer(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Body_GetFriction([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetFriction(JPH_Body* body, float friction);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_Body_GetRestitution([NativeTypeName("const JPH_Body *")] JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetRestitution(JPH_Body* body, float restitution);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetLinearVelocity(JPH_Body* body, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetLinearVelocity(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetLinearVelocityClamped(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetAngularVelocity(JPH_Body* body, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetAngularVelocity(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetAngularVelocityClamped(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetPointVelocityCOM(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* pointRelativeToCOM, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetPointVelocity(JPH_Body* body, [NativeTypeName("const JPH_RVec3 *")] rvec3* point, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_AddForce(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* force);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_AddForceAtPosition(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* force, [NativeTypeName("const JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_AddTorque(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* force);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetAccumulatedForce(JPH_Body* body, [NativeTypeName("JPH_Vec3 *")] float3* force);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetAccumulatedTorque(JPH_Body* body, [NativeTypeName("JPH_Vec3 *")] float3* force);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_ResetForce(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_ResetTorque(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_ResetMotion(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetInverseInertia(JPH_Body* body, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_AddImpulse(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* impulse);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_AddImpulseAtPosition(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* impulse, [NativeTypeName("const JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_AddAngularImpulse(JPH_Body* body, [NativeTypeName("const JPH_Vec3 *")] float3* angularImpulse);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_MoveKinematic(JPH_Body* body, [NativeTypeName("JPH_RVec3 *")] rvec3* targetPosition, [NativeTypeName("JPH_Quat *")] quaternion* targetRotation, float deltaTime);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_ApplyBuoyancyImpulse(JPH_Body* body, [NativeTypeName("const JPH_RVec3 *")] rvec3* surfacePosition, [NativeTypeName("const JPH_Vec3 *")] float3* surfaceNormal, float buoyancy, float linearDrag, float angularDrag, [NativeTypeName("const JPH_Vec3 *")] float3* fluidVelocity, [NativeTypeName("const JPH_Vec3 *")] float3* gravity, float deltaTime);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsInBroadPhase(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Body_IsCollisionCacheInvalid(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Shape *")]
        public static extern JPH_Shape* JPH_Body_GetShape(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetPosition([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetRotation([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_Quat *")] quaternion* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetWorldTransform([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetCenterOfMassPosition([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetCenterOfMassTransform([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetInverseCenterOfMassTransform([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetWorldSpaceBounds([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_AABox *")] AABox* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_GetWorldSpaceSurfaceNormal([NativeTypeName("const JPH_Body *")] JPH_Body* body, [NativeTypeName("JPH_SubShapeID")] SubShapeID subShapeID, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Vec3 *")] float3* normal);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MotionProperties* JPH_Body_GetMotionProperties(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_MotionProperties* JPH_Body_GetMotionPropertiesUnchecked(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Body_SetUserData(JPH_Body* body, [NativeTypeName("uint64_t")] ulong userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_Body_GetUserData(JPH_Body* body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_Body_GetFixedToWorldBody();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BroadPhaseLayerFilter_Destroy(JPH_BroadPhaseLayerFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BroadPhaseLayerFilter* JPH_SpecifiedBroadPhaseLayerFilter_Create([NativeTypeName("JPH_BroadPhaseLayer")] BroadPhaseLayer layer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BroadPhaseLayerFilter* JPH_IncludeBroadPhaseLayerFilter_Create([NativeTypeName("JPH_BroadPhaseLayer *")] BroadPhaseLayer* layers, [NativeTypeName("uint8_t")] byte layerCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BroadPhaseLayerFilter* JPH_IgnoreBroadPhaseLayerFilter_Create([NativeTypeName("JPH_BroadPhaseLayer *")] BroadPhaseLayer* layers, [NativeTypeName("uint8_t")] byte layerCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ObjectLayerFilter_Destroy(JPH_ObjectLayerFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectLayerFilter* JPH_IncludeObjectLayerFilter_Create([NativeTypeName("JPH_ObjectLayer *")] ObjectLayer* layers, [NativeTypeName("int32_t")] int layerCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectLayerFilter* JPH_IgnoreObjectLayerFilter_Create([NativeTypeName("JPH_ObjectLayer *")] ObjectLayer* layers, [NativeTypeName("int32_t")] int layerCount);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyFilter_Destroy(JPH_BodyFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_IgnoreSingleBodyFilter* JPH_IgnoreSingleBodyFilter_Create([NativeTypeName("const JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_IgnoreMultipleBodiesFilter* JPH_IgnoreMultipleBodiesFilter_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_IgnoreMultipleBodiesFilter_Reserve(JPH_IgnoreMultipleBodiesFilter* filter, uint size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_IgnoreMultipleBodiesFilter_Clear(JPH_IgnoreMultipleBodiesFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_IgnoreMultipleBodiesFilter_IgnoreBody(JPH_IgnoreMultipleBodiesFilter* filter, [NativeTypeName("JPH_BodyID")] BodyID bodyID);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeFilter_SetProcs([NativeTypeName("const JPH_ShapeFilter_Procs *")] JPH_ShapeFilter_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ShapeFilter* JPH_ShapeFilter_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeFilter_Destroy(JPH_ShapeFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_ShapeFilter_GetBodyID2(JPH_ShapeFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeFilter_SetBodyID2(JPH_ShapeFilter* filter, [NativeTypeName("JPH_BodyID")] BodyID id);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SimShapeFilter_SetProcs([NativeTypeName("const JPH_SimShapeFilter_Procs *")] JPH_SimShapeFilter_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SimShapeFilter* JPH_SimShapeFilter_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SimShapeFilter_Destroy(JPH_SimShapeFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactListener_SetProcs([NativeTypeName("const JPH_ContactListener_Procs *")] JPH_ContactListener_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ContactListener* JPH_ContactListener_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactListener_Destroy(JPH_ContactListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyActivationListener_SetProcs([NativeTypeName("const JPH_BodyActivationListener_Procs *")] JPH_BodyActivationListener_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyActivationListener* JPH_BodyActivationListener_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyActivationListener_Destroy(JPH_BodyActivationListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyDrawFilter_SetProcs([NativeTypeName("const JPH_BodyDrawFilter_Procs *")] JPH_BodyDrawFilter_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyDrawFilter* JPH_BodyDrawFilter_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyDrawFilter_Destroy(JPH_BodyDrawFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactManifold_GetWorldSpaceNormal([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactManifold_GetPenetrationDepth([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_SubShapeID")]
        public static extern SubShapeID JPH_ContactManifold_GetSubShapeID1([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_SubShapeID")]
        public static extern SubShapeID JPH_ContactManifold_GetSubShapeID2([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ContactManifold_GetPointCount([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactManifold_GetWorldSpaceContactPointOn1([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold, uint index, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactManifold_GetWorldSpaceContactPointOn2([NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold, uint index, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactSettings_GetFriction(JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetFriction(JPH_ContactSettings* settings, float friction);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactSettings_GetRestitution(JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetRestitution(JPH_ContactSettings* settings, float restitution);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactSettings_GetInvMassScale1(JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetInvMassScale1(JPH_ContactSettings* settings, float scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactSettings_GetInvInertiaScale1(JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetInvInertiaScale1(JPH_ContactSettings* settings, float scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactSettings_GetInvMassScale2(JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetInvMassScale2(JPH_ContactSettings* settings, float scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ContactSettings_GetInvInertiaScale2(JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetInvInertiaScale2(JPH_ContactSettings* settings, float scale);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_ContactSettings_GetIsSensor([NativeTypeName("const JPH_ContactSettings *")] JPH_ContactSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetIsSensor(JPH_ContactSettings* settings, [NativeTypeName("bool")] NativeBool sensor);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_GetRelativeLinearSurfaceVelocity(JPH_ContactSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetRelativeLinearSurfaceVelocity(JPH_ContactSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_GetRelativeAngularSurfaceVelocity(JPH_ContactSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactSettings_SetRelativeAngularSurfaceVelocity(JPH_ContactSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_Destroy(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CharacterBase_GetCosMaxSlopeAngle(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_SetMaxSlopeAngle(JPH_CharacterBase* character, float maxSlopeAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_GetUp(JPH_CharacterBase* character, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_SetUp(JPH_CharacterBase* character, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterBase_IsSlopeTooSteep(JPH_CharacterBase* character, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Shape *")]
        public static extern JPH_Shape* JPH_CharacterBase_GetShape(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_GroundState")]
        public static extern GroundState JPH_CharacterBase_GetGroundState(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterBase_IsSupported(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_GetGroundPosition(JPH_CharacterBase* character, [NativeTypeName("JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_GetGroundNormal(JPH_CharacterBase* character, [NativeTypeName("JPH_Vec3 *")] float3* normal);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_GetGroundVelocity(JPH_CharacterBase* character, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_PhysicsMaterial *")]
        public static extern JPH_PhysicsMaterial* JPH_CharacterBase_GetGroundMaterial(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_CharacterBase_GetGroundBodyId(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_SubShapeID")]
        public static extern SubShapeID JPH_CharacterBase_GetGroundSubShapeId(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_CharacterBase_GetGroundUserData(JPH_CharacterBase* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_SaveState(JPH_CharacterBase* character, JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterBase_RestoreState(JPH_CharacterBase* character, JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterSettings_Init(JPH_CharacterSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Character* JPH_Character_Create([NativeTypeName("const JPH_CharacterSettings *")] JPH_CharacterSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("uint64_t")] ulong userData, JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_AddToPhysicsSystem(JPH_Character* character, [NativeTypeName("JPH_Activation")] Activation activationMode, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_RemoveFromPhysicsSystem(JPH_Character* character, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_Activate(JPH_Character* character, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_PostSimulation(JPH_Character* character, float maxSeparationDistance, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetLinearAndAngularVelocity(JPH_Character* character, [NativeTypeName("JPH_Vec3 *")] float3* linearVelocity, [NativeTypeName("JPH_Vec3 *")] float3* angularVelocity, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_GetLinearVelocity(JPH_Character* character, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetLinearVelocity(JPH_Character* character, [NativeTypeName("const JPH_Vec3 *")] float3* value, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_AddLinearVelocity(JPH_Character* character, [NativeTypeName("const JPH_Vec3 *")] float3* value, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_AddImpulse(JPH_Character* character, [NativeTypeName("const JPH_Vec3 *")] float3* value, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_Character_GetBodyID([NativeTypeName("const JPH_Character *")] JPH_Character* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_GetPositionAndRotation(JPH_Character* character, [NativeTypeName("JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Quat *")] quaternion* rotation, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetPositionAndRotation(JPH_Character* character, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_Activation")] Activation activationMode, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_GetPosition(JPH_Character* character, [NativeTypeName("JPH_RVec3 *")] rvec3* position, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetPosition(JPH_Character* character, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Activation")] Activation activationMode, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_GetRotation(JPH_Character* character, [NativeTypeName("JPH_Quat *")] quaternion* rotation, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetRotation(JPH_Character* character, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_Activation")] Activation activationMode, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_GetCenterOfMassPosition(JPH_Character* character, [NativeTypeName("JPH_RVec3 *")] rvec3* result, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_GetWorldTransform(JPH_Character* character, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ObjectLayer")]
        public static extern ObjectLayer JPH_Character_GetLayer([NativeTypeName("const JPH_Character *")] JPH_Character* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetLayer(JPH_Character* character, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer value, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Character_SetShape(JPH_Character* character, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, float maxPenetrationDepth, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtualSettings_Init(JPH_CharacterVirtualSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CharacterVirtual* JPH_CharacterVirtual_Create([NativeTypeName("const JPH_CharacterVirtualSettings *")] JPH_CharacterVirtualSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("uint64_t")] ulong userData, JPH_PhysicsSystem* system);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_CharacterID")]
        public static extern uint JPH_CharacterVirtual_GetID([NativeTypeName("const JPH_CharacterVirtual *")] JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetListener(JPH_CharacterVirtual* character, JPH_CharacterContactListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetCharacterVsCharacterCollision(JPH_CharacterVirtual* character, JPH_CharacterVsCharacterCollision* characterVsCharacterCollision);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetLinearVelocity(JPH_CharacterVirtual* character, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetLinearVelocity(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetPosition(JPH_CharacterVirtual* character, [NativeTypeName("JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetPosition(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetRotation(JPH_CharacterVirtual* character, [NativeTypeName("JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetRotation(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Quat *")] quaternion* rotation);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetWorldTransform(JPH_CharacterVirtual* character, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetCenterOfMassTransform(JPH_CharacterVirtual* character, [NativeTypeName("JPH_RMatrix4x4 *")] rmatrix4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CharacterVirtual_GetMass(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetMass(JPH_CharacterVirtual* character, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CharacterVirtual_GetMaxStrength(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetMaxStrength(JPH_CharacterVirtual* character, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CharacterVirtual_GetPenetrationRecoverySpeed(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetPenetrationRecoverySpeed(JPH_CharacterVirtual* character, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(JPH_CharacterVirtual* character, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CharacterVirtual_GetCharacterPadding(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_CharacterVirtual_GetMaxNumHits(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetMaxNumHits(JPH_CharacterVirtual* character, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_CharacterVirtual_GetHitReductionCosMaxAngle(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetHitReductionCosMaxAngle(JPH_CharacterVirtual* character, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_GetMaxHitsExceeded(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetShapeOffset(JPH_CharacterVirtual* character, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetShapeOffset(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_CharacterVirtual_GetUserData([NativeTypeName("const JPH_CharacterVirtual *")] JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetUserData(JPH_CharacterVirtual* character, [NativeTypeName("uint64_t")] ulong value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_CharacterVirtual_GetInnerBodyID([NativeTypeName("const JPH_CharacterVirtual *")] JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_CancelVelocityTowardsSteepSlopes(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Vec3 *")] float3* desiredVelocity, [NativeTypeName("JPH_Vec3 *")] float3* velocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_StartTrackingContactChanges(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_FinishTrackingContactChanges(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_Update(JPH_CharacterVirtual* character, float deltaTime, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, JPH_PhysicsSystem* system, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_ExtendedUpdate(JPH_CharacterVirtual* character, float deltaTime, [NativeTypeName("const JPH_ExtendedUpdateSettings *")] ExtendedUpdateSettings* settings, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, JPH_PhysicsSystem* system, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_RefreshContacts(JPH_CharacterVirtual* character, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, JPH_PhysicsSystem* system, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_CanWalkStairs(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Vec3 *")] float3* linearVelocity);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_WalkStairs(JPH_CharacterVirtual* character, float deltaTime, [NativeTypeName("const JPH_Vec3 *")] float3* stepUp, [NativeTypeName("const JPH_Vec3 *")] float3* stepForward, [NativeTypeName("const JPH_Vec3 *")] float3* stepForwardTest, [NativeTypeName("const JPH_Vec3 *")] float3* stepDownExtra, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, JPH_PhysicsSystem* system, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_StickToFloor(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Vec3 *")] float3* stepDown, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, JPH_PhysicsSystem* system, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_UpdateGroundVelocity(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_SetShape(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, float maxPenetrationDepth, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, JPH_PhysicsSystem* system, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_SetInnerBodyShape(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_CharacterVirtual_GetNumActiveContacts(JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVirtual_GetActiveContact(JPH_CharacterVirtual* character, uint index, JPH_CharacterVirtualContact* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_HasCollidedWithBody(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_BodyID")] BodyID body);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_HasCollidedWith(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_CharacterID")] uint other);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CharacterVirtual_HasCollidedWithCharacter(JPH_CharacterVirtual* character, [NativeTypeName("const JPH_CharacterVirtual *")] JPH_CharacterVirtual* other);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterContactListener_SetProcs([NativeTypeName("const JPH_CharacterContactListener_Procs *")] JPH_CharacterContactListener_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CharacterContactListener* JPH_CharacterContactListener_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterContactListener_Destroy(JPH_CharacterContactListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVsCharacterCollision_SetProcs([NativeTypeName("const JPH_CharacterVsCharacterCollision_Procs *")] JPH_CharacterVsCharacterCollision_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CharacterVsCharacterCollision* JPH_CharacterVsCharacterCollision_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_CharacterVsCharacterCollision* JPH_CharacterVsCharacterCollision_CreateSimple();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVsCharacterCollisionSimple_AddCharacter(JPH_CharacterVsCharacterCollision* characterVsCharacter, JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVsCharacterCollisionSimple_RemoveCharacter(JPH_CharacterVsCharacterCollision* characterVsCharacter, JPH_CharacterVirtual* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterVsCharacterCollision_Destroy(JPH_CharacterVsCharacterCollision* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CollisionDispatch_CollideShapeVsShape([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape2, [NativeTypeName("const JPH_Vec3 *")] float3* scale1, [NativeTypeName("const JPH_Vec3 *")] float3* scale2, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassTransform1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassTransform2, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* collideShapeSettings, [NativeTypeName("JPH_CollideShapeCollectorCallback *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_CollisionDispatch_CollideShapeVsShape2([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape2, [NativeTypeName("const JPH_Vec3 *")] float3* scale1, [NativeTypeName("const JPH_Vec3 *")] float3* scale2, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassTransform1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassTransform2, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* collideShapeSettings, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollideShapeResult *")] CollideShapeResult* resultArray, int resultArraySize, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CollisionDispatch_CastShapeVsShapeLocalSpace([NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape2, [NativeTypeName("const JPH_Vec3 *")] float3* scale1InShape2LocalSpace, [NativeTypeName("const JPH_Vec3 *")] float3* scale2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* centerOfMassTransform1InShape2LocalSpace, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* centerOfMassWorldTransform2, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* shapeCastSettings, [NativeTypeName("JPH_CastShapeCollectorCallback *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_CollisionDispatch_CastShapeVsShapeLocalSpace2([NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape2, [NativeTypeName("const JPH_Vec3 *")] float3* scale1InShape2LocalSpace, [NativeTypeName("const JPH_Vec3 *")] float3* scale2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* centerOfMassTransform1InShape2LocalSpace, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* centerOfMassWorldTransform2, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* shapeCastSettings, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_ShapeCastResult *")] ShapeCastResult* resultArray, int resultArraySize, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CollisionDispatch_CastShapeVsShapeWorldSpace([NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape2, [NativeTypeName("const JPH_Vec3 *")] float3* scale1, [NativeTypeName("const JPH_Vec3 *")] float3* inScale2, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassWorldTransform1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassWorldTransform2, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* shapeCastSettings, [NativeTypeName("JPH_CastShapeCollectorCallback *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_CollisionDispatch_CastShapeVsShapeWorldSpace2([NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape2, [NativeTypeName("const JPH_Vec3 *")] float3* scale1, [NativeTypeName("const JPH_Vec3 *")] float3* inScale2, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassWorldTransform1, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* centerOfMassWorldTransform2, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* shapeCastSettings, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_ShapeCastResult *")] ShapeCastResult* resultArray, int resultArraySize, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_SetProcs([NativeTypeName("const JPH_DebugRenderer_Procs *")] JPH_DebugRenderer_Procs* procs);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_DebugRenderer* JPH_DebugRenderer_Create(void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_Destroy(JPH_DebugRenderer* renderer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_NextFrame(JPH_DebugRenderer* renderer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_SetCameraPos(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* position);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawLine(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* from, [NativeTypeName("const JPH_RVec3 *")] rvec3* to, [NativeTypeName("JPH_Color")] uint color);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawWireBox(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_AABox *")] AABox* box, [NativeTypeName("JPH_Color")] uint color);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawWireBox2(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, [NativeTypeName("const JPH_AABox *")] AABox* box, [NativeTypeName("JPH_Color")] uint color);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawMarker(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("JPH_Color")] uint color, float size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawArrow(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* from, [NativeTypeName("const JPH_RVec3 *")] rvec3* to, [NativeTypeName("JPH_Color")] uint color, float size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawCoordinateSystem(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, float size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawPlane(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* point, [NativeTypeName("const JPH_Vec3 *")] float3* normal, [NativeTypeName("JPH_Color")] uint color, float size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawWireTriangle(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* v1, [NativeTypeName("const JPH_RVec3 *")] rvec3* v2, [NativeTypeName("const JPH_RVec3 *")] rvec3* v3, [NativeTypeName("JPH_Color")] uint color);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawWireSphere(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* center, float radius, [NativeTypeName("JPH_Color")] uint color, int level);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawWireUnitSphere(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, [NativeTypeName("JPH_Color")] uint color, int level);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawTriangle(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* v1, [NativeTypeName("const JPH_RVec3 *")] rvec3* v2, [NativeTypeName("const JPH_RVec3 *")] rvec3* v3, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawBox(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_AABox *")] AABox* box, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawBox2(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, [NativeTypeName("const JPH_AABox *")] AABox* box, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawSphere(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* center, float radius, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawUnitSphere(JPH_DebugRenderer* renderer, [NativeTypeName("JPH_RMatrix4x4")] rmatrix4x4 matrix, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawCapsule(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, float halfHeightOfCylinder, float radius, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawCylinder(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, float halfHeight, float radius, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawOpenCone(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* top, [NativeTypeName("const JPH_Vec3 *")] float3* axis, [NativeTypeName("const JPH_Vec3 *")] float3* perpendicular, float halfAngle, float length, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawSwingConeLimits(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, float swingYHalfAngle, float swingZHalfAngle, float edgeLength, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawSwingPyramidLimits(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* matrix, float minSwingYAngle, float maxSwingYAngle, float minSwingZAngle, float maxSwingZAngle, float edgeLength, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawPie(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RVec3 *")] rvec3* center, float radius, [NativeTypeName("const JPH_Vec3 *")] float3* normal, [NativeTypeName("const JPH_Vec3 *")] float3* axis, float minAngle, float maxAngle, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_DrawTaperedCylinder(JPH_DebugRenderer* renderer, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* inMatrix, float top, float bottom, float topRadius, float bottomRadius, [NativeTypeName("JPH_Color")] uint color, JPH_DebugRenderer_CastShadow castShadow, JPH_DebugRenderer_DrawMode drawMode);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Skeleton* JPH_Skeleton_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Skeleton_Destroy(JPH_Skeleton* skeleton);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Skeleton_AddJoint(JPH_Skeleton* skeleton, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Skeleton_AddJoint2(JPH_Skeleton* skeleton, [NativeTypeName("const char *")] sbyte* name, int parentIndex);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_Skeleton_AddJoint3(JPH_Skeleton* skeleton, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* parentName);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_Skeleton_GetJointCount([NativeTypeName("const JPH_Skeleton *")] JPH_Skeleton* skeleton);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Skeleton_GetJoint([NativeTypeName("const JPH_Skeleton *")] JPH_Skeleton* skeleton, int index, JPH_SkeletonJoint* joint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_Skeleton_GetJointIndex([NativeTypeName("const JPH_Skeleton *")] JPH_Skeleton* skeleton, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Skeleton_CalculateParentJointIndices(JPH_Skeleton* skeleton);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Skeleton_AreJointsCorrectlyOrdered([NativeTypeName("const JPH_Skeleton *")] JPH_Skeleton* skeleton);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_RagdollSettings* JPH_RagdollSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RagdollSettings_Destroy(JPH_RagdollSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const JPH_Skeleton *")]
        public static extern JPH_Skeleton* JPH_RagdollSettings_GetSkeleton([NativeTypeName("const JPH_RagdollSettings *")] JPH_RagdollSettings* character);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RagdollSettings_SetSkeleton(JPH_RagdollSettings* character, JPH_Skeleton* skeleton);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_RagdollSettings_Stabilize(JPH_RagdollSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RagdollSettings_DisableParentChildCollisions(JPH_RagdollSettings* settings, [NativeTypeName("const JPH_Matrix4x4 *")] float4x4* jointMatrices, float minSeparationDistance);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(JPH_RagdollSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int JPH_RagdollSettings_GetConstraintIndexForBodyIndex(JPH_RagdollSettings* settings, int bodyIndex);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(JPH_RagdollSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Ragdoll* JPH_RagdollSettings_CreateRagdoll(JPH_RagdollSettings* settings, JPH_PhysicsSystem* system, [NativeTypeName("JPH_CollisionGroupID")] uint collisionGroup, [NativeTypeName("uint64_t")] ulong userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Ragdoll_Destroy(JPH_Ragdoll* ragdoll);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Ragdoll_AddToPhysicsSystem(JPH_Ragdoll* ragdoll, [NativeTypeName("JPH_Activation")] Activation activationMode, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Ragdoll_RemoveFromPhysicsSystem(JPH_Ragdoll* ragdoll, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Ragdoll_Activate(JPH_Ragdoll* ragdoll, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Ragdoll_IsActive([NativeTypeName("const JPH_Ragdoll *")] JPH_Ragdoll* ragdoll, [NativeTypeName("bool")] NativeBool lockBodies);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_Ragdoll_ResetWarmStart(JPH_Ragdoll* ragdoll);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_EstimateCollisionResponse([NativeTypeName("const JPH_Body *")] JPH_Body* body1, [NativeTypeName("const JPH_Body *")] JPH_Body* body2, [NativeTypeName("const JPH_ContactManifold *")] JPH_ContactManifold* manifold, float combinedFriction, float combinedRestitution, float minVelocityForRestitution, uint numIterations, [NativeTypeName("JPH_CollisionEstimationResult *")] CollisionEstimationResult* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_WheelSettingsWV* JPH_WheelSettingsWV_Create([NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Vec3 *")] float3* suspensionForcePoint, [NativeTypeName("const JPH_Vec3 *")] float3* suspensionDirection, [NativeTypeName("const JPH_Vec3 *")] float3* steeringAxis, [NativeTypeName("const JPH_Vec3 *")] float3* wheelUp, [NativeTypeName("const JPH_Vec3 *")] float3* wheelForward, float suspensionMinLength, float suspensionMaxLength, float suspensionPreloadLength, [NativeTypeName("const JPH_SpringSettings *")] SpringSettings* suspensionSpring, float radius, float width, [NativeTypeName("bool")] NativeBool enableSuspensionForcePoint, float inertia, float angularDamping, float maxSteerAngle, float maxBrakeTorque, float maxHandBrakeTorque);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheelSettingsWV_Destroy(JPH_WheelSettingsWV* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_WheelWV* JPH_WheelWV_Create([NativeTypeName("const JPH_WheelSettingsWV *")] JPH_WheelSettingsWV* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheelWV_Destroy(JPH_WheelWV* wheel);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_WheelWV_HasContact([NativeTypeName("const JPH_WheelWV *")] JPH_WheelWV* wheel);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_WheelWV_HasHitHardPoint([NativeTypeName("const JPH_WheelWV *")] JPH_WheelWV* wheel);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleEngineSettings* JPH_VehicleEngineSettings_Create(float maxTorque, float minRPM, float maxRPM, float inertia, float angularDamping);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleEngineSettings_Destroy(JPH_VehicleEngineSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleTransmissionSettings* JPH_VehicleTransmissionSettings_Create(JPH_TransmissionMode mode, float switchTime, float clutchReleaseTime, float switchLatency, float shiftUpRPM, float shiftDownRPM, float clutchStrength);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleTransmissionSettings_Destroy(JPH_VehicleTransmissionSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleCollisionTesterRay* JPH_VehicleCollisionTesterRay_Create([NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, [NativeTypeName("const JPH_Vec3 *")] float3* up, float maxSlopeAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleCollisionTesterRay_Destroy(JPH_VehicleCollisionTesterRay* tester);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleCollisionTesterCastSphere* JPH_VehicleCollisionTesterCastSphere_Create([NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, float radius, [NativeTypeName("const JPH_Vec3 *")] float3* up, float maxSlopeAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleCollisionTesterCastSphere_Destroy(JPH_VehicleCollisionTesterCastSphere* tester);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleCollisionTesterCastCylinder* JPH_VehicleCollisionTesterCastCylinder_Create([NativeTypeName("JPH_ObjectLayer")] ObjectLayer layer, float convexRadiusFraction);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleCollisionTesterCastCylinder_Destroy(JPH_VehicleCollisionTesterCastCylinder* tester);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleConstraintSettings* JPH_VehicleConstraintSettings_Create([NativeTypeName("const JPH_Vec3 *")] float3* up, [NativeTypeName("const JPH_Vec3 *")] float3* forward, float maxPitchRollAngle, JPH_WheelSettingsWV** wheels, int wheelsCount, JPH_VehicleControllerSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleConstraintSettings_Destroy(JPH_VehicleConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_VehicleConstraint* JPH_VehicleConstraint_Create(JPH_Body* body, [NativeTypeName("const JPH_VehicleConstraintSettings *")] JPH_VehicleConstraintSettings* constraintSettings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleConstraint_Destroy(JPH_VehicleConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PhysicsStepListener* JPH_VehicleConstraint_AsPhysicsStepListener(JPH_VehicleConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_WheeledVehicleController* JPH_VehicleConstraint_GetWheeledVehicleController(JPH_VehicleConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_VehicleConstraint_SetVehicleCollisionTester(JPH_VehicleConstraint* constraint, [NativeTypeName("const JPH_VehicleCollisionTester *")] JPH_VehicleCollisionTester* tester);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_WheeledVehicleControllerSettings* JPH_WheeledVehicleControllerSettings_Create([NativeTypeName("const JPH_VehicleEngineSettings *")] JPH_VehicleEngineSettings* engine, [NativeTypeName("const JPH_VehicleTransmissionSettings *")] JPH_VehicleTransmissionSettings* transmission, float differentialLimitedSlipRatio);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheeledVehicleControllerSettings_Destroy(JPH_WheeledVehicleControllerSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Constraint* JPH_WheeledVehicleController_GetConstraint(JPH_WheeledVehicleController* vehicle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheeledVehicleController_SetForwardInput(JPH_WheeledVehicleController* vehicle, float forward);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_WheeledVehicleController_GetForwardInput([NativeTypeName("const JPH_WheeledVehicleController *")] JPH_WheeledVehicleController* vehicle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheeledVehicleController_SetRightInput(JPH_WheeledVehicleController* vehicle, float rightRatio);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_WheeledVehicleController_GetRightInput([NativeTypeName("const JPH_WheeledVehicleController *")] JPH_WheeledVehicleController* vehicle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheeledVehicleController_SetBrakeInput(JPH_WheeledVehicleController* vehicle, float brakeInput);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_WheeledVehicleController_GetBrakeInput([NativeTypeName("const JPH_WheeledVehicleController *")] JPH_WheeledVehicleController* vehicle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_WheeledVehicleController_SetHandBrakeInput(JPH_WheeledVehicleController* vehicle, float handBrakeInput);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_WheeledVehicleController_GetHandBrakeInput([NativeTypeName("const JPH_WheeledVehicleController *")] JPH_WheeledVehicleController* vehicle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_StateRecorder* JPH_StateRecorder_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorder_Destroy(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorder_SetValidating(JPH_StateRecorder* recorder, [NativeTypeName("bool")] NativeBool validating);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_StateRecorder_IsValidating(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorder_Rewind(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorder_Clear(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_StateRecorder_IsEOF(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_StateRecorder_IsFailed(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_StateRecorder_IsEqual(JPH_StateRecorder* recorder, JPH_StateRecorder* other);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorder_WriteBytes(JPH_StateRecorder* recorder, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] ulong size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorder_ReadBytes(JPH_StateRecorder* recorder, void* data, [NativeTypeName("size_t")] ulong size);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern ulong JPH_StateRecorder_GetSize(JPH_StateRecorder* recorder);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_StateRecorderFilter* JPH_StateRecorderFilter_Create(JPH_StateRecorderFilter_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_StateRecorderFilter_Destroy(JPH_StateRecorderFilter* filter);
    }
}
