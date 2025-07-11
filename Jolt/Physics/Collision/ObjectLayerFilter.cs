﻿using Jolt;
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
    [BurstCompile]
    public unsafe struct ObjectLayerFilter : IDisposable
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

        internal IntPtr UnmanagedPointer;

        private readonly ulong collisionMask;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool ShouldCollideSignature(void* context, ObjectLayer* layer);

        private static readonly FunctionPointer<ShouldCollideSignature> shouldCollideFuncPointer;

        private JPH_ObjectLayerFilter_Procs procs;

        static ObjectLayerFilter()
        {
            shouldCollideFuncPointer = BurstCompiler.CompileFunctionPointer<ShouldCollideSignature>(ShouldCollide);
        }

        private ObjectLayerFilter(ulong collisionMask)
        {
            Handle = default;
            UnmanagedPointer = default;
            procs = default;

            this.collisionMask = collisionMask;
        }

        private ObjectLayerFilter(NativeList<ObjectLayer> layers, MaskInitializationMode constructorMode)
        {
            Handle = default;
            UnmanagedPointer = default;
            procs = default;

            if (constructorMode == MaskInitializationMode.IgnoreLayers)
            {
                // Start with all bits set to 1 (assume 64-bit mask)
                ulong mask = 0xFFFFFFFFFFFFFFFF;

                for (int i = 0; i < layers.Length; i++)
                {
                    var layer = layers[i];

                    if (layer.Value >= 0 && layer.Value < 64)
                    {
                        mask &= ~(1UL << (int)layer.Value);
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

                for (int i = 0; i < layers.Length; i++)
                {
                    var layer = layers[i];

                    if (layer.Value >= 0 && layer.Value < 64)
                    {
                        mask |= (1UL << (int)layer.Value); // Set the bit for each layer to collide
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
        /// Initializes a new instance of the <see cref="ObjectLayerFilter"/> class with a specified collision mask.
        /// </summary>
        /// <param name="collisionMask">The mask used to determine layer collisions.</param>
        public static ObjectLayerFilter Create(ulong collisionMask)
        {
            ObjectLayerFilter filter = new ObjectLayerFilter(collisionMask);
            filter.UnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ObjectLayerFilter)));
            Marshal.StructureToPtr(filter, filter.UnmanagedPointer, false);
            var ptr = (ObjectLayerFilter*)filter.UnmanagedPointer.ToPointer();

            ptr->procs = new JPH_ObjectLayerFilter_Procs
            {
                ShouldCollide = shouldCollideFuncPointer.Value
            };

            filter.Handle = Bindings.JPH_ObjectLayerFilter_Create(&ptr->procs, ptr);

            return filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLayerFilter"/> class specifying layers to either ignore or collide with.
        /// </summary>
        /// <param name="layers">The layers to include or exclude from collisions.</param>
        /// <param name="constructorMode">The mode that determines how layers are treated (either collide or ignore).</param>
        public static ObjectLayerFilter Create(NativeList<ObjectLayer> layers, MaskInitializationMode constructorMode)
        {
            ObjectLayerFilter filter = new ObjectLayerFilter(layers, constructorMode);
            filter.UnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ObjectLayerFilter)));
            Marshal.StructureToPtr(filter, filter.UnmanagedPointer, false);
            var ptr = (ObjectLayerFilter*)filter.UnmanagedPointer.ToPointer();

            ptr->procs = new JPH_ObjectLayerFilter_Procs
            {
                ShouldCollide = shouldCollideFuncPointer.Value
            };

            filter.Handle = Bindings.JPH_ObjectLayerFilter_Create(&ptr->procs, ptr);

            return filter;
        }

        /// <summary>
        /// <para>
        /// Callback method for the Jolt physics engine to call.
        /// </para>
        /// Returns if an <see cref="ObjectLayer"/> should collide.
        /// </summary>
        /// <param name="context">Pointer to an instance of <see cref="ObjectLayerFilter"/></param>
        /// <param name="layer"></param>
        /// <returns></returns>
        [BurstCompile]
        internal static bool ShouldCollide(void* context, ObjectLayer* layer)
        {
            ObjectLayerFilter* implPtr = (ObjectLayerFilter*)context;
            ObjectLayerFilter impl = *implPtr;

            return impl.ShouldCollide(*layer);
        }

        /// <summary>
        /// Returns if an <see cref="ObjectLayer"/> should collide.
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        internal bool ShouldCollide(ObjectLayer layer)
        {
            // Shift 1 left by the number of the layer's value, then AND it with the collision mask to see if that bit is set.
            return (collisionMask & (1u << (int)layer.Value)) != 0;
        }

        public void Dispose()
        {
            Bindings.JPH_ObjectLayerFilter_Destroy(Handle);
            Marshal.FreeHGlobal(UnmanagedPointer);
        }
    }
}