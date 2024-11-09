namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_JobSystem> JPH_JobSystemThreadingPool_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_JobSystemThreadPool_Create(null));
        }
    }
}