using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
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
        _JPH_DebugRenderer_JPH_DebugRenderer_DrawMode_Count,
        _JPH_DebugRenderer_JPH_DebugRenderer_DrawMode_Force32 = 0x7FFFFFFF,
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
    internal unsafe delegate float JPH_CastRayCollector(void* context, [NativeTypeName("const JPH_RayCastResult *")] RayCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_RayCastBodyCollector(void* context, [NativeTypeName("const JPH_BroadPhaseCastResult *")] BroadPhaseCastResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CollideShapeBodyCollector(void* context, [NativeTypeName("const JPH_BodyID")] BodyID result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CollidePointCollector(void* context, [NativeTypeName("const JPH_CollidePointResult *")] CollidePointResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CollideShapeCollector(void* context, [NativeTypeName("const JPH_CollideShapeResult *")] CollideShapeResult* result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate float JPH_CastShapeCollector(void* context, [NativeTypeName("const JPH_ShapeCastResult *")] ShapeCastResult* result);

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

    internal partial struct JPH_ShapeFilter
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

    internal partial struct JPH_ConstraintSettings
    {
    }

    internal partial struct JPH_FixedConstraintSettings
    {
    }

    internal partial struct JPH_TwoBodyConstraintSettings
    {
    }

    internal partial struct JPH_DistanceConstraintSettings
    {
    }

    internal partial struct JPH_HingeConstraintSettings
    {
    }

    internal partial struct JPH_SliderConstraintSettings
    {
    }

    internal partial struct JPH_PointConstraintSettings
    {
    }

    internal partial struct JPH_ConeConstraintSettings
    {
    }

    internal partial struct JPH_SwingTwistConstraintSettings
    {
    }

    internal partial struct JPH_SixDOFConstraintSettings
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

    internal partial struct JPH_ContactListener
    {
    }

    internal partial struct JPH_ContactManifold
    {
    }

    internal partial struct JPH_ContactSettings
    {
    }

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

    internal partial struct JPH_StateRecorder
    {
    }

    internal partial struct JPH_StateRecorderFilter
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

    internal partial struct JPH_CharacterBase
    {
    }

    internal partial struct JPH_CharacterSettings
    {
        public JPH_CharacterBaseSettings @base;

        [NativeTypeName("JPH_ObjectLayer")]
        public ObjectLayer layer;

        public float mass;

        public float friction;

        public float gravityFactor;
    }

    internal partial struct JPH_Character
    {
    }

    internal unsafe partial struct JPH_CharacterVirtualSettings
    {
        public JPH_CharacterBaseSettings @base;

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

    internal partial struct JPH_CharacterContactListener
    {
    }

    internal partial struct JPH_CharacterVirtual
    {
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

    internal partial struct JPH_PhysicsSettings
    {
        public int maxInFlightBodyPairs;

        public int stepListenersBatchSize;

        public int stepListenerBatchesPerJob;

        public float baumgarte;

        public float speculativeContactDistance;

        public float penetrationSlop;

        public float linearCastThreshold;

        public float linearCastMaxPenetration;

        public float manifoldToleranceSq;

        public float maxPenetrationDistance;

        public float bodyPairCacheMaxDeltaPositionSq;

        public float bodyPairCacheCosMaxDeltaRotationDiv2;

        public float contactNormalCosMaxDeltaRotation;

        public float contactPointPreserveLambdaMaxDistSq;

        public uint numVelocitySteps;

        public uint numPositionSteps;

        public float minVelocityForRestitution;

        public float timeBeforeSleep;

        public float pointVelocitySleepThreshold;

        [NativeTypeName("bool")]
        public NativeBool deterministicSimulation;

        [NativeTypeName("bool")]
        public NativeBool constraintWarmStart;

        [NativeTypeName("bool")]
        public NativeBool useBodyPairContactCache;

        [NativeTypeName("bool")]
        public NativeBool useManifoldReduction;

        [NativeTypeName("bool")]
        public NativeBool useLargeIslandSplitter;

        [NativeTypeName("bool")]
        public NativeBool allowSleeping;

        [NativeTypeName("bool")]
        public NativeBool checkActiveEdges;
    }

    internal partial struct JPH_BroadPhaseLayerFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, JPH_BroadPhaseLayer &) __attribute__((cdecl))")]
        public IntPtr ShouldCollide;
    }

    internal partial struct JPH_ObjectLayerFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, JPH_ObjectLayer &) __attribute__((cdecl))")]
        public IntPtr ShouldCollide;
    }

    internal partial struct JPH_BodyFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, JPH_BodyID) __attribute__((cdecl))")]
        public IntPtr ShouldCollide;

        [NativeTypeName("bool (*)(void *, const JPH_Body *) __attribute__((cdecl))")]
        public IntPtr ShouldCollideLocked;
    }

    internal partial struct JPH_ShapeFilter_Procs
    {
        [NativeTypeName("bool (*)(void *, const JPH_Shape *, const JPH_SubShapeID *) __attribute__((cdecl))")]
        public IntPtr ShouldCollide;

        [NativeTypeName("bool (*)(void *, const JPH_Shape *, const JPH_SubShapeID *, const JPH_Shape *, const JPH_SubShapeID *) __attribute__((cdecl))")]
        public IntPtr ShouldCollide2;
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
        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_Body *, const JPH_Vec3 *, const JPH_Vec3 *) __attribute__((cdecl))")]
        public IntPtr OnAdjustBodyVelocity;

        [NativeTypeName("bool (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID) __attribute__((cdecl))")]
        public IntPtr OnContactValidate;

        [NativeTypeName("bool (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactValidate;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, JPH_CharacterContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnContactAdded;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, JPH_CharacterContactSettings *) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactAdded;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_BodyID, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, const JPH_Vec3 *, const JPH_PhysicsMaterial *, const JPH_Vec3 *, JPH_Vec3 *) __attribute__((cdecl))")]
        public IntPtr OnContactSolve;

        [NativeTypeName("void (*)(void *, const JPH_CharacterVirtual *, const JPH_CharacterVirtual *, const JPH_SubShapeID, const JPH_RVec3 *, const JPH_Vec3 *, const JPH_Vec3 *, const JPH_PhysicsMaterial *, const JPH_Vec3 *, JPH_Vec3 *) __attribute__((cdecl))")]
        public IntPtr OnCharacterContactSolve;
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

    internal partial struct JPH_DebugRenderer_Procs
    {
        [NativeTypeName("void (*)(void *, const JPH_RVec3 *, const JPH_RVec3 *, JPH_Color) __attribute__((cdecl))")]
        public IntPtr DrawLine;

        [NativeTypeName("void (*)(void *, const JPH_RVec3 *, const JPH_RVec3 *, const JPH_RVec3 *, JPH_Color, JPH_DebugRenderer_CastShadow) __attribute__((cdecl))")]
        public IntPtr DrawTriangle;

        [NativeTypeName("void (*)(void *, const JPH_RVec3 *, const char *, JPH_Color, float) __attribute__((cdecl))")]
        public IntPtr DrawText3D;
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
        public static extern void JPH_PhysicsSystem_SetPhysicsSettings(JPH_PhysicsSystem* system, JPH_PhysicsSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsSystem_GetPhysicsSettings(JPH_PhysicsSystem* system, JPH_PhysicsSettings* result);

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
        public static extern JPH_PhysicsMaterial* JPH_PhysicsMaterial_Create([NativeTypeName("const char *")] sbyte* name, uint color);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PhysicsMaterial_Destroy(JPH_PhysicsMaterial* material);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JPH_PhysicsMaterial_GetDebugName([NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_PhysicsMaterial_GetDebugColor([NativeTypeName("const JPH_PhysicsMaterial *")] JPH_PhysicsMaterial* material);

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
        public static extern float JPH_Shape_GetVolume([NativeTypeName("const JPH_Shape *")] JPH_Shape* shape);

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
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_MeshShapeSettings_GetPerTriangleUserData([NativeTypeName("const JPH_MeshShapeSettings *")] JPH_MeshShapeSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_MeshShapeSettings_SetPerTriangleUserData(JPH_MeshShapeSettings* settings, [NativeTypeName("bool")] NativeBool perTriangleUserData);

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
        public static extern void JPH_CompoundShapeSettings_AddShape(JPH_CompoundShapeSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_ShapeSettings *")] JPH_ShapeSettings* shape, uint userData);

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
        public static extern uint JPH_MutableCompoundShape_AddShape(JPH_MutableCompoundShape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("const JPH_Shape *")] JPH_Shape* child, uint userData);

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
        public static extern JPH_BodyCreationSettings* JPH_BodyCreationSettings_Create2(JPH_ShapeSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* position, [NativeTypeName("const JPH_Quat *")] quaternion* rotation, [NativeTypeName("JPH_MotionType")] MotionType motionType, [NativeTypeName("JPH_ObjectLayer")] ObjectLayer objectLayer);

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
        [return: NativeTypeName("JPH_MotionType")]
        public static extern MotionType JPH_BodyCreationSettings_GetMotionType(JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMotionType(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_MotionType")] MotionType value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_MotionQuality")]
        public static extern MotionQuality JPH_BodyCreationSettings_GetMotionQuality(JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetMotionQuality(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_MotionQuality")] MotionQuality value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_AllowedDOFs")]
        public static extern AllowedDOFs JPH_BodyCreationSettings_GetAllowedDOFs(JPH_BodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyCreationSettings_SetAllowedDOFs(JPH_BodyCreationSettings* settings, [NativeTypeName("JPH_AllowedDOFs")] AllowedDOFs value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SoftBodyCreationSettings* JPH_SoftBodyCreationSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SoftBodyCreationSettings_Destroy(JPH_SoftBodyCreationSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConstraintSettings_Destroy(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_ConstraintSettings_GetEnabled(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetEnabled(JPH_ConstraintSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConstraintSettings_GetConstraintPriority(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetConstraintPriority(JPH_ConstraintSettings* settings, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConstraintSettings_GetNumVelocityStepsOverride(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConstraintSettings_SetNumVelocityStepsOverride(JPH_ConstraintSettings* settings, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint JPH_ConstraintSettings_GetNumPositionStepsOverride(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConstraintSettings_SetNumPositionStepsOverride(JPH_ConstraintSettings* settings, uint value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConstraintSettings_GetDrawConstraintSize(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConstraintSettings_SetDrawConstraintSize(JPH_ConstraintSettings* settings, float value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong JPH_ConstraintSettings_GetUserData(JPH_ConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConstraintSettings_SetUserData(JPH_ConstraintSettings* settings, [NativeTypeName("uint64_t")] ulong value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ConstraintSettings* JPH_Constraint_GetConstraintSettings(JPH_Constraint* constraint);

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
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_Constraint_GetEnabled(JPH_Constraint* constraint);

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
        public static extern void JPH_Constraint_Destroy(JPH_Constraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_FixedConstraintSettings* JPH_FixedConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ConstraintSpace")]
        public static extern ConstraintSpace JPH_FixedConstraintSettings_GetSpace(JPH_FixedConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetSpace(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_FixedConstraintSettings_GetAutoDetectPoint(JPH_FixedConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetAutoDetectPoint(JPH_FixedConstraintSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_GetPoint1(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetPoint1(JPH_FixedConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_GetAxisX1(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetAxisX1(JPH_FixedConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_GetAxisY1(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetAxisY1(JPH_FixedConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_GetPoint2(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetPoint2(JPH_FixedConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_GetAxisX2(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetAxisX2(JPH_FixedConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_GetAxisY2(JPH_FixedConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraintSettings_SetAxisY2(JPH_FixedConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_FixedConstraint* JPH_FixedConstraintSettings_CreateConstraint(JPH_FixedConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_FixedConstraint *")] JPH_FixedConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_FixedConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_FixedConstraint *")] JPH_FixedConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_DistanceConstraintSettings* JPH_DistanceConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ConstraintSpace")]
        public static extern ConstraintSpace JPH_DistanceConstraintSettings_GetSpace(JPH_DistanceConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraintSettings_SetSpace(JPH_DistanceConstraintSettings* settings, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraintSettings_GetPoint1(JPH_DistanceConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraintSettings_SetPoint1(JPH_DistanceConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraintSettings_GetPoint2(JPH_DistanceConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DistanceConstraintSettings_SetPoint2(JPH_DistanceConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_DistanceConstraint* JPH_DistanceConstraintSettings_CreateConstraint(JPH_DistanceConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

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
        public static extern JPH_PointConstraintSettings* JPH_PointConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_ConstraintSpace")]
        public static extern ConstraintSpace JPH_PointConstraintSettings_GetSpace(JPH_PointConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraintSettings_SetSpace(JPH_PointConstraintSettings* settings, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraintSettings_GetPoint1(JPH_PointConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraintSettings_SetPoint1(JPH_PointConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraintSettings_GetPoint2(JPH_PointConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraintSettings_SetPoint2(JPH_PointConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_PointConstraint* JPH_PointConstraintSettings_CreateConstraint(JPH_PointConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_SetPoint1(JPH_PointConstraint* constraint, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space, [NativeTypeName("JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_SetPoint2(JPH_PointConstraint* constraint, [NativeTypeName("JPH_ConstraintSpace")] ConstraintSpace space, [NativeTypeName("JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PointConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_PointConstraint *")] JPH_PointConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_HingeConstraintSettings* JPH_HingeConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_GetPoint1(JPH_HingeConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_SetPoint1(JPH_HingeConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_GetPoint2(JPH_HingeConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_SetPoint2(JPH_HingeConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_SetHingeAxis1(JPH_HingeConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_GetHingeAxis1(JPH_HingeConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_SetNormalAxis1(JPH_HingeConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_GetNormalAxis1(JPH_HingeConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_SetHingeAxis2(JPH_HingeConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_GetHingeAxis2(JPH_HingeConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_SetNormalAxis2(JPH_HingeConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_HingeConstraintSettings_GetNormalAxis2(JPH_HingeConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_HingeConstraint* JPH_HingeConstraintSettings_CreateConstraint(JPH_HingeConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_HingeConstraintSettings* JPH_HingeConstraint_GetSettings(JPH_HingeConstraint* constraint);

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
        public static extern void JPH_HingeConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint, float* x, float* y);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetTotalLambdaRotationLimits([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_HingeConstraint_GetTotalLambdaMotor([NativeTypeName("const JPH_HingeConstraint *")] JPH_HingeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SliderConstraintSettings* JPH_SliderConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetSliderAxis(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* axis);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_SliderConstraintSettings_GetAutoDetectPoint(JPH_SliderConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetAutoDetectPoint(JPH_SliderConstraintSettings* settings, [NativeTypeName("bool")] NativeBool value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_GetPoint1(JPH_SliderConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetPoint1(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_GetPoint2(JPH_SliderConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetPoint2(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetSliderAxis1(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_GetSliderAxis1(JPH_SliderConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetNormalAxis1(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_GetNormalAxis1(JPH_SliderConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetSliderAxis2(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_GetSliderAxis2(JPH_SliderConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_SetNormalAxis2(JPH_SliderConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraintSettings_GetNormalAxis2(JPH_SliderConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SliderConstraint* JPH_SliderConstraintSettings_CreateConstraint(JPH_SliderConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SliderConstraintSettings* JPH_SliderConstraint_GetSettings(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetCurrentPosition(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetMaxFrictionForce(JPH_SliderConstraint* constraint, float frictionForce);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetMaxFrictionForce(JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_SetMotorSettings(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetMotorSettings(JPH_SliderConstraint* constraint, [NativeTypeName("JPH_MotorSettings *")] MotorSettings* result);

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
        public static extern void JPH_SliderConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint, float* x, float* y);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetTotalLambdaPositionLimits([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_SliderConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_SliderConstraint_GetTotalLambdaMotor([NativeTypeName("const JPH_SliderConstraint *")] JPH_SliderConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ConeConstraintSettings* JPH_ConeConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_GetPoint1(JPH_ConeConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_SetPoint1(JPH_ConeConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_GetPoint2(JPH_ConeConstraintSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_SetPoint2(JPH_ConeConstraintSettings* settings, [NativeTypeName("const JPH_RVec3 *")] rvec3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_SetTwistAxis1(JPH_ConeConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_GetTwistAxis1(JPH_ConeConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_SetTwistAxis2(JPH_ConeConstraintSettings* settings, [NativeTypeName("const JPH_Vec3 *")] float3* value);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_GetTwistAxis2(JPH_ConeConstraintSettings* settings, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraintSettings_SetHalfConeAngle(JPH_ConeConstraintSettings* settings, float halfConeAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConeConstraintSettings_GetHalfConeAngle(JPH_ConeConstraintSettings* settings);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ConeConstraint* JPH_ConeConstraintSettings_CreateConstraint(JPH_ConeConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraint_SetHalfConeAngle(JPH_ConeConstraint* constraint, float halfConeAngle);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConeConstraint_GetCosHalfConeAngle([NativeTypeName("const JPH_ConeConstraint *")] JPH_ConeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ConeConstraint_GetTotalLambdaPosition([NativeTypeName("const JPH_ConeConstraint *")] JPH_ConeConstraint* constraint, [NativeTypeName("JPH_Vec3 *")] float3* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float JPH_ConeConstraint_GetTotalLambdaRotation([NativeTypeName("const JPH_ConeConstraint *")] JPH_ConeConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SwingTwistConstraintSettings* JPH_SwingTwistConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SwingTwistConstraint* JPH_SwingTwistConstraintSettings_CreateConstraint(JPH_SwingTwistConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

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
        public static extern JPH_SixDOFConstraintSettings* JPH_SixDOFConstraintSettings_Create();

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_SixDOFConstraint* JPH_SixDOFConstraintSettings_CreateConstraint(JPH_SixDOFConstraintSettings* settings, JPH_Body* body1, JPH_Body* body2);

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
        public static extern JPH_Body* JPH_TwoBodyConstraint_GetBody1(JPH_TwoBodyConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_Body* JPH_TwoBodyConstraint_GetBody2(JPH_TwoBodyConstraint* constraint);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TwoBodyConstraint_GetConstraintToBody1Matrix(JPH_TwoBodyConstraint* constraint, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_TwoBodyConstraint_GetConstraintToBody2Matrix(JPH_TwoBodyConstraint* constraint, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* result);

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
        public static extern NativeBool JPH_BroadPhaseQuery_CastRay([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_RayCastBodyCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CastRay2([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_RayCastBodyResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CollideAABox([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_AABox *")] AABox* box, [NativeTypeName("JPH_CollideShapeBodyCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CollideSphere([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* center, float radius, [NativeTypeName("JPH_CollideShapeBodyCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_BroadPhaseQuery_CollidePoint([NativeTypeName("const JPH_BroadPhaseQuery *")] JPH_BroadPhaseQuery* query, [NativeTypeName("const JPH_Vec3 *")] float3* point, [NativeTypeName("JPH_CollideShapeBodyCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastRay([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("JPH_RayCastResult *")] RayCastResult* hit, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastRay2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_RayCastSettings *")] RayCastSettings* rayCastSettings, [NativeTypeName("JPH_CastRayCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastRay3([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* origin, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_RayCastSettings *")] RayCastSettings* rayCastSettings, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CastRayResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollidePoint([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* point, [NativeTypeName("JPH_CollidePointCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollidePoint2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_RVec3 *")] rvec3* point, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollidePointResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollideShape([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollideShapeCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollideShape2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CollideShapeResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CollideShapeWithInternalEdgeRemoval([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_Vec3 *")] float3* scale, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* centerOfMassTransform, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollideShapeCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastShape([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CastShapeCollector *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastShape2([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CastShapeResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_NarrowPhaseQuery_CastShapeIgnoreInitialOverlap([NativeTypeName("const JPH_NarrowPhaseQuery *")] JPH_NarrowPhaseQuery* query, [NativeTypeName("const JPH_Shape *")] JPH_Shape* shape, [NativeTypeName("const JPH_RMatrix4x4 *")] rmatrix4x4* worldTransform, [NativeTypeName("const JPH_Vec3 *")] float3* direction, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* settings, [NativeTypeName("JPH_RVec3 *")] rvec3* baseOffset, [NativeTypeName("JPH_CollisionCollectorType")] CollisionCollectorType collectorType, [NativeTypeName("JPH_CastShapeResultCallback *")] IntPtr callback, void* userData, JPH_BroadPhaseLayerFilter* broadPhaseLayerFilter, JPH_ObjectLayerFilter* objectLayerFilter, [NativeTypeName("const JPH_BodyFilter *")] JPH_BodyFilter* bodyFilter, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* shapeFilter);

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
        public static extern JPH_BroadPhaseLayerFilter* JPH_BroadPhaseLayerFilter_Create(JPH_BroadPhaseLayerFilter_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BroadPhaseLayerFilter_Destroy(JPH_BroadPhaseLayerFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ObjectLayerFilter* JPH_ObjectLayerFilter_Create(JPH_ObjectLayerFilter_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ObjectLayerFilter_Destroy(JPH_ObjectLayerFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyFilter* JPH_BodyFilter_Create(JPH_BodyFilter_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyFilter_Destroy(JPH_BodyFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ShapeFilter* JPH_ShapeFilter_Create(JPH_ShapeFilter_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeFilter_Destroy(JPH_ShapeFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("JPH_BodyID")]
        public static extern BodyID JPH_ShapeFilter_GetBodyID2(JPH_ShapeFilter* filter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ShapeFilter_SetBodyID2(JPH_ShapeFilter* filter, [NativeTypeName("JPH_BodyID")] BodyID id);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_ContactListener* JPH_ContactListener_Create(JPH_ContactListener_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_ContactListener_Destroy(JPH_ContactListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyActivationListener* JPH_BodyActivationListener_Create(JPH_BodyActivationListener_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_BodyActivationListener_Destroy(JPH_BodyActivationListener* listener);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_BodyDrawFilter* JPH_BodyDrawFilter_Create(JPH_BodyDrawFilter_Procs procs, void* userData);

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
        public static extern NativeBool JPH_ContactSettings_GetIsSensor(JPH_ContactSettings* settings);

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
        public static extern void JPH_CharacterVirtual_SetListener(JPH_CharacterVirtual* character, JPH_CharacterContactListener* listener);

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
        public static extern JPH_CharacterContactListener* JPH_CharacterContactListener_Create(JPH_CharacterContactListener_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterContactListener_Destroy(JPH_CharacterContactListener* listener);

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

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CollisionDispatch_CollideShapeVsShape([NativeTypeName("const JPH_Shape *")] JPH_Shape* inShape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* inShape2, [NativeTypeName("JPH_Vec3 *")] float3* inScale1, [NativeTypeName("JPH_Vec3 *")] float3* inScale2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* inCenterOfMassTransform1, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* inCenterOfMassTransform2, [NativeTypeName("const JPH_CollideShapeSettings *")] CollideShapeSettings* inCollideShapeSettings, [NativeTypeName("JPH_CollideShapeCollector *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* inShapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CollisionDispatch_CastShapeVsShapeLocalSpace([NativeTypeName("JPH_Vec3 *")] float3* inDirection, [NativeTypeName("const JPH_Shape *")] JPH_Shape* inShape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* inShape2, [NativeTypeName("JPH_Vec3 *")] float3* inScale1InShape2LocalSpace, [NativeTypeName("JPH_Vec3 *")] float3* inScale2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* inCenterOfMassTransform1InShape2LocalSpace, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* inCenterOfMassWorldTransform2, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* inShapeCastSettings, [NativeTypeName("JPH_CastShapeCollector *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* inShapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern NativeBool JPH_CollisionDispatch_CastShapeVsShapeWorldSpace([NativeTypeName("JPH_Vec3 *")] float3* inDirection, [NativeTypeName("const JPH_Shape *")] JPH_Shape* inShape1, [NativeTypeName("const JPH_Shape *")] JPH_Shape* inShape2, [NativeTypeName("JPH_Vec3 *")] float3* inScale1, [NativeTypeName("JPH_Vec3 *")] float3* inScale2, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* inCenterOfMassWorldTransform1, [NativeTypeName("JPH_Matrix4x4 *")] float4x4* inCenterOfMassWorldTransform2, [NativeTypeName("const JPH_ShapeCastSettings *")] ShapeCastSettings* inShapeCastSettings, [NativeTypeName("JPH_CastShapeCollector *")] IntPtr callback, void* userData, [NativeTypeName("const JPH_ShapeFilter *")] JPH_ShapeFilter* inShapeFilter);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern JPH_DebugRenderer* JPH_DebugRenderer_Create(JPH_DebugRenderer_Procs procs, void* userData);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_Destroy(JPH_DebugRenderer* renderer);

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_DebugRenderer_NextFrame(JPH_DebugRenderer* renderer);

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
    }
}
