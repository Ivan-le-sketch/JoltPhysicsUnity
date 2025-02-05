using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    public unsafe class StateRecorderFilter
    {
        internal NativeHandle<JPH_StateRecorderFilter> Handle;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldSaveBody(IntPtr userData, JPH_Body* body);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldSaveConstraint(IntPtr userData, JPH_Constraint* constraint);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldSaveContact(IntPtr userData, BodyID bodyID1, BodyID bodyID2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldRestoreContact(IntPtr userData, BodyID bodyID1, BodyID bodyID2);

        private ShouldSaveBody shouldSaveBodyDelegate;
        private ShouldSaveConstraint shouldSaveConstraintDelegate;
        private ShouldSaveContact shouldSaveContactDelegate;
        private ShouldSaveContact shouldRestoreContactDelegate;

        public StateRecorderFilter()
        {
            CreateNativeHandle();
        }

        public void Destroy()
        {
            Bindings.JPH_StateRecorderFilter_Destroy(Handle);
        }

        public virtual bool ShouldSaveBodyCallbackImplementation(Body body)
        {
            return true;
        }

        public virtual bool ShouldSaveConstraintCallbackImplementation(Constraint constraint)
        {
            return true;
        }

        public virtual bool ShouldSaveContactCallbackImplementation(BodyID bodyID1, BodyID bodyID2)
        {
            return true;
        }

        public virtual bool ShouldRestoreContactCallbackImplementation(BodyID bodyID1, BodyID bodyID2)
        {
            return true;
        }

        internal bool ShouldSaveBodyCallback(IntPtr userData, JPH_Body* unsafeBody)
        {
            var body = new Body(new NativeHandle<JPH_Body>(unsafeBody));

            bool result = ShouldSaveBodyCallbackImplementation(body);

            body.Handle.Dispose();

            return result;
        }

        internal bool ShouldSaveConstraintCallback(IntPtr userData, JPH_Constraint* unsafeConstraint)
        {
            var constraint = new Constraint(new NativeHandle<JPH_Constraint>(unsafeConstraint));

            bool result = ShouldSaveConstraintCallbackImplementation(constraint);

            constraint.Handle.Dispose();

            return result;
        }

        internal bool ShouldSaveContactCallback(IntPtr userData, BodyID bodyID1, BodyID bodyID2)
        {
            return ShouldSaveContactCallbackImplementation(bodyID1, bodyID2);
        }

        internal bool ShouldRestoreContactCallback(IntPtr userData, BodyID bodyID1, BodyID bodyID2)
        {
            return ShouldRestoreContactCallbackImplementation(bodyID1, bodyID2);
        }

        protected void CreateNativeHandle()
        {
            shouldSaveBodyDelegate = ShouldSaveBodyCallback;
            shouldSaveConstraintDelegate = ShouldSaveConstraintCallback;
            shouldSaveContactDelegate = ShouldSaveContactCallback;
            shouldRestoreContactDelegate = ShouldRestoreContactCallback;

            JPH_StateRecorderFilter_Procs procs = new JPH_StateRecorderFilter_Procs
            {
                ShouldSaveBody = Marshal.GetFunctionPointerForDelegate(shouldSaveBodyDelegate),
                ShouldSaveConstraint = Marshal.GetFunctionPointerForDelegate(shouldSaveConstraintDelegate),
                ShouldSaveContact = Marshal.GetFunctionPointerForDelegate(shouldSaveContactDelegate),
                ShouldRestoreContact = Marshal.GetFunctionPointerForDelegate(shouldRestoreContactDelegate),
            };

            Handle = Bindings.JPH_StateRecorderFilter_Create(procs, IntPtr.Zero);
        }
    }
}
