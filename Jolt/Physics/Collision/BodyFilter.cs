using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Jolt
{
    /// <summary>
    /// Filter defining bodies to ignore in a collision query.
    /// </summary>
    public unsafe class BodyFilter : IDisposable
    {
        internal NativeHandle<JPH_BodyFilter> Handle;

        /// <summary>
        /// HashSet determining body ids to ignore.
        /// </summary>
        private HashSet<BodyID> ignoredBodyIDs = new HashSet<BodyID>();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldCollide(IntPtr context, BodyID bodyID);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldCollideLocked(IntPtr context, JPH_Body* body);

        // Keep a reference to the delegate to prevent garbage collection
        internal ShouldCollide shouldCollideDelegate;
        // Keep a reference to the delegate to prevent garbage collection
        internal ShouldCollideLocked shouldCollideLockedDelegate;

        public BodyFilter()
        {
            CreateNativeHandle();
        }

        public BodyFilter(List<BodyID> bodyIDs)
        {
            CreateNativeHandle();

            foreach (BodyID bodyID in bodyIDs)
            {
                AddIgnoredBodyID(bodyID);
            }
        }

        public void Dispose()
        {
            Bindings.JPH_BodyFilter_Destroy(Handle);
        }

        public void AddIgnoredBodyID(BodyID bodyID)
        {
            ignoredBodyIDs.Add(bodyID);
        }

        public void RemoveIgnoredBodyID(BodyID bodyID)
        {
            ignoredBodyIDs.Remove(bodyID);
        }

        public void ClearIgnoredBodyID()
        {
            ignoredBodyIDs.Clear();
        }

        internal bool ShouldCollideCallback(IntPtr context, BodyID bodyID)
        {
            return !ignoredBodyIDs.Contains(bodyID);
        }

        internal bool ShouldCollideLockedCallback(IntPtr context, JPH_Body* body)
        {
            var bodyHandle = new Body(new NativeHandle<JPH_Body>(body));

            bool result = !ignoredBodyIDs.Contains(bodyHandle.GetID());

            bodyHandle.Handle.Dispose();

            return result;
        }

        private void CreateNativeHandle()
        {
            shouldCollideDelegate = ShouldCollideCallback;
            shouldCollideLockedDelegate = ShouldCollideLockedCallback;

            var procs = new JPH_BodyFilter_Procs
            {
                ShouldCollide = Marshal.GetFunctionPointerForDelegate(shouldCollideDelegate),
                ShouldCollideLocked = Marshal.GetFunctionPointerForDelegate(shouldCollideLockedDelegate),
            };

            Handle = Bindings.JPH_BodyFilter_Create(procs);
        }
    }
}
