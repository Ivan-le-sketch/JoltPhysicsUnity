using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SimShapeFilter> JPH_SimShapeFilter_Create(ISimShapeFilterImplementation filter)
        {
            var gch = GCHandle.Alloc(filter);
            var ptr = GCHandle.ToIntPtr(gch);

            fixed (JPH_SimShapeFilter_Procs* procsPtr = &UnsafeSimShapeFilterProcs)
            {
                var handle = CreateHandle(UnsafeBindings.JPH_SimShapeFilter_Create(procsPtr, (void*)ptr));

                ManagedReference.Add(handle, gch);

                return handle;
            }
        }

        public static void JPH_SimShapeFilter_Destroy(NativeHandle<JPH_SimShapeFilter> filter)
        {
            if (filter.HasUser()) return;

            if (ManagedReference.Remove(filter, out var gch))
            {
                gch.Free();
            }
            else
            {
                Debug.LogError("Missing GCHandle for managed sim shape filter!");
            }

            UnsafeBindings.JPH_SimShapeFilter_Destroy(filter);

            filter.Dispose();
        }

        /// <summary>
        /// Static procs for marshalling; the lookup from static to instance context happens in each method.
        /// </summary>
        private static readonly JPH_SimShapeFilter_Procs UnsafeSimShapeFilterProcs = new()
        {
            ShouldCollide = GetDelegatePointer((UnsafeShouldCollide)UnsafeShouldCollideCallback),
        };

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate bool UnsafeShouldCollide(IntPtr userData,
            JPH_Body* body1, JPH_Shape* shape1, SubShapeID* subShapeID1,
            JPH_Body* body2, JPH_Shape* shape2, SubShapeID* subShapeID2);

        /// <summary>
        /// Unsafe static implementation for ShouldCollide
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeShouldCollide))]
        private static bool UnsafeShouldCollideCallback(IntPtr udata, 
            JPH_Body* body1, JPH_Shape* shape1, SubShapeID* subShapeID1,
            JPH_Body* body2, JPH_Shape* shape2, SubShapeID* subShapeID2)
        {
            try
            {
                var body1Wrapper = new Body(new NativeHandle<JPH_Body>(body1));
                var shape1Wrapper = new Shape(new NativeHandle<JPH_Shape>(shape1));
                var body2Wrapper = new Body(new NativeHandle<JPH_Body>(body2));
                var shape2Wrapper = new Shape(new NativeHandle<JPH_Shape>(shape2));
                return ManagedReference.Deref<ISimShapeFilterImplementation>(udata).ShouldCollide(body1Wrapper, shape1Wrapper, *subShapeID1, body2Wrapper, shape2Wrapper, *subShapeID2);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return true;
            }
        }
    }
}
