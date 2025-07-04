﻿using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_BodyActivationListener> JPH_BodyActivationListener_Create(IBodyActivationListenerImplementation listener)
        {
            fixed (JPH_BodyActivationListener_Procs* procsPtr = &UnsafeBodyActivationListenerProcs)
            {
                UnsafeBindings.JPH_BodyActivationListener_SetProcs(procsPtr);
            }

            // See Bindings_JPH_ContactListener for comments.

            var gch = GCHandle.Alloc(listener);
            var ptr = GCHandle.ToIntPtr(gch);

            var handle = CreateHandle(UnsafeBindings.JPH_BodyActivationListener_Create((void*)ptr));

            ManagedReference.Add(handle, gch);

            return handle;
        }

        public static void JPH_BodyActivationListener_Destroy(NativeHandle<JPH_BodyActivationListener> listener)
        {
            if (listener.HasUser()) return;

            if (ManagedReference.Remove(listener, out var gch))
            {
                gch.Free();
            }
            else
            {
                Debug.LogError("Missing GCHandle for managed body listener!");
            }

            UnsafeBindings.JPH_BodyActivationListener_Destroy(listener);

            listener.Dispose();
        }

        private static void InitializeBodyActivationListeners()
        {
            fixed (JPH_BodyActivationListener_Procs* ptr = &UnsafeBodyActivationListenerProcs)
            {
            }
        }

        /// <summary>
        /// Static procs for marshalling; the lookup from static to instance context happens in each method.
        /// </summary>
        private static readonly JPH_BodyActivationListener_Procs UnsafeBodyActivationListenerProcs = new()
        {
            OnBodyActivated = GetDelegatePointer((UnsafeBodyActivated)UnsafeBodyActivatedCallback),
            OnBodyDeactivated = GetDelegatePointer((UnsafeBodyDeactivated)UnsafeBodyDeactivatedCallback),
        };

        /// <summary>
        /// Unsafe static delegate for OnBodyActivated.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate void UnsafeBodyActivated(IntPtr udata, BodyID bodyID, ulong bodyUserData);

        /// <summary>
        /// Unsafe static delegate for OnBodyDeactivated.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate void UnsafeBodyDeactivated(IntPtr udata, BodyID bodyID, ulong bodyUserData);

        /// <summary>
        /// Unsafe static implementation for OnBodyActivated.
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeBodyActivated))]
        private static void UnsafeBodyActivatedCallback(IntPtr udata, BodyID bodyID, ulong bodyUserData)
        {
            try
            {
                ManagedReference.Deref<IBodyActivationListenerImplementation>(udata).OnBodyActivated(bodyID, bodyUserData);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        /// <summary>
        /// Unsafe static implementation for OnBodyDeactivated.
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeBodyDeactivated))]
        private static void UnsafeBodyDeactivatedCallback(IntPtr udata, BodyID bodyID, ulong bodyUserData)
        {
            try
            {
                ManagedReference.Deref<IBodyActivationListenerImplementation>(udata).OnBodyDeactivated(bodyID, bodyUserData);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}