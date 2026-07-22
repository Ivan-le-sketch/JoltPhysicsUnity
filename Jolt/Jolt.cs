using System;

using System.Runtime.InteropServices;

using static Jolt.Bindings;

namespace Jolt
{
    public static class Jolt
    {
        private const ulong CrossPlatformDeterministicFeature = 1UL << 25;
        private const int NativeShapeCastResultSize = 60;

        /// <summary>
        /// True Jolt is current initialized.
        /// </summary>
        public static bool Initialized { get; private set; }

        /// <summary>
        /// Initialize Jolt, returning true if initialization succeeded.
        /// </summary>
        public static bool Initialize()
        {
            if (!Initialized)
            {
                int managedShapeCastResultSize = Marshal.SizeOf<ShapeCastResult>();
                if (managedShapeCastResultSize != NativeShapeCastResultSize)
                {
                    throw new InvalidOperationException($"ShapeCastResult ABI size mismatch: managed size is {managedShapeCastResultSize} bytes, native size is {NativeShapeCastResultSize} bytes.");
                }

                ulong versionID = JPH_GetVersionID();
                if ((versionID & CrossPlatformDeterministicFeature) == 0)
                {
                    throw new InvalidOperationException($"The loaded Jolt native library (version ID 0x{versionID:X16}) was not built with JPH_CROSS_PLATFORM_DETERMINISTIC.");
                }

                Initialized = JPH_Init();
            }

            return Initialized;
        }

        /// <summary>
        /// Set the assertion failure handler for Jolt.
        /// </summary>
        public static void SetAssertFailureHandler(AssertFailureHandler handler)
        {
            JPH_SetAssertFailureHandler(handler);
        }

        /// <summary>
        /// Shutdown Jolt.
        /// </summary>
        public static void Shutdown()
        {
            JPH_Shutdown();

            Initialized = false;
        }
    }
}
