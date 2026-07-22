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
        private static readonly Dictionary<NativeHandle<JPH_SimShapeFilter>, int> fastSimShapeFilterIds = new();

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

        public static NativeHandle<JPH_SimShapeFilter> JPH_SimShapeFilterFast_Create(IFastSimShapeFilterImplementation filter)
        {
            fixed (JPH_SimShapeFilterFast_Procs* procsPtr = &UnsafeFastSimShapeFilterProcs)
            {
                UnsafeBindings.JPH_SimShapeFilterFast_SetProcs(procsPtr);
            }

            int id = ManagedReference<IFastSimShapeFilterImplementation>.Add(filter);
            var handle = CreateHandle(UnsafeBindings.JPH_SimShapeFilterFast_Create((void*)id));
            fastSimShapeFilterIds[handle] = id;
            return handle;
        }

        public static void JPH_SimShapeFilterFast_SetBodyCallbackEnabled(
            NativeHandle<JPH_SimShapeFilter> filter,
            BodyID bodyID,
            bool enabled)
        {
            if (!fastSimShapeFilterIds.ContainsKey(filter))
                throw new InvalidOperationException("Body callback routing is only available on a fast simulation shape filter.");
            UnsafeBindings.JPH_SimShapeFilterFast_SetBodyCallbackEnabled(filter, bodyID, enabled);
        }

        public static void JPH_SimShapeFilter_Destroy(NativeHandle<JPH_SimShapeFilter> filter)
        {
            if (filter.HasUser()) return;

            if (fastSimShapeFilterIds.TryGetValue(filter, out var fastId))
            {
                ManagedReference<IFastSimShapeFilterImplementation>.Remove(fastId);
                fastSimShapeFilterIds.Remove(filter);
            }
            else if (simShapeFilterIds.TryGetValue(filter, out var id))
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

        private static readonly JPH_SimShapeFilterFast_Procs UnsafeFastSimShapeFilterProcs = new()
        {
            ShouldCollide = GetDelegatePointer((UnsafeFastShouldCollide)UnsafeFastShouldCollideCallback),
        };

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate NativeBool UnsafeShouldCollide(IntPtr userData,
            JPH_Body* body1, JPH_Shape* shape1, SubShapeID* subShapeID1,
            JPH_Body* body2, JPH_Shape* shape2, SubShapeID* subShapeID2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate NativeBool UnsafeFastShouldCollide(IntPtr userData,
            SimShapeFilterBodyData* body1, SimShapeFilterBodyData* body2);

        /// <summary>
        /// Unsafe static implementation for ShouldCollide
        /// </summary>
        [MonoPInvokeCallback(typeof(UnsafeShouldCollide))]
        private static NativeBool UnsafeShouldCollideCallback(IntPtr udata,
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

        [MonoPInvokeCallback(typeof(UnsafeFastShouldCollide))]
        private static NativeBool UnsafeFastShouldCollideCallback(
            IntPtr udata,
            SimShapeFilterBodyData* body1,
            SimShapeFilterBodyData* body2)
        {
            return ManagedReference<IFastSimShapeFilterImplementation>.Get(udata.ToInt32()).ShouldCollide(ref *body1, ref *body2);
        }
    }
}
