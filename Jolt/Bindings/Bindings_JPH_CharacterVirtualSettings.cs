namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static void JPH_CharacterVirtualSettings_Init(JPH_CharacterVirtualSettings* settings)
        {
            UnsafeBindings.JPH_CharacterVirtualSettings_Init(settings);
        }

        public static void JPH_CharacterVirtualSettings_SetShape(NativeHandle<JPH_CharacterVirtualSettings> settings, NativeHandle<JPH_Shape> shape)
        {
            settings.IntoPointer()->@base.shape = shape;
        }
    }
}
