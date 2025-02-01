using System.Runtime.InteropServices;

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

    /// <summary>
    /// Class that wraps a native Jolt contact listener
    /// </summary>
    public unsafe class ContactListener
    {
        internal NativeHandle<JPH_ContactListener> Handle;

        private IContactListenerImplementation implementation;

        private delegate ValidateResult OnContactValidate(void* userData, JPH_Body* bodyA, JPH_Body* bodyB, rvec3* offset, CollideShapeResult* result);
        private delegate void OnContactAdded(void* userData, JPH_Body* bodyA, JPH_Body* bodyB, JPH_ContactManifold* manifold, JPH_ContactSettings* settings);
        private delegate void OnContactPersisted(void* userData, JPH_Body* bodyA, JPH_Body* bodyB, JPH_ContactManifold* manifold, JPH_ContactSettings* settings);
        private delegate void OnContactRemoved(void* userData, SubShapeIDPair* subShapePair);

        private OnContactValidate onContactValidateDelegate;
        private OnContactAdded onContactAddedDelegate;
        private OnContactPersisted onContactPersistedDelegate;
        private OnContactRemoved onContactRemovedDelegate;

        public ContactListener()
        {
            CreateNativeListener();
        }

        public ContactListener(IContactListenerImplementation implementation)
        {
            CreateNativeListener();
            SetImplementation(implementation);
        }

        private void CreateNativeListener()
        {
            onContactValidateDelegate = OnContactValidateCallback;
            onContactAddedDelegate = OnContactAddedCallback;
            onContactPersistedDelegate = OnContactPersistedCallback;
            onContactRemovedDelegate = OnContactRemovedCallback;

            var procs = new JPH_ContactListener_Procs
            {
                OnContactValidate = Marshal.GetFunctionPointerForDelegate(onContactValidateDelegate),
                OnContactAdded = Marshal.GetFunctionPointerForDelegate(onContactAddedDelegate),
                OnContactPersisted = Marshal.GetFunctionPointerForDelegate(onContactPersistedDelegate),
                OnContactRemoved = Marshal.GetFunctionPointerForDelegate(onContactRemovedDelegate),
            };

            Handle = Bindings.JPH_ContactListener_Create(procs);
        }

        public void Destroy()
        {
            Bindings.JPH_ContactListener_Destroy(Handle);
        }

        public void SetImplementation(IContactListenerImplementation implementation)
        {
            this.implementation = implementation;
        }

        internal ValidateResult OnContactValidateCallback(void* userData, JPH_Body* body1, JPH_Body* body2, rvec3* offset, CollideShapeResult* result)
        {
            if (implementation != null)
            {
                var body1Wrapper = new Body(new NativeHandle<JPH_Body>(body1));
                var body2Wrapper = new Body(new NativeHandle<JPH_Body>(body2));
                return implementation.OnContactValidate(body1Wrapper, body2Wrapper, *offset, *result);
            }

            return ValidateResult.AcceptAllContactsForThisBodyPair;
        }

        internal void OnContactAddedCallback(void* userData, JPH_Body* body1, JPH_Body* body2, JPH_ContactManifold* manifold, JPH_ContactSettings* settings)
        {
            if (implementation != null)
            {
                var body1Wrapper = new Body(new NativeHandle<JPH_Body>(body1));
                var body2Wrapper = new Body(new NativeHandle<JPH_Body>(body2));
                var manifoldWrapper = new ContactManifold(new NativeHandle<JPH_ContactManifold>(manifold));
                var settingsWrapper = new ContactSettings(new NativeHandle<JPH_ContactSettings>(settings));
                implementation.OnContactAdded(body1Wrapper, body2Wrapper, manifoldWrapper, settingsWrapper);
            }
        }

        internal void OnContactPersistedCallback(void* userData, JPH_Body* body1, JPH_Body* body2, JPH_ContactManifold* manifold, JPH_ContactSettings* settings)
        {
            if (implementation != null)
            {
                var body1Wrapper = new Body(new NativeHandle<JPH_Body>(body1));
                var body2Wrapper = new Body(new NativeHandle<JPH_Body>(body2));
                var manifoldWrapper = new ContactManifold(new NativeHandle<JPH_ContactManifold>(manifold));
                var settingsWrapper = new ContactSettings(new NativeHandle<JPH_ContactSettings>(settings));
                implementation.OnContactPersisted(body1Wrapper, body2Wrapper, manifoldWrapper, settingsWrapper);
            }
        }

        internal void OnContactRemovedCallback(void* userData, SubShapeIDPair* pair)
        {
            if (implementation != null)
            {
                implementation.OnContactRemoved(*pair);
            }
        }
    }
}
