using Unity.Mathematics;

using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Jolt
{
    // Borrowed shape pointers: keep the source shapes alive until ReplaceShapes returns.
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
        /// <summary>Replace every child in index order, preserving user data and center of mass. Requires exclusive access.</summary>
        public unsafe void ReplaceShapes(NativeArray<CompoundShapeReplacement> replacements)
        {
            if (!replacements.IsCreated)
                throw new ArgumentException("A replacement buffer is required.", nameof(replacements));
            if (ReplaceShapesNative(Handle, (CompoundShapeReplacement*)replacements.GetUnsafeReadOnlyPtr(), (uint)replacements.Length) == 0)
                throw new ArgumentException("Replacements must contain one valid shape per existing child.", nameof(replacements));
        }

        [DllImport("joltc", EntryPoint = "JPH_MutableCompoundShape_ReplaceShapes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        private static extern unsafe uint ReplaceShapesNative(JPH_MutableCompoundShape* shape, CompoundShapeReplacement* replacements, uint count);

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
