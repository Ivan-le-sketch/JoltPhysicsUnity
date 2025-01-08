using Unity.Mathematics;

namespace Jolt
{
    [GenerateHandle("JPH_MutableCompoundShape"), GenerateBindings("JPH_MutableCompoundShape", "JPH_CompoundShape", "JPH_Shape")]
    public readonly partial struct MutableCompoundShape
    {
        public static implicit operator MutableCompoundShape(Shape shape)
        {
            return new MutableCompoundShape(shape.Handle.Reinterpret<JPH_MutableCompoundShape>());
        }

        [OverrideBinding("JPH_CompoundShape_GetSubShape")]
        public void GetSubShape(uint index, out Shape subShape, out float3 positionCOM, out quaternion rotation, out uint userData)
        {
            Bindings.JPH_CompoundShape_GetSubShape(Handle.Reinterpret<JPH_CompoundShape>(), index, out var subShapeHandle, out positionCOM, out rotation, out userData);

            subShape = new Shape(subShapeHandle);
        }
    }
}