using Unity.Mathematics;
using UnityEngine;
using static Jolt.Bindings;

namespace Jolt
{
    public unsafe struct CharacterVirtualSettings
    {
        public void Init()
        {
            JPH_CharacterVirtualSettings native;
            JPH_CharacterVirtualSettings_Init(&native);

            Up = native.@base.up;
            SupportingVolume = native.@base.supportingVolume;
            MaxSlopeAngle = native.@base.maxSlopeAngle;
            EnhancedInternalEdgeRemoval = native.@base.enhancedInternalEdgeRemoval;
            //Shape = native.@base.shape;

            Mass = native.mass;
            MaxStrength = native.maxStrength;
            ShapeOffset = native.shapeOffset;
            BackFaceMode = native.backFaceMode;
            PredictiveContactDistance = native.predictiveContactDistance;
            MaxCollisionIterations = native.maxCollisionIterations;
            MaxConstraintIterations = native.maxConstraintIterations;
            MinTimeRemaining = native.minTimeRemaining;
            CollisionTolerance = native.collisionTolerance;
            CharacterPadding = native.characterPadding;
            MaxNumHits = native.maxNumHits;
            HitReductionCosMaxAngle = native.hitReductionCosMaxAngle;
            PenetrationRecoverySpeed = native.penetrationRecoverySpeed;
            innerBodyLayer = native.innerBodyLayer;
        }

        /* JPH_CharacterBaseSettings */
        public float3 Up { get; set; }

        public Plane SupportingVolume { get; set; }

        public float MaxSlopeAngle { get; set; }

        public bool EnhancedInternalEdgeRemoval { get; set; }

        public Shape? Shape { get; set; }

        /* JPH_CharacterVirtualSettings */
        public float Mass { get; set; }

        public float MaxStrength { get; set; }

        public float3 ShapeOffset { get; set; }

        public BackFaceMode BackFaceMode { get; set; }

        public float PredictiveContactDistance { get; set; }

        public uint MaxCollisionIterations { get; set; }

        public uint MaxConstraintIterations { get; set; }

        public float MinTimeRemaining { get; set; }

        public float CollisionTolerance { get; set; }

        public float CharacterPadding { get; set; }

        public uint MaxNumHits { get; set; }

        public float HitReductionCosMaxAngle { get; set; }

        public float PenetrationRecoverySpeed { get; set; }

        public Shape? InnerBodyShape { get; set; }
        public ObjectLayer innerBodyLayer { get; set; }

        internal void ToNative(JPH_CharacterVirtualSettings* native)
        {
            native->@base.up = Up;
            native->@base.supportingVolume = SupportingVolume;
            native->@base.maxSlopeAngle = MaxSlopeAngle;
            native->@base.enhancedInternalEdgeRemoval = EnhancedInternalEdgeRemoval;
            native->@base.shape = Shape != null ? Shape.Value.Handle : null;
            Debug.Log($"{Shape.Value.Handle.IntoPointer() == null}");

            native->mass = Mass;
            native->maxStrength = MaxStrength;
            native->shapeOffset = ShapeOffset;
            native->backFaceMode = BackFaceMode;
            native->predictiveContactDistance = PredictiveContactDistance;
            native->maxCollisionIterations = MaxCollisionIterations;
            native->maxConstraintIterations = MaxConstraintIterations;
            native->minTimeRemaining = MinTimeRemaining;
            native->collisionTolerance = CollisionTolerance;
            native->characterPadding = CharacterPadding;
            native->maxNumHits = MaxNumHits;
            native->hitReductionCosMaxAngle = HitReductionCosMaxAngle;
            native->penetrationRecoverySpeed = PenetrationRecoverySpeed;
            native->innerBodyShape = InnerBodyShape != null ? InnerBodyShape.Value.Handle : null;
            native->innerBodyLayer = innerBodyLayer;
        }
    }
}