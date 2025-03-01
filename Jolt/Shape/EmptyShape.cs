namespace Jolt
{
    [GenerateHandle("JPH_EmptyShape"), GenerateBindings("JPH_EmptyShape", "JPH_Shape")]
    public readonly partial struct EmptyShape
    {
        public static implicit operator EmptyShape(Shape shape)
        {
            return new EmptyShape(shape.Handle.Reinterpret<JPH_EmptyShape>());
        }
    }
}
