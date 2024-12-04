using System;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_StateRecorderFilter> JPH_StateRecorderFilter_Create(JPH_StateRecorderFilter_Procs procs, IntPtr userData)
        {
            return CreateHandle(UnsafeBindings.JPH_StateRecorderFilter_Create(procs, (void*) userData));
        }

        public static void JPH_StateRecorderFilter_Destroy(NativeHandle<JPH_StateRecorderFilter> filter)
        {
            UnsafeBindings.JPH_StateRecorderFilter_Destroy(filter);

            filter.Dispose();
        }
    }
}