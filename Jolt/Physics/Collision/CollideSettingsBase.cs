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
    }
}
