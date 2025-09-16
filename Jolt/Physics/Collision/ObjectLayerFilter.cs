using Jolt;
using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

namespace Jolt
{
    /// <summary>
    /// Represents a filter using a bitmask for determining which <see cref="ObjectLayer"/>s to ignore in a collision query.
    /// </summary>
    public unsafe struct ObjectLayerFilter : IDisposable
    {
        internal NativeHandle<JPH_ObjectLayerFilter> Handle;

        private ObjectLayerFilter(NativeList<ObjectLayer> layers, bool ignoreLayers)
        {
            if (ignoreLayers)
            {
                Handle = Bindings.JPH_IgnoreObjectLayerFilter_Create(layers);
            }
            else
            {
                Handle = Bindings.JPH_IncludeObjectLayerFilter_Create(layers);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLayerFilter"/> class specifying layers to collide with.
        /// </summary>
        /// <param name="layers">The layers to include in collisions.</param>
        public static ObjectLayerFilter CreateIncludeObjectLayerFilter(NativeList<ObjectLayer> layers)
        {
            return new ObjectLayerFilter(layers, false);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLayerFilter"/> class specifying layers to ignore.
        /// </summary>
        /// <param name="layers">The layers to exclude from collisions.</param>
        public static ObjectLayerFilter CreateIgnoreObjectLayerFilter(NativeList<ObjectLayer> layers)
        {
            return new ObjectLayerFilter(layers, true);
        }

        public void Dispose()
        {
            Bindings.JPH_ObjectLayerFilter_Destroy(Handle);
        }
    }
}