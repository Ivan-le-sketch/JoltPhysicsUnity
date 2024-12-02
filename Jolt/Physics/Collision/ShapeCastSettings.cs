﻿using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct ShapeCastSettings
    {
        public CollideSettingsBase @base;

        public BackFaceMode backFaceModeTriangles;

        public BackFaceMode backFaceModeConvex;

        internal NativeBool useShrunkenShapeAndConvexRadius;

        internal NativeBool returnDeepestPoint;

        public bool UseShrunkenShapeAndConvexRadius
        {
            get => useShrunkenShapeAndConvexRadius;
            set => useShrunkenShapeAndConvexRadius = value;
        }

        public bool ReturnDeepestPoint
        {
            get => returnDeepestPoint;
            set => returnDeepestPoint = value;
        }
    }
}