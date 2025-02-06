namespace Jolt
{
    [GenerateHandle("JPH_FixedConstraint"), GenerateBindings("JPH_FixedConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct FixedConstraint
    {
        [OverrideBinding("JPH_FixedConstraint_Create")]
        public static FixedConstraint Create(FixedConstraintSettings settings, Body body1, Body body2)
        {
            return new FixedConstraint(Bindings.JPH_FixedConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}
