namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_CharacterContactListener> JPH_CharacterContactListener_Create(JPH_CharacterContactListener_Procs* procs)
        {
            return CreateHandle(UnsafeBindings.JPH_CharacterContactListener_Create(null));
        }

        public static void JPH_CharacterContactListener_Destroy(NativeHandle<JPH_CharacterContactListener> listener)
        {
            if (listener.HasUser()) return;

            UnsafeBindings.JPH_CharacterContactListener_Destroy(listener);

            listener.Dispose();
        }
    }
}