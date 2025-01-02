namespace Jolt
{
    [GenerateHandle("JPH_BodyLockInterface"), GenerateBindings("JPH_BodyLockInterface")]
    public partial struct BodyLockInterface
    {
        [OverrideBinding("JPH_BodyLockInterface_TryGetBody")]
        public bool TryGetBody(BodyID bodyID, out Body body)
        {
            var result = Bindings.JPH_BodyLockInterface_TryGetBody(Handle, bodyID, out var bodyHandle);

            body = new Body(bodyHandle);

            return result;
        }
    }
}