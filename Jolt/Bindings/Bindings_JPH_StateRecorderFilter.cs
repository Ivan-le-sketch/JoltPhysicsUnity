using AOT;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        private static readonly HashSet<NativeHandle<JPH_StateRecorderFilter>> nativeStateRecorderFilters = new();

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

        public static NativeHandle<JPH_StateRecorderFilter> JPH_StateRecorderFilter_CreateNative(
            bool saveOnlyBodiesInBroadPhase,
            bool saveOnlyEnabledConstraints)
        {
            var handle = CreateHandle(UnsafeBindings.JPH_StateRecorderFilter_CreateNative(
                saveOnlyBodiesInBroadPhase,
                saveOnlyEnabledConstraints));
            nativeStateRecorderFilters.Add(handle);
            return handle;
        }

        public static void JPH_StateRecorderFilter_Destroy(NativeHandle<JPH_StateRecorderFilter> filter)
        {
            if (filter.HasUser()) return;

            if (!nativeStateRecorderFilters.Remove(filter))
            {
                if (ManagedReference.Remove(filter, out var gch))
                {
                    gch.Free();
                }
                else
                {
                    Debug.LogError("Missing GCHandle for managed state recorder filter!");
                }
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
        private delegate NativeBool UnsafeShouldSaveBody(IntPtr userData, JPH_Body* body);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate NativeBool UnsafeShouldSaveConstraint(IntPtr userData, JPH_Constraint* constraint);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate NativeBool UnsafeShouldSaveContact(IntPtr userData, BodyID bodyID1, BodyID bodyID2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate NativeBool UnsafeShouldRestoreContact(IntPtr userData, BodyID bodyID1, BodyID bodyID2);

        [MonoPInvokeCallback(typeof(UnsafeShouldSaveBody))]
        private static NativeBool UnsafeShouldSaveBodyCallback(IntPtr userData, JPH_Body* body)
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
        private static NativeBool UnsafeShouldSaveConstraintCallback(IntPtr userData, JPH_Constraint* constraint)
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
        private static NativeBool UnsafeShouldSaveContactCallback(IntPtr userData, BodyID bodyID1, BodyID bodyID2)
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
        private static NativeBool UnsafeShouldRestoreContactCallback(IntPtr userData, BodyID bodyID1, BodyID bodyID2)
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
