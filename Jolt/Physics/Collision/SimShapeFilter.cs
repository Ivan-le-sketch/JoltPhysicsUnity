using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SimShapeFilterBodyData
    {
        private const uint StaticBody = 1u << 0;

        internal nint BodyPointer;
        internal nint ShapePointer;
        internal nint LeafShapePointer;
        public ulong BodyUserData;
        public ulong LeafShapeUserData;
        public BodyID BodyID;
        public ObjectLayer ObjectLayer;
        public SubShapeID SubShapeID;
        public SubShapeID LeafShapeRemainder;
        internal uint BodyFlags;
        public float ShapeVolume;

        public Body GetBody() => new Body(new NativeHandle<JPH_Body>((JPH_Body*)BodyPointer));
        public Shape GetShape() => new Shape(new NativeHandle<JPH_Shape>((JPH_Shape*)ShapePointer));
        public BodyID GetID() => BodyID;
        public ulong GetUserData() => BodyUserData;
        public ObjectLayer GetObjectLayer() => ObjectLayer;
        public bool IsStatic() => (BodyFlags & StaticBody) != 0;
        public float GetVolume() => ShapeVolume;
        public ulong GetLeafShapeUserData() => LeafShapeUserData;
        public Shape GetLeafShape(out SubShapeID remainder)
        {
            remainder = LeafShapeRemainder;
            return new Shape(new NativeHandle<JPH_Shape>((JPH_Shape*)LeafShapePointer));
        }

        public static implicit operator Body(SimShapeFilterBodyData data) => data.GetBody();
        public static implicit operator Shape(SimShapeFilterBodyData data) => data.GetShape();
    }

    public interface IFastSimShapeFilterImplementation
    {
        bool ShouldCollide(ref SimShapeFilterBodyData body1, ref SimShapeFilterBodyData body2);
    }

    /// <summary>
    /// Interface that mus be implemented by sim shape filter implementations.
    /// </summary>
    public interface ISimShapeFilterImplementation
    {
        public bool ShouldCollide(Body body1, Shape shape1, SubShapeID subShapeID1, Body body2, Shape shape2, SubShapeID subShapeID2);
    }

    /// <summary>
    /// Class that wraps a native Jolt sim shape filter
    /// </summary>
    public partial struct SimShapeFilter
    {
        internal NativeHandle<JPH_SimShapeFilter> Handle;

        public static SimShapeFilter Create(ISimShapeFilterImplementation implementation)
        {
            return new SimShapeFilter { Handle = Bindings.JPH_SimShapeFilter_Create(implementation) };
        }

        public static SimShapeFilter CreateFast(IFastSimShapeFilterImplementation implementation)
        {
            return new SimShapeFilter { Handle = Bindings.JPH_SimShapeFilterFast_Create(implementation) };
        }

        public void SetBodyCallbackEnabled(BodyID bodyID, bool enabled)
        {
            Bindings.JPH_SimShapeFilterFast_SetBodyCallbackEnabled(Handle, bodyID, enabled);
        }

        public void Destroy()
        {
            Bindings.JPH_SimShapeFilter_Destroy(Handle);
        }
    }
}

