using AOT;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        private static readonly Dictionary<NativeHandle<JPH_SimShapeFilter>, int> simShapeFilterIds = new();

        public static NativeHandle<JPH_SimShapeFilter> JPH_SimShapeFilter_Create(ISimShapeFilterImplementation filter)
        {
            fixed (JPH_SimShapeFilter_Procs* procsPtr = &UnsafeSimShapeFilterProcs)
            {
                UnsafeBindings.JPH_SimShapeFilter_SetProcs(procsPtr);
            }

            int id = ManagedReference<ISimShapeFilterImplementation>.Add(filter);
            var ptr = new IntPtr(id);
            var handle = CreateHandle(UnsafeBindings.JPH_SimShapeFilter_Create((void*)ptr));
            simShapeFilterIds[handle] = id;

            return handle;
        }

        public static void JPH_SimShapeFilter_Destroy(NativeHandle<JPH_SimShapeFilter> filter)
        {
            if (filter.HasUser()) return;

            if (simShapeFilterIds.TryGetValue(filter, out var id))
            {
                ManagedReference<ISimShapeFilterImplementation>.Remove(id);
                simShapeFilterIds.Remove(filter);
            }
            else
            {
                Debug.LogError("Missing SimShapeFilter ID for managed filter destruction!");
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
            var body1Wrapper = new Body(new NativeHandle<JPH_Body>(body1));
            var shape1Wrapper = new Shape(new NativeHandle<JPH_Shape>(shape1));
            var body2Wrapper = new Body(new NativeHandle<JPH_Body>(body2));
            var shape2Wrapper = new Shape(new NativeHandle<JPH_Shape>(shape2));
            int id = udata.ToInt32();
            return ManagedReference<ISimShapeFilterImplementation>.Get(id).ShouldCollide(body1Wrapper, shape1Wrapper, *subShapeID1, body2Wrapper, shape2Wrapper, *subShapeID2);
        }
    }
}
