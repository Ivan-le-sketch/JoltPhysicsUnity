using System;
using System.Runtime.InteropServices;

namespace Jolt
{
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

        public void Destroy()
        {
            Bindings.JPH_SimShapeFilter_Destroy(Handle);
        }
    }
}

