﻿using System.Runtime.InteropServices;

namespace Jolt
{
    internal static partial class Bindings
    {
        public static bool JPH_Init()
        {
            return UnsafeBindings.JPH_Init();
        }

        public static void JPH_Shutdown()
        {
            UnsafeBindings.JPH_Shutdown();
        }

        public static void JPH_SetAssertFailureHandler(AssertFailureHandler handler)
        {
            UnsafeBindings.JPH_SetAssertFailureHandler(Marshal.GetFunctionPointerForDelegate(handler));
        }
    }

    /// <summary>
    /// A delegate for receiving Jolt assertion failures.
    /// </summary>
    public delegate void AssertFailureHandler(string expr, string message, string file, uint line);
}
