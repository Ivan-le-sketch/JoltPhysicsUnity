using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_StaticCompoundShape> JPH_StaticCompoundShape_Create(NativeHandle<JPH_StaticCompoundShapeSettings> settings)
        {
            return CreateHandle(UnsafeBindings.JPH_StaticCompoundShape_Create(settings));
        }
    }
}