namespace Jolt
{
    [GenerateHandle("JPH_TriangleShape"),  GenerateBindings("JPH_TriangleShape", "JPH_Shape")]
    public readonly partial struct TriangleShape
    {
        public static implicit operator TriangleShape(Shape shape)
        {
            return new TriangleShape(shape.Handle.Reinterpret<JPH_TriangleShape>());
        }
    }
}
