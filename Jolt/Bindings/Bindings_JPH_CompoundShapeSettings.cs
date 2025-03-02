using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_CompoundShapeSettings_AddShape(NativeHandle<JPH_CompoundShapeSettings> handle, float3 position, quaternion rotation, NativeHandle<JPH_ShapeSettings> settings, uint userData = 0)
        {
            UnsafeBindings.JPH_CompoundShapeSettings_AddShape(handle, &position, &rotation, settings, userData);
        }

        public static void JPH_CompoundShapeSettings_AddShape(NativeHandle<JPH_CompoundShapeSettings> settings, float3 position, quaternion rotation, NativeHandle<JPH_Shape> shape, uint userData = 0)
        {
            UnsafeBindings.JPH_CompoundShapeSettings_AddShape2(settings, &position, &rotation, shape, userData);
        }
    }
}
