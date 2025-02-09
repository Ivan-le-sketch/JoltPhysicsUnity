using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    /// <summary>
    /// Interface that mus be implemented by body activation listener implementations.
    /// </summary>
    public interface IBodyActivationListenerImplementation
    {
        public void OnBodyActivated(BodyID bodyID, ulong bodyUserData);

        public void OnBodyDeactivated(BodyID bodyID, ulong bodyUserData);
    }

    /// <summary>
    /// Class that wraps a native Jolt body activation listener.
    /// </summary>
    public unsafe class BodyActivationListener
    {
        internal NativeHandle<JPH_BodyActivationListener> Handle;

        private IBodyActivationListenerImplementation implementation;

        private delegate void OnBodyActivated(void* userData, BodyID bodyID, ulong bodyUserData);
        private delegate void OnBodyDeactivated(void* userData, BodyID bodyID, ulong bodyUserData);

        private OnBodyActivated onBodyActivatedDelegate;
        private OnBodyDeactivated onBodyDeactivatedDelegate;

        private IntPtr procsUnmanagedPointer;

        internal JPH_BodyActivationListener_Procs* Procs => (JPH_BodyActivationListener_Procs*)procsUnmanagedPointer;

        public BodyActivationListener()
        {
            CreateNativeListener();
        }

        public BodyActivationListener(IBodyActivationListenerImplementation implementation)
        {
            CreateNativeListener();
            SetImplementation(implementation);
        }

        private void CreateNativeListener()
        {
            onBodyActivatedDelegate = OnBodyActivatedCallback;
            onBodyDeactivatedDelegate = OnBodyDeactivatedCallback;

            var procs =  new JPH_BodyActivationListener_Procs
            {
                OnBodyActivated = Marshal.GetFunctionPointerForDelegate(onBodyActivatedDelegate),
                OnBodyDeactivated = Marshal.GetFunctionPointerForDelegate(onBodyDeactivatedDelegate),
            };
            procsUnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(JPH_BodyActivationListener_Procs)));
            Marshal.StructureToPtr(procs, procsUnmanagedPointer, false);

            Handle = Bindings.JPH_BodyActivationListener_Create(Procs);
        }

        public void Destroy()
        {
            Bindings.JPH_BodyActivationListener_Destroy(Handle);
            Marshal.FreeHGlobal(procsUnmanagedPointer);
        }

        public void SetImplementation(IBodyActivationListenerImplementation implementation)
        {
            this.implementation = implementation;
        }

        internal void OnBodyActivatedCallback(void* userData, BodyID bodyID, ulong bodyUserData)
        {
            if (implementation != null)
            {
                implementation.OnBodyActivated(bodyID, bodyUserData);
            }
        }

        internal void OnBodyDeactivatedCallback(void* userData, BodyID bodyID, ulong bodyUserData)
        {
            if (implementation != null)
            {
                implementation.OnBodyDeactivated(bodyID, bodyUserData);
            }
        }
    }
}
