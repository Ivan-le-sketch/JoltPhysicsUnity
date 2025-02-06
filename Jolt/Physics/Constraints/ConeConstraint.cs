namespace Jolt
{
    [GenerateHandle("JPH_ConeConstraint"), GenerateBindings("JPH_ConeConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct ConeConstraint
    {
        [OverrideBinding("JPH_ConeConstraint_Create")]
        public static ConeConstraint Create(ConeConstraintSettings settings, Body body1, Body body2)
        {
            return new ConeConstraint(Bindings.JPH_ConeConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}