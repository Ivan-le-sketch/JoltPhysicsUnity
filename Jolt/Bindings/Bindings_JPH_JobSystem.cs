namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_JobSystem> JPH_JobSystemThreadingPool_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_JobSystemThreadPool_Create(null));
        }

        public static void JPH_JobSystem_Destroy(NativeHandle<JPH_JobSystem> jobSystem)
        {
            if (jobSystem.HasUser()) return;

            UnsafeBindings.JPH_JobSystem_Destroy(jobSystem);
            jobSystem.Dispose();
        }
    }
}
