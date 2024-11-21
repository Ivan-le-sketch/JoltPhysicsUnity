namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_StateRecorder> JPH_StateRecorder_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_StateRecorder_Create());
        }

        public static void JPH_StateRecorder_Destroy(NativeHandle<JPH_StateRecorder> recorder)
        {
            UnsafeBindings.JPH_StateRecorder_Destroy(recorder);

            recorder.Dispose();
        }

        public static void JPH_StateRecorder_SetValidating(NativeHandle<JPH_StateRecorder> recorder, bool validating)
        {
            UnsafeBindings.JPH_StateRecorder_SetValidating(recorder, validating);
        }

        public static bool JPH_StateRecorder_IsValidating(NativeHandle<JPH_StateRecorder> recorder)
        {
            return UnsafeBindings.JPH_StateRecorder_IsValidating(recorder);
        }

        public static void JPH_StateRecorder_Rewind(NativeHandle<JPH_StateRecorder> recorder)
        {
            UnsafeBindings.JPH_StateRecorder_Rewind(recorder);
        }

        public static void JPH_StateRecorder_Clear(NativeHandle<JPH_StateRecorder> recorder)
        {
            UnsafeBindings.JPH_StateRecorder_Clear(recorder);
        }

        public static bool JPH_StateRecorder_IsEOF(NativeHandle<JPH_StateRecorder> recorder)
        {
            return UnsafeBindings.JPH_StateRecorder_IsEOF(recorder);
        }

        public static bool JPH_StateRecorder_IsFailed(NativeHandle<JPH_StateRecorder> recorder)
        {
            return UnsafeBindings.JPH_StateRecorder_IsFailed(recorder);
        }

        public static bool JPH_StateRecorder_IsEqual(NativeHandle<JPH_StateRecorder> recorder, NativeHandle<JPH_StateRecorder> other)
        {
            return UnsafeBindings.JPH_StateRecorder_IsEqual(recorder, other);
        }

        public static void JPH_StateRecorder_WriteBytes(NativeHandle<JPH_StateRecorder> recorder, void* data, ulong size)
        {
            UnsafeBindings.JPH_StateRecorder_WriteBytes(recorder, data, size);
        }

        public static void JPH_StateRecorder_ReadBytes(NativeHandle<JPH_StateRecorder> recorder, void* data, ulong size)
        {
            UnsafeBindings.JPH_StateRecorder_ReadBytes(recorder, data, size);
        }

        public static ulong JPH_StateRecorder_GetSize(NativeHandle<JPH_StateRecorder> recorder)
        {
            return UnsafeBindings.JPH_StateRecorder_GetSize(recorder);
        }
    }
}
