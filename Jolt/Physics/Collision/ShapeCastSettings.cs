using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct ShapeCastSettings
    {
        public CollideSettingsBase @base;

        public BackFaceMode backFaceModeTriangles;
        public BackFaceMode backFaceModeConvex;
        public NativeBool useShrunkenShapeAndConvexRadius;
        public NativeBool returnDeepestPoint;

        public static ShapeCastSettings Default()
        {
            return new ShapeCastSettings
            {
                @base = CollideSettingsBase.Default(),
                backFaceModeTriangles = BackFaceMode.IgnoreBackFaces,
                backFaceModeConvex = BackFaceMode.IgnoreBackFaces,
                useShrunkenShapeAndConvexRadius = false,
                returnDeepestPoint = false,
            };
        }
    }
}