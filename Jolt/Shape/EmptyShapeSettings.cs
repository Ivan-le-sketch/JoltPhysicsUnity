using Unity.Mathematics;
using static Jolt.Bindings;


namespace Jolt
{
    [GenerateHandle("JPH_EmptyShapeSettings"), GenerateBindings("JPH_EmptyShapeSettings", "JPH_ShapeSettings")]
    public readonly partial struct EmptyShapeSettings
    {
        /// <summary>
        /// Allocate a new native EmptyShapeSettings and return the handle.
        /// </summary>
        [OverrideBinding("JPH_EmptyShapeSettings_Create")]
        public static EmptyShapeSettings Create(float3 centerOfMass)
        {
            return new EmptyShapeSettings(JPH_EmptyShapeSettings_Create(centerOfMass));
        }
    }
}
