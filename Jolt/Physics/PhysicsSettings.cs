using System.Runtime.InteropServices;

namespace Jolt
{
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
        public float ManifoldToleranceSq;
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

        // Using bool properties while keeping NativeBool as private since currently NativeBool is internal

        private NativeBool deterministicSimulation;
        private NativeBool constraintWarmStart;
        private NativeBool useBodyPairContactCache;
        private NativeBool useManifoldReduction;
        private NativeBool useLargeIslandSplitter;
        private NativeBool allowSleeping;
        private NativeBool checkActiveEdges;

        public bool DeterministicSimulation { get => deterministicSimulation; set => deterministicSimulation = value; }
        public bool ConstraintWarmStart { get => constraintWarmStart; set => constraintWarmStart = value; }
        public bool UseBodyPairContactCache { get => useBodyPairContactCache; set => useBodyPairContactCache = value; }
        public bool UseManifoldReduction { get => useManifoldReduction; set => useManifoldReduction = value; }
        public bool UseLargeIslandSplitter { get => useLargeIslandSplitter; set => useLargeIslandSplitter = value; }
        public bool AllowSleeping { get => allowSleeping; set => allowSleeping = value; }
        public bool CheckActiveEdges { get => checkActiveEdges; set => checkActiveEdges = value; }
    }
}