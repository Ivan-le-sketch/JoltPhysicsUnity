namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_ContactListener> JPH_ContactListener_Create(JPH_ContactListener_Procs procs)
        {
            return CreateHandle(UnsafeBindings.JPH_ContactListener_Create(procs, null));
        }

        public static void JPH_ContactListener_Destroy(NativeHandle<JPH_ContactListener> listener)
        {
            UnsafeBindings.JPH_ContactListener_Destroy(listener);

            listener.Dispose();
        }
    }
}
