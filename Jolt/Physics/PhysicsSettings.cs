using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PhysicsSettings
    {
        public int MaxInFlightBodyPairs;
        public int StepListenersBatchSize;
        public int StepListenerBatchesPerJob;
        public float Baumgarte;
        public float SpeculativeContactDistance;
        public float PenetrationSlop;
        public float LinearCastThreshold;
        public float LinearCastMaxPenetration;
        public float ManifoldTolerance;
        public float MaxPenetrationDistance;
        public float BodyPairCacheMaxDeltaPositionSq;
        public float BodyPairCacheCosMaxDeltaRotationDiv2;
        public float ContactNormalCosMaxDeltaRotation;
        public float ContactPointPreserveLambdaMaxDistSq;
        public uint NumVelocitySteps;
        public uint NumPositionSteps;
        public float MinVelocityForRestitution;
        public float TimeBeforeSleep;
        public float PointVelocitySleepThreshold;
        public NativeBool DeterministicSimulation;
        public NativeBool ConstraintWarmStart;
        public NativeBool UseBodyPairContactCache;
        public NativeBool UseManifoldReduction;
        public NativeBool UseLargeIslandSplitter;
        public NativeBool AllowSleeping;
        public NativeBool CheckActiveEdges;

        public static PhysicsSettings Default()
        {
            return new PhysicsSettings
            {
                MaxInFlightBodyPairs = 16384,
                StepListenersBatchSize = 8,
                StepListenerBatchesPerJob = 1,
                Baumgarte = 0.2f,
                SpeculativeContactDistance = 0.02f,
                PenetrationSlop = 0.02f,
                LinearCastThreshold = 0.75f,
                LinearCastMaxPenetration = 0.25f,
                ManifoldTolerance = 1.0e-3f,
                MaxPenetrationDistance = 0.2f,
                BodyPairCacheMaxDeltaPositionSq = 0.000001f,
                BodyPairCacheCosMaxDeltaRotationDiv2 = 0.99984769515639123915701155881391f,
                ContactNormalCosMaxDeltaRotation = 0.99619469809174553229501040247389f,
                ContactPointPreserveLambdaMaxDistSq = 0.0001f,
                NumVelocitySteps = 10,
                NumPositionSteps = 2,
                MinVelocityForRestitution = 1.0f,
                TimeBeforeSleep = 0.5f,
                PointVelocitySleepThreshold = 0.03f,
                DeterministicSimulation = true,
                ConstraintWarmStart = true,
                UseBodyPairContactCache = true,
                UseManifoldReduction = true,
                UseLargeIslandSplitter = true,
                AllowSleeping = true,
                CheckActiveEdges = true,
            };
        }
    }
}