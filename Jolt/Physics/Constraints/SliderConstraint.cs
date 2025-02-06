namespace Jolt
{
    [GenerateHandle("JPH_SliderConstraint"), GenerateBindings("JPH_SliderConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct SliderConstraint
    {
        [OverrideBinding("JPH_SliderConstraint_Create")]
        public static SliderConstraint Create(SliderConstraintSettings settings, Body body1, Body body2)
        {
            return new SliderConstraint(Bindings.JPH_SliderConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}
