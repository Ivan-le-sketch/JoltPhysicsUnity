using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_BroadPhaseLayerFilter_Destroy(NativeHandle<JPH_BroadPhaseLayerFilter> filter)
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_BroadPhaseLayerFilter_Destroy(filter);

            filter.Dispose();
        }

        public static NativeHandle<JPH_BroadPhaseLayerFilter> JPH_SpecifiedBroadPhaseLayerFilter_Create(BroadPhaseLayer layer)
        {
            return CreateHandle(UnsafeBindings.JPH_SpecifiedBroadPhaseLayerFilter_Create(layer));
        }

        public static NativeHandle<JPH_BroadPhaseLayerFilter> JPH_IncludeBroadPhaseLayerFilter_Create(NativeList<BroadPhaseLayer> layers)
        {
            return CreateHandle(UnsafeBindings.JPH_IncludeBroadPhaseLayerFilter_Create(layers.GetUnsafePtr(), (byte)layers.Length));
        }

        public static NativeHandle<JPH_BroadPhaseLayerFilter> JPH_IgnoreBroadPhaseLayerFilter_Create(NativeList<BroadPhaseLayer> layers)
        {
            return CreateHandle(UnsafeBindings.JPH_IgnoreBroadPhaseLayerFilter_Create(layers.GetUnsafePtr(), (byte)layers.Length));
        }
    }
}
