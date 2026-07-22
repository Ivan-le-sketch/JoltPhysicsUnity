namespace Jolt
{
    [GenerateHandle("JPH_SkeletalAnimation"), GenerateBindings("JPH_SkeletalAnimation")]
    public readonly partial struct SkeletalAnimation
    {
        public bool IsCreated => Handle.RawValue != 0;

        [OverrideBinding("JPH_SkeletalAnimation_Create")]
        public static SkeletalAnimation Create()
        {
            return new SkeletalAnimation(Bindings.JPH_SkeletalAnimation_Create());
        }
    }
}
