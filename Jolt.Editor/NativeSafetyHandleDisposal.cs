using UnityEditor;

namespace Jolt.Editor
{
    /// <summary>
    /// Automatically disposes the NativeSafetyHandle context when exiting play mode.
    /// </summary>
    public static class NativeSafetyHandleDisposal
    {
        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange change)
        {
#if !JOLT_DISABLE_SAFETY_CHECkS
            if (change == PlayModeStateChange.EnteredEditMode)
            {
                NativeSafetyHandle.Dispose();
            }
#endif
        }
    }
}
