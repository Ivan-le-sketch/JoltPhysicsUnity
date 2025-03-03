using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    /// <summary>
    /// Interface that mus be implemented by sim shape filter implementations.
    /// </summary>
    public interface ISimShapeFilterImplementation
    {
        public bool ShouldCollide(Body body1, Shape shape1, SubShapeID subShapeID1, Body body2, Shape shape2, SubShapeID subShapeID2);
    }

    /// <summary>
    /// Class that wraps a native Jolt contact listener
    /// </summary>
    public unsafe class SimShapeFilter
    {
        internal NativeHandle<JPH_SimShapeFilter> Handle;

        private ISimShapeFilterImplementation implementation;

        private delegate bool ShouldCollide(
            void* userData, 
            JPH_Body* body1, JPH_Shape* shape1, SubShapeID* subShapeID1,
            JPH_Body* body2, JPH_Shape* shape2, SubShapeID* subShapeID2);

        private ShouldCollide shouldCollideDelegate;

        private IntPtr procsUnmanagedPointer;
        internal JPH_SimShapeFilter_Procs* Procs => (JPH_SimShapeFilter_Procs*)procsUnmanagedPointer;

        public SimShapeFilter()
        {
            CreateNativeListener();
        }

        public SimShapeFilter(ISimShapeFilterImplementation implementation)
        {
            CreateNativeListener();
            SetImplementation(implementation);
        }

        private void CreateNativeListener()
        {
            shouldCollideDelegate = ShouldCollideCallback;

            var procs = new JPH_SimShapeFilter_Procs
            {
                ShouldCollide = Marshal.GetFunctionPointerForDelegate(shouldCollideDelegate),
            };
            procsUnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(JPH_SimShapeFilter_Procs)));
            Marshal.StructureToPtr(procs, procsUnmanagedPointer, false);

            Handle = Bindings.JPH_SimShapeFilter_Create(Procs);
        }

        public void Destroy()
        {
            Bindings.JPH_SimShapeFilter_Destroy(Handle);
            Marshal.FreeHGlobal(procsUnmanagedPointer);
        }

        public void SetImplementation(ISimShapeFilterImplementation implementation)
        {
            this.implementation = implementation;
        }

        internal bool ShouldCollideCallback(void* userData, 
            JPH_Body* body1, JPH_Shape* shape1, SubShapeID* subShapeID1,
            JPH_Body* body2, JPH_Shape* shape2, SubShapeID* subShapeID2)
        {
            if (implementation == null) return true;

            var body1Wrapper = new Body(new NativeHandle<JPH_Body>(body1));
            var shape1Wrapper = new Shape(new NativeHandle<JPH_Shape>(shape1));
            var body2Wrapper = new Body(new NativeHandle<JPH_Body>(body2));
            var shape2Wrapper = new Shape(new NativeHandle<JPH_Shape>(shape2));
            return implementation.ShouldCollide(body1Wrapper, shape1Wrapper, *subShapeID1, body2Wrapper, shape2Wrapper, *subShapeID2);
        }
    }
}

