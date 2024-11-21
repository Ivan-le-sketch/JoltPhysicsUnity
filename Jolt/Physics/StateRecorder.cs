namespace Jolt
{
    public unsafe struct StateRecorder
    {
        internal NativeHandle<JPH_StateRecorder> Handle;

        internal StateRecorder(NativeHandle<JPH_StateRecorder> handle) => Handle = handle;

        public static StateRecorder Create()
        {
            return new StateRecorder(Bindings.JPH_StateRecorder_Create());
        }

        public void Destroy()
        {
            Bindings.JPH_StateRecorder_Destroy(Handle);
        }

        public void SetValidating(bool validating)
        {
            Bindings.JPH_StateRecorder_SetValidating(Handle, validating);
        }

        public bool IsValidating()
        {
            return Bindings.JPH_StateRecorder_IsValidating(Handle);
        }

        public void Rewind()
        {
            Bindings.JPH_StateRecorder_Rewind(Handle);
        }

        public void Clear()
        {
            Bindings.JPH_StateRecorder_Clear(Handle);
        }

        public bool IsEOF()
        {
            return Bindings.JPH_StateRecorder_IsEOF(Handle);
        }

        public ulong GetSize()
        {
            return Bindings.JPH_StateRecorder_GetSize(Handle);
        }
    }
}
