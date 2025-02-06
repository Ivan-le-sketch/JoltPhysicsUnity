namespace Jolt
{
    [GenerateHandle("JPH_GearConstraint"), GenerateBindings("JPH_GearConstraint", "JPH_TwoBodyConstraint", "JPH_Constraint")]
    public readonly partial struct GearConstraint
    {
        [OverrideBinding("JPH_GearConstraint_Create")]
        public static GearConstraint Create(GearConstraintSettings settings, Body body1, Body body2)
        {
            return new GearConstraint(Bindings.JPH_GearConstraint_Create(settings, body1.Handle, body2.Handle));
        }
    }
}
