using System;
using Unity.Collections;

namespace Jolt
{
    /// <summary>
    /// Filter defining bodies to ignore in a collision query.
    /// </summary>
    public unsafe struct IgnoreMultipleBodiesFilter : IDisposable
    {
        public BodyFilter Base;

        /// <summary>
        /// The <see cref="BodyID"/> selection to either ignore or collide with depending on <see cref="mode"/>.
        /// </summary>
        private NativeHashSet<BodyID> ignored;

        public IgnoreMultipleBodiesFilter(NativeList<BodyID> bodyIDs)
        {
            Base = new BodyFilter();

            var handle = Bindings.JPH_IgnoreMultipleBodiesFilter_Create();
            Base.Handle = handle.Reinterpret<JPH_BodyFilter>();

            ignored = new NativeHashSet<BodyID>(bodyIDs.Length, Allocator.Persistent);
            for (int i = 0; i < bodyIDs.Length; i++)
            {
                BodyID bodyID = bodyIDs[i];
                ignored.Add(bodyID);
            }

            Bindings.JPH_IgnoreMultipleBodiesFilter_Reserve(handle, ignored.Count);
            foreach (BodyID bodyID in ignored)
            {
                Bindings.JPH_IgnoreMultipleBodiesFilter_IgnoreBody(handle, bodyID);
            }
        }

        public void Clear()
        {
            ignored.Clear();
            Bindings.JPH_IgnoreMultipleBodiesFilter_Clear(Base.Handle.Reinterpret<JPH_IgnoreMultipleBodiesFilter>());
        }

        public void Add(BodyID bodyID)
        {
            if (ignored.Add(bodyID))
            {
                Bindings.JPH_IgnoreMultipleBodiesFilter_IgnoreBody(Base.Handle.Reinterpret<JPH_IgnoreMultipleBodiesFilter>(), bodyID);
            }      
        }

        public void Dispose()
        {
            Base.Dispose();
            ignored.Dispose();
        }
    }
}
