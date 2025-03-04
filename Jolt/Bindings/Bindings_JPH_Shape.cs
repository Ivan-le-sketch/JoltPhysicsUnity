﻿using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_Shape_Destroy(NativeHandle<JPH_Shape> shape)
        {
            if (shape.HasUser()) return;

            UnsafeBindings.JPH_Shape_Destroy(shape);

            shape.Dispose();
        }

        public static ShapeType JPH_Shape_GetType(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_GetType(shape);
        }

        public static ShapeSubType JPH_Shape_GetSubType(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_GetSubType(shape);
        }

        public static ulong JPH_Shape_GetUserData(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_GetUserData(shape);
        }

        public static void JPH_Shape_SetUserData(NativeHandle<JPH_Shape> shape, ulong userData)
        {
            UnsafeBindings.JPH_Shape_SetUserData(shape, userData);
        }

        public static bool JPH_Shape_MustBeStatic(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_MustBeStatic(shape);
        }

        public static float3 JPH_Shape_GetCenterOfMass(NativeHandle<JPH_Shape> shape)
        {
            float3 result;

            UnsafeBindings.JPH_Shape_GetCenterOfMass(shape, &result);

            return result;
        }

        public static AABox JPH_Shape_GetLocalBounds(NativeHandle<JPH_Shape> shape)
        {
            AABox result;

            UnsafeBindings.JPH_Shape_GetLocalBounds(shape, &result);

            return result;
        }

        public static uint JPH_Shape_GetSubShapeIDBitsRecursive(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_GetSubShapeIDBitsRecursive(shape);
        }

        public static AABox JPH_Shape_GetWorldSpaceBounds(NativeHandle<JPH_Shape> shape, rmatrix4x4 centerOfMassTransform, float3 scale)
        {
            AABox result;

            UnsafeBindings.JPH_Shape_GetWorldSpaceBounds(shape, &centerOfMassTransform, &scale, &result);

            return result;
        }

        public static float JPH_Shape_GetInnerRadius(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_GetInnerRadius(shape);
        }

        public static MassProperties JPH_Shape_GetMassProperties(NativeHandle<JPH_Shape> shape)
        {
            MassProperties result;

            UnsafeBindings.JPH_Shape_GetMassProperties(shape, &result);

            return result;
        }

        public static NativeHandle<JPH_Shape> JPH_Shape_GetLeafShape(NativeHandle<JPH_Shape> shape, SubShapeID subShapeID, out SubShapeID remainder)
        {
            fixed (SubShapeID* ptr = &remainder)
            {
                return CreateHandle(UnsafeBindings.JPH_Shape_GetLeafShape(shape, subShapeID, ptr));
            }
        }

        public static NativeHandle<JPH_PhysicsMaterial> JPH_Shape_GetMaterial(NativeHandle<JPH_Shape> shape, SubShapeID subShapeID)
        {
            return CreateHandle(UnsafeBindings.JPH_Shape_GetMaterial(shape, subShapeID));
        }

        public static float3 JPH_Shape_GetSurfaceNormal(NativeHandle<JPH_Shape> shape, SubShapeID subShapeID, float3 localPosition)
        {
            float3 result;

            UnsafeBindings.JPH_Shape_GetSurfaceNormal(shape, subShapeID, &localPosition, &result);

            return result;
        }

        public static float JPH_Shape_GetVolume(NativeHandle<JPH_Shape> shape)
        {
            return UnsafeBindings.JPH_Shape_GetVolume(shape);
        }

        public static bool JPH_Shape_IsValidScale(NativeHandle<JPH_Shape> shape, float3 scale)
        {
            return UnsafeBindings.JPH_Shape_IsValidScale(shape, &scale);
        }

        public static float3 JPH_Shape_MakeScaleValid(NativeHandle<JPH_Shape> shape, float3 scale)
        {
            float3 result;

            UnsafeBindings.JPH_Shape_MakeScaleValid(shape, &scale, &result);

            return result;
        }

        public static NativeHandle<JPH_Shape> JPH_Shape_ScaleShape(NativeHandle<JPH_Shape> shape, float3 scale)
        {
            return CreateHandle(UnsafeBindings.JPH_Shape_ScaleShape(shape, &scale));
        }

        public static bool JPH_Shape_CastRay(NativeHandle<JPH_Shape> shape, float3 origin, float3 direction, out RayCastResult result)
        {
            result = default;
            
            fixed (RayCastResult* resultptr = &result)
            {
                return UnsafeBindings.JPH_Shape_CastRay(shape, &origin, &direction, resultptr);
            }
        }

        public static bool JPH_Shape_CollidePoint(NativeHandle<JPH_Shape> shape, float3 point, NativeHandle<JPH_ShapeFilter> shapeFilter)
        {
            return UnsafeBindings.JPH_Shape_CollidePoint(shape.IntoPointer(), &point, shapeFilter.IntoPointer());
        }
    }
}
