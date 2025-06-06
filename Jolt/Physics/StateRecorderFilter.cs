using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    public interface IStateRecorderFilter
    {
        public bool ShouldSaveBody(Body body);
        public bool ShouldSaveConstraint(Constraint constraint);
        public bool ShouldSaveContact(BodyID bodyID1, BodyID bodyID2);
        public bool ShouldRestoreContact(BodyID bodyID1, BodyID bodyID2);
    }

    public partial struct StateRecorderFilter
    {
        internal NativeHandle<JPH_StateRecorderFilter> Handle;

        public static StateRecorderFilter Create(IStateRecorderFilter implementation)
        {
            return new StateRecorderFilter { Handle = Bindings.JPH_StateRecorderFilter_Create(implementation) };
        }

        public void Destroy()
        {
            Bindings.JPH_StateRecorderFilter_Destroy(Handle);
        }
    }
}
