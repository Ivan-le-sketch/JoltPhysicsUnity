namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_ShapeSettings_Destroy(NativeHandle<JPH_ShapeSettings> settings)
        {
            if (settings.HasUser()) return;

            UnsafeBindings.JPH_ShapeSettings_Destroy(settings.Reinterpret<JPH_ShapeSettings>());

            settings.Dispose();
        }
    }
}
