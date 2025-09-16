using System;
using Unity.Burst;
using Unity.Collections;

namespace Jolt
{
    /// <summary>
    /// Represents a filter using a bitmask for determining which broad phase layers to ignore in a collision query.
    /// </summary>
    [BurstCompile]
    public unsafe struct BroadPhaseLayerFilter : IDisposable
    {
        /// <summary>
        /// A handle to a native broadphase layer filter.
        /// </summary>
        internal NativeHandle<JPH_BroadPhaseLayerFilter> Handle;

        private BroadPhaseLayerFilter(NativeList<BroadPhaseLayer> layers, bool ignoreLayers)
        {
            if (ignoreLayers)
            {
                Handle = Bindings.JPH_IgnoreBroadPhaseLayerFilter_Create(layers);
            }
            else
            {
                Handle = Bindings.JPH_IncludeBroadPhaseLayerFilter_Create(layers);
            }
        }

        /// <summary>
        /// Initializes a new <see cref="BroadPhaseLayerFilter"/> instance specifying layers to collide with.
        /// </summary>
        /// <param name="layers">The layers to include in collisions.</param>
        public static BroadPhaseLayerFilter CreateIncludeBroadPhaseLayerFilter(NativeList<BroadPhaseLayer> layers)
        {
            return new BroadPhaseLayerFilter(layers, false);
        }

        /// <summary>
        /// Initializes a new <see cref="BroadPhaseLayerFilter"/> instance specifying layers to ignore.
        /// </summary>
        /// <param name="layers">The layers to exclude from collisions.</param>
        public static BroadPhaseLayerFilter CreateIgnoreBroadPhaseLayerFilter(NativeList<BroadPhaseLayer> layers)
        {
            return new BroadPhaseLayerFilter(layers, true);
        }

        public void Dispose()
        {
            Bindings.JPH_BroadPhaseLayerFilter_Destroy(Handle);
        }
    }
}
