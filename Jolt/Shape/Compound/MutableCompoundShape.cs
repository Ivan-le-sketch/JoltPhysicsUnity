using Unity.Mathematics;

using System.Runtime.InteropServices;
using Unity.Collections;

namespace Jolt
{
    /// <summary>A child shape and transform for a synchronous compound replacement.</summary>
    /// <remarks>Borrows the shape; the caller must keep it alive until ReplaceShapes returns.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct CompoundShapeReplacement
    {
        internal readonly float3 Position;
        internal readonly quaternion Rotation;
        internal readonly JPH_Shape* ShapePointer;

        public CompoundShapeReplacement(Shape shape, float3 position, quaternion rotation)
        {
            Position = position;
            Rotation = rotation;
            ShapePointer = shape.Handle;
        }
    }

    [GenerateHandle("JPH_MutableCompoundShape"), GenerateBindings("JPH_MutableCompoundShape", "JPH_CompoundShape", "JPH_Shape")]
    public readonly partial struct MutableCompoundShape
    {
        /// <summary>Replace all children in index order, recalculating bounds once.</summary>
        /// <remarks>
        /// Preserves child indices, user data and center of mass. Requires exclusive access: no concurrent
        /// simulation or collision queries. NotifyShapeChanged must be called afterward for any owning body.
        /// All referenced shapes must remain alive until the call returns. Invalid batches leave the shape unchanged.
        /// </remarks>
        [OverrideBinding("JPH_MutableCompoundShape_ReplaceShapes")]
        public void ReplaceShapes(NativeArray<CompoundShapeReplacement> replacements)
        {
            Bindings.JPH_MutableCompoundShape_ReplaceShapes(Handle, replacements);
        }

        public static implicit operator MutableCompoundShape(Shape shape)
        {
            return new MutableCompoundShape(shape.Handle.Reinterpret<JPH_MutableCompoundShape>());
        }

        [OverrideBinding("JPH_MutableCompoundShape_Create")]
        public static MutableCompoundShape Create(MutableCompoundShapeSettings settings)
        {
            return new MutableCompoundShape(Bindings.JPH_MutableCompoundShape_Create(settings.Handle));
        }

        [OverrideBinding("JPH_CompoundShape_GetSubShape")]
        public void GetSubShape(uint index, out Shape subShape, out float3 positionCOM, out quaternion rotation, out uint userData)
        {
            Bindings.JPH_CompoundShape_GetSubShape(Handle.Reinterpret<JPH_CompoundShape>(), index, out var subShapeHandle, out positionCOM, out rotation, out userData);

            subShape = new Shape(subShapeHandle);
        }
    }
}
