namespace Jolt
{
    [GenerateHandle("JPH_MeshShape"), GenerateBindings("JPH_MeshShape", "JPH_Shape")]
    public readonly partial struct MeshShape
    {
        public static implicit operator MeshShape(Shape shape)
        {
            return new MeshShape(shape.Handle.Reinterpret<JPH_MeshShape>());
        }
    }
}
