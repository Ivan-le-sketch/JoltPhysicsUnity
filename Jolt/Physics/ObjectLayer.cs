using System;
using System.Runtime.InteropServices;

namespace Jolt
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ObjectLayer : IEquatable<ObjectLayer>
    {
        // A distinct type wrapper around ushort (or optionally uint, but unsupported). See https://github.com/jrouwe/JoltPhysics/blob/master/Jolt/Physics/Collision/ObjectLayer.h

        /// <summary>
        /// Number of bits in an object layer.
        /// </summary>
        public const uint ObjectLayerBits = 32;

        /// <summary>
        /// The invalid ObjectLayer (~0), all bits set.
        /// </summary>
        public static readonly ObjectLayer Invalid = new ObjectLayer(unchecked((uint)~0));

        /// <summary>
        /// The layer value.
        /// </summary>
        public readonly uint Value;

        public ObjectLayer(uint value)
        {
            Value = value;
        }

        /// <summary>
        /// Implicit cast from ushort. The inverse is not available to avoid confusion.
        /// </summary>
        public static implicit operator ObjectLayer(uint layer)
        {
            return new ObjectLayer(layer);
        }

        #region IEquatable

        public bool Equals(ObjectLayer other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is ObjectLayer other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(ObjectLayer lhs, ObjectLayer rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ObjectLayer lhs, ObjectLayer rhs)
        {
            return !lhs.Equals(rhs);
        }

        #endregion
    }
}
