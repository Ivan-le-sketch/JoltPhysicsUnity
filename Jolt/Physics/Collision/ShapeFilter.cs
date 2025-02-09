using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;

namespace Jolt
{
    /// <summary>
    /// Filter defining shapes to ignore in a collision query.
    /// </summary>
    [BurstCompile]
    public unsafe struct ShapeFilter : IDisposable
    {
        /// <summary>
        /// Enumerates the modes of filtering for <see cref="ShapeFilter"/>.
        /// </summary>
        public enum FilterMode
        {
            CollideWithSelection,
            IgnoreSelection,
        }

        /// <summary>
        /// A handle to a native shape filter.
        /// </summary>
        internal NativeHandle<JPH_ShapeFilter> Handle;

        /// <summary>
        /// A pointer to a <see cref="ShapeFilter"/> instance allocated on the unmanaged heap.
        /// This instance is safe to use in interoperation context as it is not managed.
        /// Every modifications affect this instance. 
        /// </summary>
        internal IntPtr UnmanagedPointer;

        /// <summary>
        /// The filtering mode.
        /// </summary>
        private FilterMode mode;
        /// <summary>
        /// A selection of <see cref="SubShapeID"/> to either ignore or collide with depending on <see cref="mode"/>.
        /// </summary>
        private NativeHashSet<SubShapeID> subShapeIDSelection;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool ShouldCollideSignature(void* context, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool ShouldCollide2Signature(void* context, JPH_Shape* shape1, SubShapeID* subShapeIDOfShape1, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2);

        private static FunctionPointer<ShouldCollideSignature> shouldCollideFunctionPointer;
        private static FunctionPointer<ShouldCollide2Signature> shouldCollide2FunctionPointer;

        private JPH_ShapeFilter_Procs procs;

        static ShapeFilter()
        {
            shouldCollideFunctionPointer = BurstCompiler.CompileFunctionPointer<ShouldCollideSignature>(ShouldCollide);
            shouldCollide2FunctionPointer = BurstCompiler.CompileFunctionPointer<ShouldCollide2Signature>(ShouldCollide2);
        }

        public ShapeFilter(IEnumerable<SubShapeID> subShapes, FilterMode filterMode)
        {
            Handle = default;
            UnmanagedPointer = default;
            procs = default;

            subShapeIDSelection = new NativeHashSet<SubShapeID>(8, Allocator.Persistent);

            foreach (SubShapeID subShape in subShapes)
            {
                subShapeIDSelection.Add(subShape);
            }

            mode = filterMode;
        }

        /// <summary>
        /// Initializes a new <see cref="ShapeFilter"/> instance on the unmanaged heap.
        /// </summary>
        /// <param name="subShapes"></param>
        /// <param name="filterMode"></param>
        /// <returns></returns>
        public static ShapeFilter Create(IEnumerable<SubShapeID> subShapes, FilterMode filterMode)
        {
            ShapeFilter filter = new ShapeFilter(subShapes, filterMode);
            filter.UnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ShapeFilter)));
            Marshal.StructureToPtr(filter, filter.UnmanagedPointer, false);

            filter.procs = new JPH_ShapeFilter_Procs
            {
                ShouldCollide = shouldCollideFunctionPointer.Value,
                ShouldCollide2 = shouldCollide2FunctionPointer.Value,
            };

            var ptr = (ShapeFilter*)filter.UnmanagedPointer.ToPointer();
            filter.Handle = Bindings.JPH_ShapeFilter_Create(filter.procs, ptr);

            return filter;
        }

        [BurstCompile]
        internal static bool ShouldCollide(void* context, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2)
        {
            var id = *subShapeIDOfShape2;

            var implPtr = (ShapeFilter*)context;
            var impl = *implPtr;

            return impl.ShouldCollide(id);
        }

        [BurstCompile]
        internal static bool ShouldCollide2(void* context, JPH_Shape* shape1, SubShapeID* subShapeIDOfShape1, JPH_Shape* shape2, SubShapeID* subShapeIDOfShape2)
        {
            var id = *subShapeIDOfShape2;

            var implPtr = (ShapeFilter*)context;
            var impl = *implPtr;

            return impl.ShouldCollide(id);
        }

        public bool ShouldCollide(SubShapeID id)
        {
            if (mode == FilterMode.CollideWithSelection)
            {
                return subShapeIDSelection.Contains(id);
            }
            else
            {
                return !subShapeIDSelection.Contains(id);
            }
        }

        public void Dispose()
        {
            Bindings.JPH_ShapeFilter_Destroy(Handle);
            Marshal.FreeHGlobal(UnmanagedPointer);
        }
    }
}
