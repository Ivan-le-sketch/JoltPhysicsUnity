namespace Jolt
{
    [GenerateHandle("JPH_SixDOFConstraint"), GenerateBindings("JPH_SixDOFConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct SixDOFConstraint
    {
        [OverrideBinding("JPH_SixDOFConstraint_Create")]
        public static SixDOFConstraint Create(SixDOFConstraintSettings settings, Body body1, Body body2)
        {
            return new SixDOFConstraint(Bindings.JPH_SixDOFConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}