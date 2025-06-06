using UnityEngine;
using AOT;

namespace Jolt.Unity
{
    internal static class JoltRuntimeInitialization
    {
        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            if (Jolt.Initialize())
            {
                Jolt.SetAssertFailureHandler(OnAssertFailure);
            }
            else
            {
                Debug.LogError("Jolt initialization failed.");
            }
        }

        [MonoPInvokeCallback(typeof(JPH_AssertFailureFunc))]
        private static bool OnAssertFailure(string expr, string message, string file, uint line)
        {
            Debug.Log($"Jolt Assertion Failed:\n{expr}\n{message}\n{file}\n{line}");
            return false;
        }
    }
}
