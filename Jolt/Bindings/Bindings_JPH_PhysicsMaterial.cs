namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_PhysicsMaterial> JPH_PhysicsMaterial_Create()
        {
            return CreateHandle(UnsafeBindings.JPH_PhysicsMaterial_Create(null, 0));
        }
        
        public static void JPH_PhysicsMaterial_Destroy(NativeHandle<JPH_PhysicsMaterial> material)
        {
            if (material.HasUser()) return;

            UnsafeBindings.JPH_PhysicsMaterial_Destroy(material);
            
            material.Dispose();
        }
    }
}