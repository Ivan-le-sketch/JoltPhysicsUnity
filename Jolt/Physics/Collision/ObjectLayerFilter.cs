using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    /// <summary>
    /// Represents a filter using a bitmask for determining which <see cref="ObjectLayer"/>s to ignore in a collision query.
    /// </summary>
    public unsafe class ObjectLayerFilter : IDisposable
    {
        /// <summary>
        /// Enumerates the modes for constructing a collision mask.
        /// </summary>
        public enum MaskInitializationMode
        {
            /// <summary>
            /// Specifies that the filter should collide with the designated layers.
            /// </summary>
            CollideLayers,

            /// <summary>
            /// Specifies that the filter should ignore the designated layers.
            /// </summary>
            IgnoreLayers,
        }

        internal NativeHandle<JPH_ObjectLayerFilter> Handle;

        private readonly ulong collisionMask = 0xFFFFFFFFFFFFFFFF;

        private delegate NativeBool ShouldCollide(IntPtr userData, ObjectLayer layer);

        private ShouldCollide shouldCollideDelegate;

        public ObjectLayerFilter()
        {
            CreateNativeHandle();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLayerFilter"/> class with a specified collision mask.
        /// </summary>
        /// <param name="collisionMask">The mask used to determine layer collisions.</param>
        public ObjectLayerFilter(ulong collisionMask)
        {
            CreateNativeHandle();

            this.collisionMask = collisionMask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLayerFilter"/> class specifying layers to either ignore or collide with.
        /// </summary>
        /// <param name="layers">The layers to include or exclude from collisions.</param>
        /// <param name="constructorMode">The mode that determines how layers are treated (either collide or ignore).</param>
        public ObjectLayerFilter(ObjectLayer[] layers, MaskInitializationMode constructorMode)
        {
            CreateNativeHandle();

            if (constructorMode == MaskInitializationMode.IgnoreLayers)
            {
                // Start with all bits set to 1 (assume 64-bit mask)
                ulong mask = 0xFFFFFFFFFFFFFFFF;

                foreach (var layer in layers)
                {
                    if (layer.Value >= 0 && layer.Value < 64)
                    {
                        mask &= ~(1UL << layer.Value); // Clear the bit for each layer to ignore
                    }
                    else
                    {
                        Debug.LogWarning("Trying to set an invalid layer in the filter mask.");
                    }
                }

                collisionMask = mask;
            }
            else
            {
                // Start with all bits set to 0 (assume 64-bit mask)
                ulong mask = 0x0;

                foreach (var layer in layers)
                {
                    if (layer.Value >= 0 && layer.Value < 64)
                    {
                        mask |= (1UL << layer.Value); // Set the bit for each layer to collide
                    }
                    else
                    {
                        Debug.LogWarning("Trying to set an invalid layer in the filter mask.");
                    }
                }

                collisionMask = mask;
            }
        }

        public void Dispose()
        {
            Bindings.JPH_ObjectLayerFilter_Destroy(Handle);
        }

        internal NativeBool ShouldCollideCallback(IntPtr userData, ObjectLayer layer)
        {
            // Shift 1 left by the number of the layer's value, then AND it with the collision mask to see if that bit is set.
            return (collisionMask & (1u << layer.Value)) != 0;
        }

        private void CreateNativeHandle()
        {
            shouldCollideDelegate = ShouldCollideCallback;

            JPH_ObjectLayerFilter_Procs procs = new JPH_ObjectLayerFilter_Procs
            {
                ShouldCollide = Marshal.GetFunctionPointerForDelegate(shouldCollideDelegate),
            };

            Handle = Bindings.JPH_ObjectLayerFilter_Create(procs, null);
        }
    }
}
