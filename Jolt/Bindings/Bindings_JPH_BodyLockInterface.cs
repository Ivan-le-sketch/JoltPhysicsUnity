namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        /*public static JPH_BodyLockRead* JPH_BodyLockInterface_LockRead(NativeHandle<JPH_BodyLockInterface> lockInterface, BodyID bodyID)
        {
            JPH_BodyLockRead ioLock = new JPH_BodyLockRead();

            UnsafeBindings.JPH_BodyLockInterface_LockRead(lockInterface, bodyID, &ioLock);

            return &ioLock;
        }

        public static void JPH_BodyLockInterface_UnlockRead(NativeHandle<JPH_BodyLockInterface> lockInterface, NativeHandle<JPH_BodyLockRead> ioLock)
        {
            UnsafeBindings.JPH_BodyLockInterface_UnlockRead(lockInterface, ioLock);
        }

        public static JPH_BodyLockWrite* JPH_BodyLockInterface_LockWrite(NativeHandle<JPH_BodyLockInterface> lockInterface, BodyID bodyID)
        {
            JPH_BodyLockWrite ioLock = new JPH_BodyLockWrite();

            UnsafeBindings.JPH_BodyLockInterface_LockWrite(lockInterface, bodyID, &ioLock);

            return &ioLock;
        }

        public static void JPH_BodyLockInterface_UnlockWrite(NativeHandle<JPH_BodyLockInterface> lockInterface, NativeHandle<JPH_BodyLockWrite> ioLock)
        {
            UnsafeBindings.JPH_BodyLockInterface_UnlockWrite(lockInterface, ioLock);
        }*/

        public static bool JPH_BodyLockInterface_TryGetBody(NativeHandle<JPH_BodyLockInterface> lockInterface, BodyID bodyID, out NativeHandle<JPH_Body> body)
        {
            var bodyPtr = UnsafeBindings.JPH_BodyLockInterface_TryGetBody(lockInterface, bodyID);

            body = CreateHandle(bodyPtr);

            return bodyPtr != null;
        }
    }
}