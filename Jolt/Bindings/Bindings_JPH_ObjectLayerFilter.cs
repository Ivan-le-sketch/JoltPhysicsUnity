using System;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_ObjectLayerFilter> JPH_ObjectLayerFilter_Create(JPH_ObjectLayerFilter_Procs* procs, void* userData) 
        {
            UnsafeBindings.JPH_ObjectLayerFilter_SetProcs(procs);

            return CreateHandle(UnsafeBindings.JPH_ObjectLayerFilter_Create(userData));
        }

        public static void JPH_ObjectLayerFilter_Destroy(NativeHandle<JPH_ObjectLayerFilter> filter) 
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_ObjectLayerFilter_Destroy(filter);

            filter.Dispose();
        }
    }
}
