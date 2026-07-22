namespace Jolt
{
    [GenerateHandle("JPH_SkeletonMapper"), GenerateBindings("JPH_SkeletonMapper")]
    public readonly partial struct SkeletonMapper
    {
        public bool IsCreated => Handle.RawValue != 0;

        [OverrideBinding("JPH_SkeletonMapper_Create")]
        public static SkeletonMapper Create()
        {
            return new SkeletonMapper(Bindings.JPH_SkeletonMapper_Create());
        }
    }
}
