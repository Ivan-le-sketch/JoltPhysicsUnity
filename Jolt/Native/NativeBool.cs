namespace Jolt
{
    /// <summary>
    /// A uint with implicit bool casting, providing consistent interop with native "bool" uints.
    /// </summary>
    internal struct NativeBool
    {
        public byte Value;

        public static implicit operator bool(NativeBool value)
        {
            return value.Value != 0;
        }

        public static implicit operator NativeBool(bool value)
        {
            return new NativeBool { Value = value ? (byte)1 : (byte)0 };
        }
    }
}
