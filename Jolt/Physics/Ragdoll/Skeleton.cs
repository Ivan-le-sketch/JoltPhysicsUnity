namespace Jolt
{
    public readonly struct SkeletonJoint
    {
        public readonly string Name;
        public readonly string ParentName;
        public readonly int ParentJointIndex;

        internal SkeletonJoint(string name, string parentName, int parentJointIndex)
        {
            Name = name;
            ParentName = parentName;
            ParentJointIndex = parentJointIndex;
        }
    }

    [GenerateHandle("JPH_Skeleton"), GenerateBindings("JPH_Skeleton")]
    public readonly partial struct Skeleton
    {
        public bool IsCreated => Handle.RawValue != 0;

        [OverrideBinding("JPH_Skeleton_Create")]
        public static Skeleton Create()
        {
            return new Skeleton(Bindings.JPH_Skeleton_Create());
        }
    }
}
