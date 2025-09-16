using System;

namespace Jolt
{
    /// <summary>
    /// Filter defining bodies to ignore in a collision query.
    /// </summary>
    public unsafe struct BodyFilter : IDisposable
    {
        /// <summary>
        /// A handle to a native body filter.
        /// </summary>
        internal NativeHandle<JPH_BodyFilter> Handle;

        public void Dispose()
        {
            Bindings.JPH_BodyFilter_Destroy(Handle.Reinterpret<JPH_BodyFilter>());
        }
    }
}
