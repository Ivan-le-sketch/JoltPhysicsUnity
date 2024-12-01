using System;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_ObjectLayerFilter> JPH_ObjectLayerFilter_Create(JPH_ObjectLayerFilter_Procs procs, void* userData) 
        {
            return CreateHandle(UnsafeBindings.JPH_ObjectLayerFilter_Create(procs, userData));
        }

        public static void JPH_ObjectLayerFilter_Destroy(NativeHandle<JPH_ObjectLayerFilter> filter) 
        {
            UnsafeBindings.JPH_ObjectLayerFilter_Destroy(filter);

            filter.Dispose();
        }
    }
}
