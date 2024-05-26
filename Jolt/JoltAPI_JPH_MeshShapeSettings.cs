﻿using System;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class JoltAPI
    {
        public static NativeHandle<JPH_MeshShapeSettings> JPH_MeshShapeSettings_Create(ReadOnlySpan<Triangle> triangles)
        {
            fixed (Triangle* trianglesPtr = triangles)
            {
                return CreateHandle(Bindings.JPH_MeshShapeSettings_Create(trianglesPtr, (uint)triangles.Length));
            }
        }

        public static NativeHandle<JPH_MeshShapeSettings> JPH_MeshShapeSettings_Create2(ReadOnlySpan<float3> vertices, ReadOnlySpan<IndexedTriangle> triangles)
        {
            fixed (float3* verticesPtr = vertices)
            fixed (IndexedTriangle* trianglesPtr = triangles)
            {
                return CreateHandle(Bindings.JPH_MeshShapeSettings_Create2(verticesPtr, (uint)vertices.Length, trianglesPtr, (uint)triangles.Length));
            }
        }

        public static void JPH_MeshShapeSettings_Sanitize(NativeHandle<JPH_MeshShapeSettings> settings)
        {
            Bindings.JPH_MeshShapeSettings_Sanitize(GetPointer(settings));
        }

        public static NativeHandle<JPH_MeshShape> JPH_MeshShapeSettings_CreateShape(NativeHandle<JPH_MeshShapeSettings> settings)
        {
            return CreateHandle(Bindings.JPH_MeshShapeSettings_CreateShape(GetPointer(settings)));
        }
    }
}
