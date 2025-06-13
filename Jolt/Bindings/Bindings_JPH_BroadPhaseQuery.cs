using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        /*public static bool JPH_BroadPhaseQuery_CastRay(NativeHandle<JPH_BroadPhaseQuery> query, float3 origin, float3 direction, CollisionCollector<BroadPhaseCastResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter)
        {
            JPH_RayCastBodyCollector tempDelegate = CollisionCollector<BroadPhaseCastResult>.AddResultWithEarlyOutUpdate2;

            return UnsafeBindings.JPH_BroadPhaseQuery_CastRay(query, &origin, &direction, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter);
        }*/

        /*public static bool JPH_BroadPhaseQuery_CastRay2(NativeHandle<JPH_BroadPhaseQuery> query, float3 origin, float3 direction, CollisionCollectorType collectorType, UnsafeCollisionCollector<BroadPhaseCastResult> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter)
        {
            JPH_RayCastBodyResultCallback tempDelegate = collector.AddResult;

            return UnsafeBindings.JPH_BroadPhaseQuery_CastRay2(query, &origin, &direction, collectorType, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter);
        }

        public static bool JPH_BroadPhaseQuery_CollideAABox(NativeHandle<JPH_BroadPhaseQuery> query, AABox box, CollisionCollector<BodyID> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter)
        {
            JPH_CollideShapeBodyCollector tempDelegate = collector.AddResultWithEarlyOutUpdate;

            return UnsafeBindings.JPH_BroadPhaseQuery_CollideAABox(query, &box, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter);
        }

        public static bool JPH_BroadPhaseQuery_CollideSphere(NativeHandle<JPH_BroadPhaseQuery> query, float3 center, float radius, CollisionCollector<BodyID> collector, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter)
        {
            JPH_CollideShapeBodyCollector tempDelegate = collector.AddResultWithEarlyOutUpdate;

            return UnsafeBindings.JPH_BroadPhaseQuery_CollideSphere(query, &center, radius, Marshal.GetFunctionPointerForDelegate(tempDelegate), (void*)userData, broadPhaseLayerFilter, objectLayerFilter);
        }

        public static bool JPH_BroadPhaseQuery_CollidePoint(NativeHandle<JPH_BroadPhaseQuery> query, float3 point, CollideShapeBodyCollector_Procs callback, IntPtr userData, NativeHandle<JPH_BroadPhaseLayerFilter>? broadPhaseLayerFilter, NativeHandle<JPH_ObjectLayerFilter>? objectLayerFilter)
        {
            return UnsafeBindings.JPH_BroadPhaseQuery_CollidePoint(query, &point, Marshal.GetFunctionPointerForDelegate(callback), (void*)userData, broadPhaseLayerFilter, objectLayerFilter);
        }*/
    }
}