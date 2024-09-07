﻿using Unity.Mathematics;
using static Jolt.Bindings;

namespace Jolt
{
    /// <summary>
    /// A widened CompoundShapeSettings instance handle.
    /// </summary>
    [GenerateHandle("JPH_CompoundShapeSettings"), GenerateBindings("JPH_CompoundShapeSettings", "JPH_ShapeSettings")]
    public readonly partial struct CompoundShapeSettings
    {
        public static implicit operator CompoundShapeSettings(MutableCompoundShapeSettings settings)
        {
            return new CompoundShapeSettings(settings.Handle.Reinterpret<JPH_CompoundShapeSettings>());
        }

        public static implicit operator CompoundShapeSettings(StaticCompoundShapeSettings settings)
        {
            return new CompoundShapeSettings(settings.Handle.Reinterpret<JPH_CompoundShapeSettings>());
        }

        [OverrideBinding("JPH_CompoundShapeSettings_AddShape")]
        public void AddShape(float3 position, quaternion rotation, ShapeSettings shape, uint userData = 0)
        {
            JPH_CompoundShapeSettings_AddShape(Handle, position, rotation, shape.Handle, userData);
        }

        [OverrideBinding("JPH_CompoundShapeSettings_AddShape2")]
        public void AddShape(float3 position, quaternion rotation, Shape shape, uint userData)
        {
            JPH_CompoundShapeSettings_AddShape2(Handle, position, rotation, shape.Handle, userData);
        }
    }
}
