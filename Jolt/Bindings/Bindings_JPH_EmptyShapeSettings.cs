using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_EmptyShapeSettings> JPH_EmptyShapeSettings_Create(float3 centerOfMass)
        {
            return CreateHandle(UnsafeBindings.JPH_EmptyShapeSettings_Create(&centerOfMass));
        }

        public static NativeHandle<JPH_EmptyShape> JPH_EmptyShapeSettings_CreateShape(NativeHandle<JPH_EmptyShapeSettings> settings)
        {
            return CreateHandle(UnsafeBindings.JPH_EmptyShapeSettings_CreateShape(settings));
        }
    }
}