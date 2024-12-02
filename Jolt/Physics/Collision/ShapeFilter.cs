using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Jolt
{
    public unsafe class ShapeFilter : IDisposable
    {
        public enum FilterMode
        {
            CollideWithSelection,
            IgnoreSelection,
        }

        internal NativeHandle<JPH_ShapeFilter> Handle;

        private FilterMode mode;
        private HashSet<SubShapeID> subShapeIDSelection = new HashSet<SubShapeID>();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldCollide(IntPtr userData, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate bool ShouldCollide2(IntPtr userData, JPH_Shape* shape1, SubShapeID* subShapeIDOfShape1, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2);

        private ShouldCollide shouldeCollideDelegate;
        private ShouldCollide2 shouldCollide2Delegate;

        public ShapeFilter()
        {
            CreateNativeHandle();
        }

        public ShapeFilter(IEnumerable<SubShapeID> subShapes, FilterMode filterMode)
        {
            CreateNativeHandle();

            foreach (SubShapeID subShape in subShapes)
            {
                subShapeIDSelection.Add(subShape);
            }

            mode = filterMode;
        }

        public void Dispose()
        {
            Bindings.JPH_ShapeFilter_Destroy(Handle);
        }

        internal bool ShouldCollideCallback(IntPtr userData, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2)
        {
            var id = *subShapeIDOfShape2;

            if (mode == FilterMode.CollideWithSelection)
            {
                return subShapeIDSelection.Contains(id);
            }
            else
            {
                return !subShapeIDSelection.Contains(id);
            }
        }

        internal bool ShouldCollide2Callback(IntPtr userData, JPH_Shape* shape1, SubShapeID* subShapeIDOfShape1, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2)
        {
            var id = *subShapeIDOfShape2;

            if (mode == FilterMode.CollideWithSelection)
            {
                return subShapeIDSelection.Contains(id);
            }
            else
            {
                return !subShapeIDSelection.Contains(id);
            }
        }

        private void CreateNativeHandle()
        {
            shouldeCollideDelegate = ShouldCollideCallback;
            shouldCollide2Delegate = ShouldCollide2Callback;

            var procs = new JPH_ShapeFilter_Procs
            {
                ShouldCollide = Marshal.GetFunctionPointerForDelegate(shouldeCollideDelegate),
                ShouldCollide2 = Marshal.GetFunctionPointerForDelegate(shouldCollide2Delegate),
            };

            Handle = Bindings.JPH_ShapeFilter_Create(procs);
        }
    }
}
