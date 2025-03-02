using Unity.Mathematics;

namespace Jolt
{
    [GenerateHandle("JPH_StaticCompoundShape"), GenerateBindings("JPH_StaticCompoundShape", "JPH_CompoundShape", "JPH_Shape")]
    public readonly partial struct StaticCompoundShape
    {
        public static implicit operator StaticCompoundShape(Shape shape)
        {
            return new StaticCompoundShape(shape.Handle.Reinterpret<JPH_StaticCompoundShape>());
        }

        [OverrideBinding("JPH_MutableCompoundShape_Create")]
        public static StaticCompoundShape Create(StaticCompoundShapeSettings settings)
        {
            return new StaticCompoundShape(Bindings.JPH_StaticCompoundShape_Create(settings.Handle));
        }

        [OverrideBinding("JPH_CompoundShape_GetSubShape")]
        public void GetSubShape(uint index, out Shape subShape, out float3 positionCOM, out quaternion rotation, out uint userData)
        {
            Bindings.JPH_CompoundShape_GetSubShape(Handle.Reinterpret<JPH_CompoundShape>(), index, out var subShapeHandle, out positionCOM, out rotation, out userData);

            subShape = new Shape(subShapeHandle);
        }
    }
}