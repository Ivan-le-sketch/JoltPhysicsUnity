using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct CollideSettingsBase
    {
        public ActiveEdgeMode activeEdgeMode;

        public CollectFacesMode collectFacesMode;

        public float collisionTolerance;

        public float penetrationTolerance;

        public float3 activeEdgeMovementDirection;

        public static CollideSettingsBase Default()
        {
            return new CollideSettingsBase
            {
                activeEdgeMode = ActiveEdgeMode.JPH_ActiveEdgeMode_CollideOnlyWithActive,
                collectFacesMode = CollectFacesMode.JPH_CollectFacesMode_NoFaces,
                collisionTolerance = 1.0e-4f,
                penetrationTolerance = 1.0e-4f,
                activeEdgeMovementDirection = float3.zero
            };
        }
    }
}
