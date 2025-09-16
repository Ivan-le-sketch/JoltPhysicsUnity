using System;

namespace Jolt
{
    /// <summary>
    /// Filter defining bodies to ignore in a collision query.
    /// </summary>
    public unsafe struct IgnoreSingleBodyFilter : IDisposable
    {
        public BodyFilter Base;

        public IgnoreSingleBodyFilter(BodyID bodyID)
        {
            Base = new BodyFilter { Handle = Bindings.JPH_IgnoreSingleBodyFilter_Create(bodyID).Reinterpret<JPH_BodyFilter>() };
        }

        public void Dispose()
        {
            Base.Dispose();
        }
    }
}
