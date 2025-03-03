namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SimShapeFilter> JPH_SimShapeFilter_Create(JPH_SimShapeFilter_Procs* procs)
        {
            return CreateHandle(UnsafeBindings.JPH_SimShapeFilter_Create(procs, null));
        }

        public static void JPH_SimShapeFilter_Destroy(NativeHandle<JPH_SimShapeFilter> filter)
        {
            if (filter.HasUser()) return;

            UnsafeBindings.JPH_SimShapeFilter_Destroy(filter);

            filter.Dispose();
        }
    }
}
