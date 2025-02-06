namespace Jolt
{
    [GenerateHandle("JPH_HingeConstraint"), GenerateBindings("JPH_HingeConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct HingeConstraint
    {
        [OverrideBinding("JPH_HingeConstraint_Create")]
        public static HingeConstraint Create(HingeConstraintSettings settings, Body body1, Body body2)
        {
            return new HingeConstraint(Bindings.JPH_HingeConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}
