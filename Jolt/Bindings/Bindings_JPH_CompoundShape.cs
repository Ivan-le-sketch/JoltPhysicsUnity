using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static uint JPH_CompoundShape_GetNumSubShapes(NativeHandle<JPH_CompoundShape> shape)
        {
            return UnsafeBindings.JPH_CompoundShape_GetNumSubShapes(shape);
        }

        public static void JPH_CompoundShape_GetSubShape(NativeHandle<JPH_CompoundShape> shape, uint index, out NativeHandle<JPH_Shape> subShape, out float3 positionCOM, out quaternion rotation, out uint userData)
        {
            var sub = new JPH_Shape();
            var ptrToSub = &sub;
            float3 pos;
            quaternion rot;
            uint uData;

            UnsafeBindings.JPH_CompoundShape_GetSubShape(shape, index, &ptrToSub, &pos, &rot, &uData);

            subShape = CreateHandle(ptrToSub);
            positionCOM = pos;
            rotation = rot;
            userData = uData;
        }

        public static uint JPH_CompoundShape_GetSubShapeIndexFromID(NativeHandle<JPH_CompoundShape> shape, SubShapeID id, out SubShapeID remainder)
        {
            SubShapeID remain;
            var result = UnsafeBindings.JPH_CompoundShape_GetSubShapeIndexFromID(shape, id, &remain);
            remainder = remain;

            return result;
        }
    }
}