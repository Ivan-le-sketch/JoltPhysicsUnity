namespace Jolt
{
    [GenerateHandle("JPH_SkeletonPose"), GenerateBindings("JPH_SkeletonPose")]
    public readonly partial struct SkeletonPose
    {
        public bool IsCreated => Handle.RawValue != 0;

        [OverrideBinding("JPH_SkeletonPose_Create")]
        public static SkeletonPose Create()
        {
            return new SkeletonPose(Bindings.JPH_SkeletonPose_Create());
        }
    }
}
