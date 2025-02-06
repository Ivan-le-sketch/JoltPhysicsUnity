namespace Jolt
{
    [GenerateHandle("JPH_SwingTwistConstraint"), GenerateBindings("JPH_SwingTwistConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct SwingTwistConstraint
    {
        [OverrideBinding("JPH_SwingTwistConstraint_Create")]
        public static SwingTwistConstraint Create(SwingTwistConstraintSettings settings, Body body1, Body body2)
        {
            return new SwingTwistConstraint(Bindings.JPH_SwingTwistConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}