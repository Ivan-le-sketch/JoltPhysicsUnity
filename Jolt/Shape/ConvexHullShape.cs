namespace Jolt
{
    [GenerateHandle("JPH_ConvexHullShape"), GenerateBindings("JPH_ConvexHullShape", "JPH_ConvexShape", "JPH_Shape")]
    public readonly partial struct ConvexHullShape
    {
        public static implicit operator ConvexHullShape(Shape shape)
        {
            return new ConvexHullShape(shape.Handle.Reinterpret<JPH_ConvexHullShape>());
        }
    }
}
