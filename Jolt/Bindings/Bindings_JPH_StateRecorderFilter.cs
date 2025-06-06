using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_StateRecorderFilter> JPH_StateRecorderFilter_Create(IStateRecorderFilter filter)
        {
            var gch = GCHandle.Alloc(filter);
            var ptr = GCHandle.ToIntPtr(gch);

            fixed (JPH_StateRecorderFilter_Procs* procsPtr = &UnsafeStateRecorderFilterProcs)
            {
                var handle = CreateHandle(UnsafeBindings.JPH_StateRecorderFilter_Create(UnsafeStateRecorderFilterProcs, (void*)ptr)); // TODO

                ManagedReference.Add(handle, gch);

                return handle;
            }
        }

        public static void JPH_StateRecorderFilter_Destroy(NativeHandle<JPH_StateRecorderFilter> filter)
        {
            if (filter.HasUser()) return;

            if (ManagedReference.Remove(filter, out var gch))
            {
                gch.Free();
            }
            else
            {
                Debug.LogError("Missing GCHandle for managed state recorder filter!");
            }

            UnsafeBindings.JPH_StateRecorderFilter_Destroy(filter);

            filter.Dispose();
        }

        /// <summary>
        /// Static procs for marshalling; the lookup from static to instance context happens in each method.
        /// </summary>
        private static readonly JPH_StateRecorderFilter_Procs UnsafeStateRecorderFilterProcs = new()
        {
            ShouldSaveBody = GetDelegatePointer((UnsafeShouldSaveBody)UnsafeShouldSaveBodyCallback),
            ShouldSaveConstraint = GetDelegatePointer((UnsafeShouldSaveConstraint)UnsafeShouldSaveConstraintCallback),
            ShouldSaveContact = GetDelegatePointer((UnsafeShouldSaveContact)UnsafeShouldSaveContactCallback),
            ShouldRestoreContact = GetDelegatePointer((UnsafeShouldRestoreContact)UnsafeShouldRestoreContactCallback),
        };

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool UnsafeShouldSaveBody(IntPtr userData, JPH_Body* body);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool UnsafeShouldSaveConstraint(IntPtr userData, JPH_Constraint* constraint);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool UnsafeShouldSaveContact(IntPtr userData, BodyID bodyID1, BodyID bodyID2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool UnsafeShouldRestoreContact(IntPtr userData, BodyID bodyID1, BodyID bodyID2);

        [MonoPInvokeCallback(typeof(UnsafeShouldSaveBody))]
        private static bool UnsafeShouldSaveBodyCallback(IntPtr userData, JPH_Body* body)
        {
            try
            {
                var b = new Body(new NativeHandle<JPH_Body>(body));
                return ManagedReference.Deref<IStateRecorderFilter>(userData).ShouldSaveBody(b);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return true;
            }
        }

        [MonoPInvokeCallback(typeof(UnsafeShouldSaveConstraint))]
        private static bool UnsafeShouldSaveConstraintCallback(IntPtr userData, JPH_Constraint* constraint)
        {
            try
            {
                var c = new Constraint(new NativeHandle<JPH_Constraint>(constraint));
                return ManagedReference.Deref<IStateRecorderFilter>(userData).ShouldSaveConstraint(c);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return true;
            }
        }

        [MonoPInvokeCallback(typeof(UnsafeShouldSaveContact))]
        private static bool UnsafeShouldSaveContactCallback(IntPtr userData, BodyID bodyID1, BodyID bodyID2)
        {
            try
            {
                return ManagedReference.Deref<IStateRecorderFilter>(userData).ShouldSaveContact(bodyID1, bodyID2);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return true;
            }
        }

        [MonoPInvokeCallback(typeof(UnsafeShouldRestoreContact))]
        private static bool UnsafeShouldRestoreContactCallback(IntPtr userData, BodyID bodyID1, BodyID bodyID2)
        {
            try
            {
                return ManagedReference.Deref<IStateRecorderFilter>(userData).ShouldRestoreContact(bodyID1, bodyID2);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return true;
            }
        }
    }
}