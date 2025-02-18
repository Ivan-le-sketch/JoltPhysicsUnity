namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_BodyFilter> JPH_BodyFilter_Create(JPH_BodyFilter_Procs* procs, void* userData)
        {
            return CreateHandle(UnsafeBindings.JPH_BodyFilter_Create(procs, userData));
        }

        public static void JPH_BodyFilter_Destroy(NativeHandle<JPH_BodyFilter> filter)
        {
            UnsafeBindings.JPH_BodyFilter_Destroy(filter);
        }
    }
}
