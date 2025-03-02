namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SoftBodyCreationSettings> JPH_SoftBodyCreationSettings_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_SoftBodyCreationSettings_Create());
        }

        public static void JPH_SoftBodyCreationSettings_Destroy(NativeHandle<JPH_SoftBodyCreationSettings> settings)
        {
            if (settings.HasUser()) return;

            UnsafeBindings.JPH_SoftBodyCreationSettings_Destroy(settings);

            settings.Dispose();
        }
    }
}
