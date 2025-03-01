namespace Jolt
{
    [GenerateHandle("JPH_TaperedCapsuleShape"),  GenerateBindings("JPH_TaperedCapsuleShape", "JPH_ConvexShape", "JPH_Shape")]
    public readonly partial struct TaperedCapsuleShape
    {
        // TODO no JPH_TaperedCapsuleShape_Create binding?

        public static implicit operator TaperedCapsuleShape(Shape shape)
        {
            return new TaperedCapsuleShape(shape.Handle.Reinterpret<JPH_TaperedCapsuleShape>());
        }
    }
}
