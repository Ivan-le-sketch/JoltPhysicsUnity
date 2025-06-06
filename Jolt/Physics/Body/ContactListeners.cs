using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;

namespace Jolt
{
    /// <summary>
    /// Interface that mus be implemented by contact listener implementations.
    /// </summary>
    public interface IContactListenerImplementation
    {
        public ValidateResult OnContactValidate(Body body1, Body body2, rvec3 offset, CollideShapeResult result);

        public void OnContactAdded(Body body1, Body body2, ContactManifold manifold, ContactSettings settings);
        public void OnContactPersisted(Body body1, Body body2, ContactManifold manifold, ContactSettings settings);
        public void OnContactRemoved(SubShapeIDPair subShapePair);
    }

    public partial struct ContactListener
    {
        internal NativeHandle<JPH_ContactListener> Handle;

        public static ContactListener Create(IContactListenerImplementation implementation)
        {
            return new ContactListener { Handle = Bindings.JPH_ContactListener_Create(implementation) };
        }

        public void Destroy()
        {
            Bindings.JPH_ContactListener_Destroy(Handle);
        }
    }
}


