using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace Jolt
{
    public interface ICharacterContactListenerBehaviour
    {
        public void OnAdjustBodyVelocity(CharacterVirtual character, Body body, ref float3 linearVelocity, ref float3 angularVelocity);
        public bool OnCharacterContactValidate(CharacterVirtual character, CharacterVirtual otherCharacter, SubShapeID subShapeID);
        public void OnCharacterContactAdded(CharacterVirtual character, CharacterVirtual otherCharacter, SubShapeID subShapeID, rvec3 contactPosition, float3 contactNormal);//, ref JPH_CharacterContactSettings settings);
        public void OnCharacterContactSolve(CharacterVirtual character, CharacterVirtual otherCharacter, SubShapeID subShapeID, rvec3 contactPosition, float3 contactNormal, float3 contactVelocity, PhysicsMaterial contactMaterial, float3 characterVelocity, ref float3 newCharacterVelocity);
        public bool OnContactValidate(CharacterVirtual character, BodyID bodyID, SubShapeID subShapeID);
        public void OnContactAdded(CharacterVirtual character, BodyID bodyID, SubShapeID subShapeID, rvec3 contactPosition, float3 contactNormal);//, ref JPH_CharacterContactSettings settings);
        public void OnContactSolve(CharacterVirtual character, BodyID bodyID, SubShapeID subShapeID, rvec3 contactPosition, float3 contactNormal, float3 contactVelocity, PhysicsMaterial contactMaterial, float3 characterVelocity, ref float3 newCharacterVelocity);
    }

    public unsafe class CharacterContactListener : IDisposable
    {
        internal NativeHandle<JPH_CharacterContactListener> Handle;

        private ICharacterContactListenerBehaviour behaviour;

        private delegate void OnAdjustBodyVelocity(IntPtr userData, JPH_CharacterVirtual* character, JPH_Body* body, float3* linearVelocity, float3* angularVelocity);
        private delegate NativeBool OnCharacterContactValidate(IntPtr userData, JPH_CharacterVirtual* character, JPH_CharacterVirtual* otherCharacter, SubShapeID subShapeID);
        private delegate void OnCharacterContactAdded(IntPtr userData, JPH_CharacterVirtual* character, JPH_CharacterVirtual* otherCharacter, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, JPH_CharacterContactSettings* settings);
        private delegate void OnCharacterContactSolve(IntPtr userData, JPH_CharacterVirtual* character, JPH_CharacterVirtual* otherCharacter, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, float3* contactVelocity, JPH_PhysicsMaterial* contactMaterial, float3* characterVelocity, float3* newCharacterVelocity);
        private delegate NativeBool OnContactValidate(IntPtr userData, JPH_CharacterVirtual* character, BodyID bodyID, SubShapeID subShapeID);
        private delegate void OnContactAdded(IntPtr userData, JPH_CharacterVirtual* character, BodyID bodyID, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, JPH_CharacterContactSettings* settings);
        private delegate void OnContactSolve(IntPtr userData, JPH_CharacterVirtual* character, BodyID bodyID, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, float3* contactVelocity, JPH_PhysicsMaterial* contactMaterial, float3* characterVelocity, float3* newCharacterVelocity);

        private OnAdjustBodyVelocity onAdjustBodyVelocityDelegate;
        private OnCharacterContactValidate onCharacterContactValidateDelegate;
        private OnCharacterContactAdded onCharacterContactAddedDelegate;
        private OnCharacterContactSolve onCharacterContactSolveDelegate;
        private OnContactValidate onContactValidateDelegate;
        private OnContactAdded onContactAddedDelegate;
        private OnContactSolve onContactSolveDelegate;

        private IntPtr procsUnmanagedPointer;
        internal JPH_CharacterContactListener_Procs* Procs => (JPH_CharacterContactListener_Procs*)procsUnmanagedPointer;

        public void Create(ICharacterContactListenerBehaviour behaviour)
        {
            this.behaviour = behaviour;

            onAdjustBodyVelocityDelegate = OnAdjustBodyVelocityCallback;
            onCharacterContactValidateDelegate = OnCharacterContactValidateCallback;
            onCharacterContactAddedDelegate = OnCharacterContactAddedCallback;
            onCharacterContactSolveDelegate = OnCharacterContactSolveCallback;
            onContactValidateDelegate = OnContactValidateCallback;
            onContactAddedDelegate = OnContactAddedCallback;
            onContactSolveDelegate = OnContactSolveCallback;

            var procs = new JPH_CharacterContactListener_Procs
            {
                OnAdjustBodyVelocity = Marshal.GetFunctionPointerForDelegate(onAdjustBodyVelocityDelegate),
                OnContactValidate = Marshal.GetFunctionPointerForDelegate(onContactValidateDelegate),
                OnCharacterContactValidate = Marshal.GetFunctionPointerForDelegate(onCharacterContactValidateDelegate),
                OnContactAdded = Marshal.GetFunctionPointerForDelegate(onContactAddedDelegate),
                OnCharacterContactAdded = Marshal.GetFunctionPointerForDelegate(onCharacterContactAddedDelegate),
                OnContactSolve = Marshal.GetFunctionPointerForDelegate(onContactSolveDelegate),
                OnCharacterContactSolve = Marshal.GetFunctionPointerForDelegate(onCharacterContactSolveDelegate),
            };
            procsUnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(JPH_CharacterContactListener_Procs)));
            Marshal.StructureToPtr(procs, procsUnmanagedPointer, false);

            Handle = Bindings.JPH_CharacterContactListener_Create(Procs);
        }

        public void Dispose()
        {
            Bindings.JPH_CharacterContactListener_Destroy(Handle);
            Marshal.FreeHGlobal(procsUnmanagedPointer);
        }

        #region Listener callbacks
        internal void OnAdjustBodyVelocityCallback(IntPtr userData, JPH_CharacterVirtual* character, JPH_Body* body, float3* linearVelocity, float3* angularVelocity)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));
            Body bodyHandle = new Body(new NativeHandle<JPH_Body>(body));

            behaviour.OnAdjustBodyVelocity(characterHandle, bodyHandle, ref *linearVelocity, ref *angularVelocity);

            // Free resources
            characterHandle.Handle.Dispose();
            bodyHandle.Handle.Dispose();
        }

        internal NativeBool OnCharacterContactValidateCallback(IntPtr userData, JPH_CharacterVirtual* character, JPH_CharacterVirtual* otherCharacter, SubShapeID subShapeID)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));
            CharacterVirtual otherCharacterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(otherCharacter));

            bool result = behaviour.OnCharacterContactValidate(characterHandle, otherCharacterHandle, subShapeID);

            // Free resources
            characterHandle.Handle.Dispose();
            otherCharacterHandle.Handle.Dispose();

            return result;
        }

        internal void OnCharacterContactAddedCallback(IntPtr userData, JPH_CharacterVirtual* character, JPH_CharacterVirtual* otherCharacter, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, JPH_CharacterContactSettings* settings)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));
            CharacterVirtual otherCharacterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(otherCharacter));

            behaviour.OnCharacterContactAdded(characterHandle, otherCharacterHandle, subShapeID, *contactPosition, *contactNormal);

            // Free resources
            characterHandle.Handle.Dispose();
            otherCharacterHandle.Handle.Dispose();
        }

        internal void OnCharacterContactSolveCallback(IntPtr userData, JPH_CharacterVirtual* character, JPH_CharacterVirtual* otherCharacter, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, float3* contactVelocity, JPH_PhysicsMaterial* contactMaterial, float3* characterVelocity, float3* newCharacterVelocity)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));
            CharacterVirtual otherCharacterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(otherCharacter));
            PhysicsMaterial contactMaterialHandle = new PhysicsMaterial(new NativeHandle<JPH_PhysicsMaterial>(contactMaterial));

            behaviour.OnCharacterContactSolve(characterHandle, otherCharacterHandle, subShapeID, *contactPosition, *contactNormal, *contactVelocity, contactMaterialHandle, *characterVelocity, ref *newCharacterVelocity);

            // Free resources
            characterHandle.Handle.Dispose();
            otherCharacterHandle.Handle.Dispose();
            contactMaterialHandle.Handle.Dispose();
        }

        internal NativeBool OnContactValidateCallback(IntPtr userData, JPH_CharacterVirtual* character, BodyID bodyID, SubShapeID subShapeID)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));

            bool result = behaviour.OnContactValidate(characterHandle, bodyID, subShapeID);

            // Free resources
            characterHandle.Handle.Dispose();

            return result;
        }

        internal void OnContactAddedCallback(IntPtr userData, JPH_CharacterVirtual* character, BodyID bodyID, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, JPH_CharacterContactSettings* settings)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));

            behaviour.OnContactAdded(characterHandle, bodyID, subShapeID, *contactPosition, *contactNormal);

            // Free resources
            characterHandle.Handle.Dispose();
        }

        internal void OnContactSolveCallback(IntPtr userData, JPH_CharacterVirtual* character, BodyID bodyID, SubShapeID subShapeID, rvec3* contactPosition, float3* contactNormal, float3* contactVelocity, JPH_PhysicsMaterial* contactMaterial, float3* characterVelocity, float3* newCharacterVelocity)
        {
            CharacterVirtual characterHandle = new CharacterVirtual(new NativeHandle<JPH_CharacterVirtual>(character));
            PhysicsMaterial contactMaterialHandle = new PhysicsMaterial(new NativeHandle<JPH_PhysicsMaterial>(contactMaterial));

            behaviour.OnContactSolve(characterHandle, bodyID, subShapeID, *contactPosition, *contactNormal, *contactVelocity, contactMaterialHandle, *characterVelocity, ref *newCharacterVelocity);

            // Free resources
            characterHandle.Handle.Dispose();
            contactMaterialHandle.Handle.Dispose();
        }
        #endregion
    }
}