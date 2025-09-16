namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_BodyFilter_Destroy(NativeHandle<JPH_BodyFilter> filter)
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_BodyFilter_Destroy(filter);

            filter.Dispose();
        }

        public static NativeHandle<JPH_IgnoreSingleBodyFilter> JPH_IgnoreSingleBodyFilter_Create(BodyID bodyID)
        {
            return CreateHandle(UnsafeBindings.JPH_IgnoreSingleBodyFilter_Create(bodyID));
        }

        public static NativeHandle<JPH_IgnoreMultipleBodiesFilter> JPH_IgnoreMultipleBodiesFilter_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_IgnoreMultipleBodiesFilter_Create());
        }

        public static void JPH_IgnoreMultipleBodiesFilter_Reserve(NativeHandle<JPH_IgnoreMultipleBodiesFilter> filter, int size)
        {
            UnsafeBindings.JPH_IgnoreMultipleBodiesFilter_Reserve(filter, (uint)size);
        }

        public static void JPH_IgnoreMultipleBodiesFilter_Clear(NativeHandle<JPH_IgnoreMultipleBodiesFilter> filter)
        {
            UnsafeBindings.JPH_IgnoreMultipleBodiesFilter_Clear(filter);
        }

        public static void JPH_IgnoreMultipleBodiesFilter_IgnoreBody(NativeHandle<JPH_IgnoreMultipleBodiesFilter> filter, BodyID bodyID)
        {
            UnsafeBindings.JPH_IgnoreMultipleBodiesFilter_IgnoreBody(filter, bodyID);
        }
    }
}
