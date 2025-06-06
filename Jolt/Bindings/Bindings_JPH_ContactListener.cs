using AOT;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_ContactListener> JPH_ContactListener_Create(IContactListenerImplementation listener)
        {
            // Getting the listeners to work requires a lot of indirection, because the listeners are represented as
            // heap objects in the native plugin with their own lifetimes. The joltc constructor for the listener takes
            // a "user data" parameter that lets us provide context to the callbacks when they are invoked.
            //
            // During initialization, we provide static callbacks to joltc. When we construct a new native listener, we
            // also create a GCHandle for the associated managed listener. These are tracked in the ManagedReference
            // static class. When Jolt invokes the native listener, it invokes the joltc static listener, which invokes
            // our own static listeners with the GCHandle parameter, which we dereference to obtain the user listener.

            var gch = GCHandle.Alloc(listener);
            var ptr = GCHandle.ToIntPtr(gch);

            fixed (JPH_ContactListener_Procs* procsPtr = &UnsafeContactListenerProcs)
            {
                var handle = CreateHandle(UnsafeBindings.JPH_ContactListener_Create(procsPtr, (void*)ptr));
                ManagedReference.Add(handle, gch);

                return handle;
            }
        }

        public static void JPH_ContactListener_Destroy(NativeHandle<JPH_ContactListener> listener)
        {
            if (listener.HasUser()) return;

            if (ManagedReference.Remove(listener, out var gch))
            {
                gch.Free();
            }
            else
            {
                Debug.LogError("Missing GCHandle for managed contact listener!");
            }

            UnsafeBindings.JPH_ContactListener_Destroy(listener);

            listener.Dispose();
        }

        /// <summary>
        /// Set the static callback pointers for JPH_ContactListener.
        /// </summary>
        private static void InitializeContactListeners()
        {
            fixed (JPH_ContactListener_Procs* ptr = &UnsafeContactListenerProcs)
            {

            }
        }

        /// <summary>
        /// Static procs for marshalling; the lookup from static to instance listener happens in each method.
        /// </summary>
        private static readonly JPH_ContactListener_Procs UnsafeContactListenerProcs = new JPH_ContactListener_Procs
        {
            OnContactValidate = GetDelegatePointer((UnsafeContactValidate)UnsafeContactValidateCallback),
            OnContactAdded = GetDelegatePointer((UnsafeContactAdded)UnsafeContactAddedCallback),
            OnContactRemoved = GetDelegatePointer((UnsafeContactRemoved)UnsafeContactRemovedCallback),
            OnContactPersisted = GetDelegatePointer((UnsafeContactPersisted)UnsafeContactPersistedCallback),
        };

        /// <summary>
        /// Unsafe static delegate for OnContactValidate.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate ValidateResult UnsafeContactValidate(void* udata, JPH_Body* bodyA, JPH_Body* bodyB, rvec3* offset, CollideShapeResult* result);

        /// <summary>
        /// Unsafe static delegate for OnContactAdded.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate void UnsafeContactAdded(void* udata, JPH_Body* bodyA, JPH_Body* bodyB, JPH_ContactManifold* manifold, JPH_ContactSettings* settings);

        /// <summary>
        /// Unsafe static delegate for OnContactRemoved.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate void UnsafeContactRemoved(void* udata, SubShapeIDPair* pair);

        /// <summary>
        /// Unsafe static delegate for OnContactPersisted.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate void UnsafeContactPersisted(void* udata, JPH_Body* bodyA, JPH_Body* bodyB, JPH_ContactManifold* manifold, JPH_ContactSettings* settings);

        /// <summary>
        /// Unsafe static implementation for OnContactValidate.
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeContactValidate))]
        private static ValidateResult UnsafeContactValidateCallback(void* udata, JPH_Body* bodyA, JPH_Body* bodyB, rvec3* offset, CollideShapeResult* result)
        {
            try
            {
                var b1 = new Body(new NativeHandle<JPH_Body>(bodyA));
                var b2 = new Body(new NativeHandle<JPH_Body>(bodyB));
                return ManagedReference.Deref<IContactListenerImplementation>((IntPtr)udata).OnContactValidate(b1, b2, *offset, *result);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }

            return ValidateResult.AcceptContact;
        }

        /// <summary>
        /// Unsafe static implementation for OnContactAdded.
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeContactAdded))]
        private static void UnsafeContactAddedCallback(void* udata, JPH_Body* bodyA, JPH_Body* bodyB, JPH_ContactManifold* manifold, JPH_ContactSettings* settings)
        {
            try
            {
                var b1 = new Body(new NativeHandle<JPH_Body>(bodyA));
                var b2 = new Body(new NativeHandle<JPH_Body>(bodyB));
                var m = new ContactManifold(new NativeHandle<JPH_ContactManifold>(manifold));
                var s = new ContactSettings(new NativeHandle<JPH_ContactSettings>(settings));
                ManagedReference.Deref<IContactListenerImplementation>((IntPtr)udata).OnContactAdded(b1, b2, m, s);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        /// <summary>
        /// Unsafe static implementation for OnContactRemoved.
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeContactRemoved))]
        private static void UnsafeContactRemovedCallback(void* udata, SubShapeIDPair* pair)
        {
            try
            {
                ManagedReference.Deref<IContactListenerImplementation>((IntPtr)udata).OnContactRemoved(*pair);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        /// <summary>
        /// Unsafe static implementation for OnContactPersisted.
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeContactPersisted))]
        private static void UnsafeContactPersistedCallback(void* udata, JPH_Body* bodyA, JPH_Body* bodyB, JPH_ContactManifold* manifold, JPH_ContactSettings* settings)
        {
            try
            {
                var b1 = new Body(new NativeHandle<JPH_Body>(bodyA));
                var b2 = new Body(new NativeHandle<JPH_Body>(bodyB));
                var m = new ContactManifold(new NativeHandle<JPH_ContactManifold>(manifold));
                var s = new ContactSettings(new NativeHandle<JPH_ContactSettings>(settings));
                ManagedReference.Deref<IContactListenerImplementation>((IntPtr)udata).OnContactPersisted(b1, b2, m, s);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}