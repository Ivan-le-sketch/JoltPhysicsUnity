using System;

namespace Jolt
{
    public struct BodyID : IEquatable<BodyID>, IComparable<BodyID>
    {
        public uint Value;

        #region IEquatable

        public bool Equals(BodyID other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is BodyID other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (int) Value;
        }

        public static bool operator ==(BodyID lhs, BodyID rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(BodyID lhs, BodyID rhs)
        {
            return !lhs.Equals(rhs);
        }

        #endregion

        #region IComparable

        public int CompareTo(BodyID other)
        {
            if (Value < other.Value) return -1;
            if (Value > other.Value) return 1;
            return 0;
        }

        #endregion
    }
}
