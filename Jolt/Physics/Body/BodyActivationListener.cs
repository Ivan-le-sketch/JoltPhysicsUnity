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
    public partial struct BodyActivationListener
    {
        internal NativeHandle<JPH_BodyActivationListener> Handle;

        public static BodyActivationListener Create(IBodyActivationListenerImplementation implementation)
        {
            return new BodyActivationListener { Handle = Bindings.JPH_BodyActivationListener_Create(implementation) };
        }

        public void Destroy()
        {
            Bindings.JPH_BodyActivationListener_Destroy(Handle);
        }
    }
}
