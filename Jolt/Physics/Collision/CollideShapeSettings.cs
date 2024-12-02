using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct CollideShapeSettings
    {
        public CollideSettingsBase @base;

        public float maxSeparationDistance;

        public BackFaceMode backFaceMode;
    }
}