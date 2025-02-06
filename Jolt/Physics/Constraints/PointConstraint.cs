namespace Jolt
{
    [GenerateHandle("JPH_PointConstraint"), GenerateBindings("JPH_PointConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct PointConstraint
    {
        [OverrideBinding("JPH_PointConstraint_Create")]
        public static PointConstraint Create(PointConstraintSettings settings, Body body1, Body body2)
        {
            return new PointConstraint(Bindings.JPH_PointConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}
