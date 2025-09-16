using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_ObjectLayerFilter_Destroy(NativeHandle<JPH_ObjectLayerFilter> filter) 
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_ObjectLayerFilter_Destroy(filter);

            filter.Dispose();
        }

        public static NativeHandle<JPH_ObjectLayerFilter> JPH_IncludeObjectLayerFilter_Create(NativeList<ObjectLayer> layers)
        {
            return CreateHandle(UnsafeBindings.JPH_IncludeObjectLayerFilter_Create(layers.GetUnsafePtr(), layers.Length));
        }

        public static NativeHandle<JPH_ObjectLayerFilter> JPH_IgnoreObjectLayerFilter_Create(NativeList<ObjectLayer> layers)
        {
            return CreateHandle(UnsafeBindings.JPH_IgnoreObjectLayerFilter_Create(layers.GetUnsafePtr(), layers.Length));
        }
    }
}
