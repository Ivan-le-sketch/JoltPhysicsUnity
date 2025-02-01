namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_BodyActivationListener> JPH_BodyActivationListener_Create(JPH_BodyActivationListener_Procs procs)
        {
            return CreateHandle(UnsafeBindings.JPH_BodyActivationListener_Create(procs, null));
        }

        public static void JPH_BodyActivationListener_Destroy(NativeHandle<JPH_BodyActivationListener> listener)
        {
            UnsafeBindings.JPH_BodyActivationListener_Destroy(listener);

            listener.Dispose();
        }
    }
}
