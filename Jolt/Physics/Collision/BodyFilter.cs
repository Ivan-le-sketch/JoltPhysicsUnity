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
        public enum FilterMode
        {
            CollideWithSelection,
            IgnoreSelection,
        }

        internal NativeHandle<JPH_BodyFilter> Handle;

        private FilterMode mode;
        private HashSet<BodyID> bodyIDSelection = new HashSet<BodyID>();

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

        public BodyFilter(IEnumerable<BodyID> bodyIDs, FilterMode filterMode)
        {
            CreateNativeHandle();

            foreach (BodyID bodyID in bodyIDs)
            {
                AddBodyIDToSelection(bodyID);
            }

            mode = filterMode;
        }

        public void Dispose()
        {
            Bindings.JPH_BodyFilter_Destroy(Handle);
        }

        public void SetFilterMode(FilterMode filterMode)
        {
            mode = filterMode;
        }

        public void AddBodyIDToSelection(BodyID bodyID)
        {
            bodyIDSelection.Add(bodyID);
        }

        public void RemoveBodyIDFromSelection(BodyID bodyID)
        {
            bodyIDSelection.Remove(bodyID);
        }

        public void ClearBodyIDSelection()
        {
            bodyIDSelection.Clear();
        }

        internal bool ShouldCollideCallback(IntPtr context, BodyID bodyID)
        {
            if (mode == FilterMode.CollideWithSelection)
            {
                return bodyIDSelection.Contains(bodyID);
            }
            else
            {
                return !bodyIDSelection.Contains(bodyID);
            }
        }

        internal bool ShouldCollideLockedCallback(IntPtr context, JPH_Body* body)
        {
            var bodyHandle = new Body(new NativeHandle<JPH_Body>(body));

            bool result = true;

            if (mode == FilterMode.CollideWithSelection)
            {
                result = bodyIDSelection.Contains(bodyHandle.GetID());
            }
            else
            {
                result = !bodyIDSelection.Contains(bodyHandle.GetID());
            }

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
