using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        private static Dictionary<IntPtr, IBodyActivationListener> managedBodyActivationListeners = new ();

        public static NativeHandle<JPH_BodyActivationListener> JPH_BodyActivationListener_Create(IBodyActivationListener managedListener)
        {
            int truc = 4;
            void* userData = &truc;
            var listenerNativeHandle = CreateHandle(UnsafeBindings.JPH_BodyActivationListener_Create(UnsafeBodyActivationListenerProcs, userData));

            managedBodyActivationListeners[(nint)userData] = managedListener;

            return listenerNativeHandle;
        }

        public static void JPH_BodyActivationListener_Destroy(NativeHandle<JPH_BodyActivationListener> listener)
        {
            managedBodyActivationListeners.Remove((nint) listener.IntoPointer());

            UnsafeBindings.JPH_BodyActivationListener_Destroy(listener.IntoPointer());

            listener.Dispose();
        }

        public static void JPH_BodyActivationListener_DestroyAll()
        {
            // TODO : Destroy all remaining listeners
        }

        private static readonly JPH_BodyActivationListener_Procs UnsafeBodyActivationListenerProcs = new () {
            OnBodyActivated   = Marshal.GetFunctionPointerForDelegate((UnsafeBodyActivated) UnsafeBodyActivatedCallback),
            OnBodyDeactivated = Marshal.GetFunctionPointerForDelegate((UnsafeBodyDeactivated) UnsafeBodyDeactivatedCallback),
        };

        private delegate void UnsafeBodyActivated(IntPtr udata, BodyID bodyID, ulong bodyUserData);

        private delegate void UnsafeBodyDeactivated(IntPtr udata, BodyID bodyID, ulong bodyUserData);

        private static void UnsafeBodyActivatedCallback(IntPtr udata, BodyID bodyID, ulong bodyUserData)
        {
            try
            {
                managedBodyActivationListeners[udata]?.OnBodyActivated(bodyID, bodyUserData);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private static void UnsafeBodyDeactivatedCallback(IntPtr udata, BodyID bodyID, ulong bodyUserData)
        {
            try
            {
                managedBodyActivationListeners[udata]?.OnBodyDeactivated(bodyID, bodyUserData);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}
