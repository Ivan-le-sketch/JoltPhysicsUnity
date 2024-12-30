using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

namespace Jolt
{
    /// <summary>
    /// Represents a filter using a bitmask for determining which broad phase layers to ignore in a collision query.
    /// </summary>
    [BurstCompile]
    public unsafe struct BroadPhaseLayerFilter : IDisposable
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

        internal NativeHandle<JPH_BroadPhaseLayerFilter> Handle;

        internal IntPtr UnmanagedPointer;

        // Using a 64-bit integer to represent the layers that should collide.
        // Each bit in this mask can represent a layer. For example, if the first bit is set (0x1), it allows collision with layer 0.
        private readonly ulong collisionMask;

        private delegate bool ShouldCollideSignature(void* userData, ref BroadPhaseLayer layer);

        private static readonly FunctionPointer<ShouldCollideSignature> shouldCollideFuncPointer;

        static BroadPhaseLayerFilter()
        {
            shouldCollideFuncPointer = BurstCompiler.CompileFunctionPointer<ShouldCollideSignature>(ShouldCollide);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadPhaseLayerFilter"/> class with a specified collision mask.
        /// </summary>
        /// <param name="collisionMask">The mask used to determine layer collisions.</param>
        public static BroadPhaseLayerFilter Create(ulong collisionMask)
        {
            var unmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(BroadPhaseLayerFilter)));
            BroadPhaseLayerFilter filter = new BroadPhaseLayerFilter(collisionMask);
            Marshal.StructureToPtr(filter, unmanagedPointer, false);

            filter.UnmanagedPointer = unmanagedPointer;

            var ptr = (BroadPhaseLayerFilter*)unmanagedPointer.ToPointer();

            var procs = new JPH_BroadPhaseLayerFilter_Procs
            {
                ShouldCollide = shouldCollideFuncPointer.Value,
            };

            filter.Handle = Bindings.JPH_BroadPhaseLayerFilter_Create(procs, ptr);

            return filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadPhaseLayerFilter"/> class specifying layers to either ignore or collide with.
        /// </summary>
        /// <param name="layers">The layers to include or exclude from collisions.</param>
        /// <param name="constructorMode">The mode that determines how layers are treated (either collide or ignore).</param>
        public static BroadPhaseLayerFilter Create(NativeList<BroadPhaseLayer> layers, MaskInitializationMode constructorMode)
        {
            IntPtr unmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(BroadPhaseLayerFilter)));
            BroadPhaseLayerFilter filter = new BroadPhaseLayerFilter(layers, constructorMode);
            Marshal.StructureToPtr(filter, unmanagedPointer, false);

            filter.UnmanagedPointer = unmanagedPointer;

            var ptr = (BroadPhaseLayerFilter*)unmanagedPointer.ToPointer();

            var procs = new JPH_BroadPhaseLayerFilter_Procs
            {
                ShouldCollide = shouldCollideFuncPointer.Value,
            };

            filter.Handle = Bindings.JPH_BroadPhaseLayerFilter_Create(procs, ptr);

            return filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadPhaseLayerFilter"/> class with a specified collision mask.
        /// </summary>
        /// <remarks>
        /// This should never be called outside of <see cref="Create(ulong)"/>.
        /// </remarks>
        /// <param name="collisionMask">The mask used to determine layer collisions.</param>
        internal BroadPhaseLayerFilter(ulong collisionMask)
        {
            Handle = default;
            UnmanagedPointer = default;

            this.collisionMask = collisionMask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadPhaseLayerFilter"/> class specifying layers to either ignore or collide with.
        /// </summary>
        /// <remarks>
        /// This should never be called outside of <see cref="Create(NativeList{BroadPhaseLayer}, MaskInitializationMode)"/>.
        /// </remarks>
        /// <param name="layers">The layers to include or exclude from collisions.</param>
        /// <param name="constructorMode">The mode that determines how layers are treated (either collide or ignore).</param>
        internal BroadPhaseLayerFilter(NativeList<BroadPhaseLayer> layers, MaskInitializationMode constructorMode)
        {
            Handle = default;
            UnmanagedPointer = default;

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

        /// <summary>
        /// <para>
        /// Callback method for the Jolt physics engine to call.
        /// </para>
        /// Returns if an <see cref="BroadPhaseLayer"/> should collide.
        /// </summary>
        /// <param name="context">Pointer to an instance of <see cref="BroadPhaseLayerFilter"/></param>
        /// <param name="layer"></param>
        /// <returns></returns>
        [BurstCompile]
        internal static bool ShouldCollide(void* context, ref BroadPhaseLayer layer)
        {
            var implPtr = (BroadPhaseLayerFilter*)context;
            var impl = *implPtr;

            return impl.ShouldCollide(layer);
        }

        /// <summary>
        /// Returns if an <see cref="BroadPhaseLayer"/> should collide.
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        internal bool ShouldCollide(BroadPhaseLayer layer)
        {
            // Shift 1 left by the number of the layer's value, then AND it with the collision mask to see if that bit is set.
            return (collisionMask & (1u << layer.Value)) != 0;
        }

        public void Dispose()
        {
            Bindings.JPH_BroadPhaseLayerFilter_Destroy(Handle);
            Marshal.FreeHGlobal(UnmanagedPointer);
        }
    }
}
