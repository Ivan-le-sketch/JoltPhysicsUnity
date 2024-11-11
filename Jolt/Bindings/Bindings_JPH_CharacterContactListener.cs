using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        private static Dictionary<IntPtr, ICharacterContactListener> managedCharacterContactListeners = new();

        public static NativeHandle<JPH_CharacterContactListener> JPH_CharacterContactListener_Create(ICharacterContactListener managedListener)
        {
            int truc = 4;
            void* userdata = &truc;
            var listenerNativeHandle = CreateHandle(UnsafeBindings.JPH_CharacterContactListener_Create(UnsafeCharacterContactListenerProcs, userdata));

            managedCharacterContactListeners[(nint)userdata] = managedListener;

            return listenerNativeHandle;
        }

        public static void JPH_CharacterContactListener_Destroy(NativeHandle<JPH_CharacterContactListener> listener)
        {
            managedCharacterContactListeners.Remove((nint)listener.IntoPointer());

            UnsafeBindings.JPH_CharacterContactListener_Destroy(listener);

            listener.Dispose();
        }

        [DllImport("joltc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_CharacterContactListener_Destroy(JPH_CharacterContactListener* listener);

        private static readonly JPH_CharacterContactListener_Procs UnsafeCharacterContactListenerProcs = new JPH_CharacterContactListener_Procs
        {
            OnAdjustBodyVelocity = Marshal.GetFunctionPointerForDelegate((UnsafeAdjustBodyVelocity)UnsafeAdjustBodyVelocityCallback),
            OnContactValidate = Marshal.GetFunctionPointerForDelegate((UnsafeCharacterBodyContactValidate)UnsafeCharacterBodyContactValidateCallback),
            OnContactAdded = Marshal.GetFunctionPointerForDelegate((UnsafeCharacterBodyContactAdded)UnsafeCharacterBodyContactAddedCallback),
            OnContactSolve = Marshal.GetFunctionPointerForDelegate((UnsafeCharacterBodyContactSolve)UnsafeCharacterBodyContactSolveCallback),
        };

        private delegate void UnsafeAdjustBodyVelocity(IntPtr udata, JPH_CharacterVirtual* character, JPH_Body* body, float3* linearVelocity, float3* angularVelocity);

        private delegate bool UnsafeCharacterBodyContactValidate(IntPtr udata, JPH_CharacterVirtual* character, BodyID* bodyID, SubShapeID* subShapeID);

        private delegate void UnsafeCharacterBodyContactAdded(IntPtr udata, JPH_CharacterVirtual* character, BodyID* bodyID, SubShapeID* subShapeID, double3* contactPosition, float3* contactNormal, JPH_CharacterContactSettings* settings);

        private delegate void UnsafeCharacterBodyContactSolve(IntPtr udata, JPH_CharacterVirtual* character, BodyID* bodyID, SubShapeID* subShapeID, double3* contactPosition, float3* contactNormal, float3* contactVelocity, JPH_PhysicsMaterial* contactMaterial, float3* priorCharacterVelocity, float3* newCharacterVelocity);

        private static void UnsafeAdjustBodyVelocityCallback(IntPtr udata, JPH_CharacterVirtual* character, JPH_Body* body, float3* linearVelocity, float3* angularVelocity)
        {
            try
            {
                managedCharacterContactListeners[udata]?.OnAdjustBodyVelocity();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private static bool UnsafeCharacterBodyContactValidateCallback(IntPtr udata, JPH_CharacterVirtual* character, BodyID* bodyID, SubShapeID* subShapeID)
        {
            try
            {
                managedCharacterContactListeners[udata]?.OnCharacterBodyContactValidate();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }

            return true;
        }

        private static void UnsafeCharacterBodyContactAddedCallback(IntPtr udata, JPH_CharacterVirtual* character, BodyID* bodyID, SubShapeID* subShapeID, double3* contactPosition, float3* contactNormal, JPH_CharacterContactSettings* settings)
        {
            try
            {
                managedCharacterContactListeners[udata]?.OnCharacterBodyContactAdded();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private static void UnsafeCharacterBodyContactSolveCallback(IntPtr udata, JPH_CharacterVirtual* character, BodyID* bodyID, SubShapeID* subShapeID, double3* contactPosition, float3* contactNormal, float3* contactVelocity, JPH_PhysicsMaterial* contactMaterial, float3* priorCharacterVelocity, float3* newCharacterVelocity)
        {
            try
            {
                managedCharacterContactListeners[udata]?.OnCharacterBodyContactSolve();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}