using System;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_BroadPhaseLayerFilter> JPH_BroadPhaseLayerFilter_Create(JPH_BroadPhaseLayerFilter_Procs* procs, void* userData)
        {
            UnsafeBindings.JPH_BroadPhaseLayerFilter_SetProcs(procs);

            return CreateHandle(UnsafeBindings.JPH_BroadPhaseLayerFilter_Create(userData));
        }

        public static void JPH_BroadPhaseLayerFilter_Destroy(NativeHandle<JPH_BroadPhaseLayerFilter> filter) 
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_BroadPhaseLayerFilter_Destroy(filter);

            filter.Dispose();
        }
    }
}
