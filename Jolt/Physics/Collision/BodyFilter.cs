using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;

namespace Jolt
{
    /// <summary>
    /// Filter defining bodies to ignore in a collision query.
    /// </summary>
    [BurstCompile]
    public unsafe struct BodyFilter : IDisposable
    {
        /// <summary>
        /// Enumerates the modes of filtering for <see cref="BodyFilter"/>.
        /// </summary>
        public enum FilterMode
        {
            IgnoreSelection,
            CollideWithSelection,
        }

        /// <summary>
        /// A handle to a native body filter.
        /// </summary>
        internal NativeHandle<JPH_BodyFilter> Handle;

        /// <summary>
        /// A pointer to a <see cref="BodyFilter"/> instance allocated on the unmanaged heap.
        /// This instance is safe to use in interoperation context as it is not managed.
        /// Every modifications affect this instance. 
        /// </summary>
        internal IntPtr UnmanagedPointer;

        /// <summary>
        /// The filtering mode.
        /// </summary>
        private FilterMode mode;
        /// <summary>
        /// The <see cref="BodyID"/> selection to either ignore or collide with depending on <see cref="mode"/>.
        /// </summary>
        private NativeHashSet<BodyID> bodyIDSelection;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool ShouldCollideSignature(void* context, BodyID bodyID);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool ShouldCollideLockedSignature(void* context, JPH_Body* body);

        private static readonly FunctionPointer<ShouldCollideSignature> shouldCollideFunctionPointer;
        private static readonly FunctionPointer<ShouldCollideLockedSignature> shouldCollideLockedFunctionPointer;

        private JPH_BodyFilter_Procs procs;

        static BodyFilter()
        {
            shouldCollideFunctionPointer = BurstCompiler.CompileFunctionPointer<ShouldCollideSignature>(ShouldCollide);
            shouldCollideLockedFunctionPointer = BurstCompiler.CompileFunctionPointer<ShouldCollideLockedSignature>(ShouldCollideLocked);
        }

        public BodyFilter(NativeList<BodyID> bodyIDs, FilterMode filterMode)
        {
            Handle = default;
            UnmanagedPointer = default;

            bodyIDSelection = new NativeHashSet<BodyID>(bodyIDs.Length, Allocator.Persistent);
            for (int i = 0; i < bodyIDs.Length; i++)
            {
                BodyID bodyID = bodyIDs[i];
                bodyIDSelection.Add(bodyID);
            }

            mode = filterMode;

            procs = default;
        }

        /// <summary>
        /// Initializes a new <see cref="BodyFilter"/> instance on the unmanaged heap.
        /// </summary>
        /// <param name="bodyIDs"></param>
        /// <param name="filterMode"></param>
        /// <returns></returns>
        public static BodyFilter Create(NativeList<BodyID> bodyIDs, FilterMode filterMode)
        {
            BodyFilter filter = new BodyFilter(bodyIDs, filterMode);
            filter.UnmanagedPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(BodyFilter)));
            Marshal.StructureToPtr(filter, filter.UnmanagedPointer, false);

            filter.procs = new JPH_BodyFilter_Procs
            {
                ShouldCollide = shouldCollideFunctionPointer.Value,
                ShouldCollideLocked = shouldCollideLockedFunctionPointer.Value,
            };

            var ptr = (BodyFilter*)filter.UnmanagedPointer.ToPointer();
            filter.Handle = Bindings.JPH_BodyFilter_Create(filter.procs, ptr);

            return filter;
        }

        /// <summary>
        /// <para>Static callback method fo Jolt physics engine to call.</para>
        /// Returns if the body identified by <paramref name="bodyID"/> should collide.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="bodyID"></param>
        /// <returns></returns>
        [BurstCompile]
        internal static bool ShouldCollide(void* context, BodyID bodyID)
        {
            var implPtr = (BodyFilter*)context;
            var impl = *implPtr;

            return impl.ShouldCollide(bodyID);
        }

        /// <summary>
        /// <para>Static callback method fo Jolt physics engine to call.</para>
        /// Returns if <paramref name="body"/> should collide.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [BurstCompile]
        internal static bool ShouldCollideLocked(void* context, JPH_Body* body)
        {
            var bodyHandle = new Body(new NativeHandle<JPH_Body>(body));

            bool result = true;

            var implPtr = (BodyFilter*)context;
            var impl = *implPtr;

            result = impl.ShouldCollideLocked(bodyHandle);

            bodyHandle.Handle.Dispose();

            return result;
        }

        /// <summary>
        /// Returns if the body identified by <paramref name="bodyID"/> should collide.
        /// </summary>
        /// <param name="bodyID"></param>
        /// <returns></returns>
        public bool ShouldCollide(BodyID bodyID)
        {
            if (mode == FilterMode.CollideWithSelection)
            {
                return bodyIDSelection.Contains(bodyID);
            }
            else
            {
                return !bodyIDSelection.Contains(bodyID);
            }
        }

        /// <summary>
        /// Returns if <paramref name="body"/> should collide.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public bool ShouldCollideLocked(Body body)
        {
            if (mode == FilterMode.CollideWithSelection)
            {
                return bodyIDSelection.Contains(body.GetID());
            }
            else
            {
                return !bodyIDSelection.Contains(body.GetID());
            }
        }

        /// <summary>
        /// Sets the <see cref="FilterMode"/> to <paramref name="filterMode"/>.
        /// </summary>
        /// <param name="filterMode"></param>
        public void SetFilterMode(FilterMode filterMode)
        {
            var ptr = UnmanagedPointer.ToPointer();

            if (ptr == null)
            {
                throw new Exception("Unvalid pointer.");
            }

            var unmanagedInstance = *(BodyFilter*)ptr;
            unmanagedInstance.mode = filterMode;
        }

        /// <summary>
        /// Adds a new <see cref="BodyID"/> to the ignored/collidable selection.
        /// </summary>
        /// <param name="bodyID"></param>
        public void AddBodyIDToSelection(BodyID bodyID)
        {
            var ptr = UnmanagedPointer.ToPointer();

            if (ptr == null)
            {
                throw new Exception("Unvalid pointer.");
            }

            var unmanagedInstance = *(BodyFilter*)ptr;
            unmanagedInstance.bodyIDSelection.Add(bodyID);
        }

        /// <summary>
        /// Tries to remove <paramref name="bodyID"/> from the ignored/collidable selection.
        /// </summary>
        /// <param name="bodyID"></param>
        public void RemoveBodyIDFromSelection(BodyID bodyID)
        {
            var ptr = UnmanagedPointer.ToPointer();

            if (ptr == null)
            {
                throw new Exception("Unvalid pointer.");
            }

            var unmanagedInstance = *(BodyFilter*)ptr;
            unmanagedInstance.bodyIDSelection.Remove(bodyID);
        }

        /// <summary>
        /// Clears the selection.
        /// </summary>
        public void ClearBodyIDSelection()
        {
            var ptr = UnmanagedPointer.ToPointer();

            if (ptr == null)
            {
                throw new Exception("Unvalid pointer.");
            }

            var unmanagedInstance = *(BodyFilter*)ptr;
            unmanagedInstance.bodyIDSelection.Clear();
        }

        public void Dispose()
        {
            Bindings.JPH_BodyFilter_Destroy(Handle);
            Marshal.FreeHGlobal(UnmanagedPointer);
        }
    }
}
