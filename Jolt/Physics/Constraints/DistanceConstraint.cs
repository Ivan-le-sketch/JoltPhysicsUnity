namespace Jolt
{
    [GenerateHandle("JPH_DistanceConstraint"), GenerateBindings("JPH_DistanceConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct DistanceConstraint
    {
        [OverrideBinding("JPH_DistanceConstraint_Create")]
        public static DistanceConstraint Create(DistanceConstraintSettings settings, Body body1, Body body2)
        {
            return new DistanceConstraint(Bindings.JPH_DistanceConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}
