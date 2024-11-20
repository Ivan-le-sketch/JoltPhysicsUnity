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

        /// <summary>
        /// Returns a new instance of <see cref="ExtendedUpdateSettings"/> initialized with default values defined here :
        /// https://jrouwe.github.io/JoltPhysics/struct_character_virtual_1_1_extended_update_settings.html
        /// </summary>
        /// <returns></returns>
        public static ExtendedUpdateSettings Default()
        {
            return new ExtendedUpdateSettings
            {
                stickToFloorStepDown = new float3(0.0f, 0.5f, 0.0f),
                walkStairsStepUp = new float3(0.0f, 0.4f, 0.0f),
                walkStairsMinStepForward = 0.02f,
                walkStairsStepForwardTest = 0.15f,
                walkStairsCosAngleForwardContact = math.cos(math.radians(75.0f)),
                walkStairsStepDownExtra = float3.zero,
            };
        }
    }
}
