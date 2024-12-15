namespace Jolt
{
    [GenerateHandle("JPH_MutableCompoundShape"), GenerateBindings("JPH_MutableCompoundShape", "JPH_CompoundShape", "JPH_Shape")]
    public readonly partial struct MutableCompoundShape
    {
        public static implicit operator MutableCompoundShape(Shape shape)
        {
            return new MutableCompoundShape(shape.Handle.Reinterpret<JPH_MutableCompoundShape>());
        }
    }
}