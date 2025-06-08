namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_BodyFilter> JPH_BodyFilter_Create(JPH_BodyFilter_Procs* procs, void* userData)
        {
            UnsafeBindings.JPH_BodyFilter_SetProcs(procs);

            return CreateHandle(UnsafeBindings.JPH_BodyFilter_Create(userData));
        }

        public static void JPH_BodyFilter_Destroy(NativeHandle<JPH_BodyFilter> filter)
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_BodyFilter_Destroy(filter);

            filter.Dispose();
        }
    }
}
