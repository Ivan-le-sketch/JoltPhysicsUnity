using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RayCastSettings
    {
        public BackFaceMode backFaceModeTriangles;
        public BackFaceMode backFaceModeConvex;
        public NativeBool treatConvexAsSolid;

        public static RayCastSettings Default()
        {
            return new RayCastSettings
            {
                backFaceModeTriangles = BackFaceMode.IgnoreBackFaces,
                backFaceModeConvex = BackFaceMode.IgnoreBackFaces,
                treatConvexAsSolid = true,
            };
        }
    }
}