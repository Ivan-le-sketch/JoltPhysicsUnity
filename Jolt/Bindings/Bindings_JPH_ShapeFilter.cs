﻿namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_ShapeFilter> JPH_ShapeFilter_Create(JPH_ShapeFilter_Procs procs)
        {
            return CreateHandle(UnsafeBindings.JPH_ShapeFilter_Create(procs, null));
        }

        public static void JPH_ShapeFilter_Destroy(NativeHandle<JPH_ShapeFilter> filter)
        {
            UnsafeBindings.JPH_ShapeFilter_Destroy(filter);

            filter.Dispose();
        }

        public static void JPH_ShapeFilter_SetBodyID2(NativeHandle<JPH_ShapeFilter> filter, BodyID bodyID)
        {
            UnsafeBindings.JPH_ShapeFilter_SetBodyID2(filter, bodyID);
        }

        public static BodyID JPH_ShapeFilter_GetBodyID2(NativeHandle<JPH_ShapeFilter> filter)
        {
            return UnsafeBindings.JPH_ShapeFilter_GetBodyID2(filter);
        }
    }
}