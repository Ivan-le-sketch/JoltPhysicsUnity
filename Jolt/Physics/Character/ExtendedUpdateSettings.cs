using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ExtendedUpdateSettings
    {
        public float3 stickToFloorStepDown;

        public float3 walkStairsStepUp;

        public float walkStairsMinStepForward;

        public float walkStairsStepForwardTest;

        public float walkStairsCosAngleForwardContact;

        public float3 walkStairsStepDownExtra;
    }
}
