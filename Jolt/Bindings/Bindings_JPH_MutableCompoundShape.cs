using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_MutableCompoundShape> JPH_MutableCompoundShape_Create(NativeHandle<JPH_MutableCompoundShapeSettings> settings)
        {
            return CreateHandle(UnsafeBindings.JPH_MutableCompoundShape_Create(settings));
        }

        public static uint JPH_MutableCompoundShape_AddShape(NativeHandle<JPH_MutableCompoundShape> shape, float3 position, quaternion rotation, NativeHandle<JPH_Shape> child, uint userData, uint index)
        {
            return UnsafeBindings.JPH_MutableCompoundShape_AddShape(shape, &position, &rotation, child, userData, index);
        }

        public static void JPH_MutableCompoundShape_RemoveShape(NativeHandle<JPH_MutableCompoundShape> shape, uint index)
        {
            UnsafeBindings.JPH_MutableCompoundShape_RemoveShape(shape, index);
        }

        public static void JPH_MutableCompoundShape_ModifyShape(NativeHandle<JPH_MutableCompoundShape> shape, uint index, float3 position, quaternion rotation)
        {
            UnsafeBindings.JPH_MutableCompoundShape_ModifyShape(shape, index, &position, &rotation);
        }

        public static void JPH_MutableCompoundShape_ModifyShape2(NativeHandle<JPH_MutableCompoundShape> shape, uint index, float3 position, quaternion rotation, NativeHandle<JPH_Shape> newShape)
        {
            UnsafeBindings.JPH_MutableCompoundShape_ModifyShape2(shape, index, &position, &rotation, newShape);
        }

        public static void JPH_MutableCompoundShape_ReplaceShapes(NativeHandle<JPH_MutableCompoundShape> shape, NativeArray<CompoundShapeReplacement> replacements)
        {
            if (!replacements.IsCreated)
                throw new ArgumentException("A replacement buffer is required.", nameof(replacements));
            var data = (CompoundShapeReplacement*)replacements.GetUnsafeReadOnlyPtr();
            if (UnsafeBindings.JPH_MutableCompoundShape_ReplaceShapes(shape, data, (uint)replacements.Length) == 0)
                throw new ArgumentException("Replacements must contain one valid shape per existing child.", nameof(replacements));
        }

        public static void JPH_MutableCompoundShape_AdjustCenterOfMass(NativeHandle<JPH_MutableCompoundShape> shape)
        {
            UnsafeBindings.JPH_MutableCompoundShape_AdjustCenterOfMass(shape);
        }
    }
}
