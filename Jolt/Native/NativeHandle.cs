using System;
using System.Runtime.CompilerServices;

namespace Jolt
{
    internal unsafe struct NativeHandle<T> : IDisposable, IEquatable<NativeHandle<T>> where T : unmanaged
    {
        #if !JOLT_DISABLE_SAFETY_CHECkS
        private NativeSafetyHandle safety;
        #endif

        private T* ptr;

        public nint RawValue => (nint)ptr;

        public NativeHandle(T* ptr)
        {
            #if !JOLT_DISABLE_SAFETY_CHECkS
            safety = NativeSafetyHandle.Create((IntPtr)ptr);
            #endif

            this.ptr = ptr;
        }

        /// <summary>
        /// Create a NativeHandle to a new pointer with the same safety handle as this handle. If this handle is disposed of, the owned handle will throw if it is dereferenced.
        /// </summary>
        public NativeHandle<U> CreateOwnedHandle<U>(U* ptr) where U : unmanaged
        {
            #if !JOLT_DISABLE_SAFETY_CHECkS
            return new NativeHandle<U> { ptr = ptr, safety = safety };
            #else
            return new NativeHandle<U> { ptr = ptr };
            #endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeHandle<U> Reinterpret<U>() where U : unmanaged
        {
            #if !JOLT_DISABLE_SAFETY_CHECkS
            return new NativeHandle<U> { ptr = (U*) ptr, safety = safety };
            #else
            return new NativeHandle<U> { ptr = (U*) ptr };
            #endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T* IntoPointer()
        {
            #if !JOLT_DISABLE_SAFETY_CHECkS
            AssertExists();
            safety.AssertExists();
            #endif

            return ptr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T* (NativeHandle<T> handle)
        {
            return handle.IntoPointer();
        }

        public void AddUser()
        {
#if !JOLT_DISABLE_SAFETY_CHECkS
            safety.AddUser();
#endif
        }

        public void RemoveUser()
        {
#if !JOLT_DISABLE_SAFETY_CHECkS
            safety.RemoveUser();
#endif
        }

        public bool HasUser()
        {
#if !JOLT_DISABLE_SAFETY_CHECkS
            return safety.HasUser();
#else
            return false;
#endif
        }

        private readonly void AssertExists()
        {
            if (ptr == null)
            {
                throw new Exception("Handle pointer is null.");
            }
        }

        #region IDisposable

        public void Dispose()
        {
#if !JOLT_DISABLE_SAFETY_CHECkS
            safety.Release();
#endif

            ptr = null;
        }

        #endregion

        #region IEquatable

        public bool Equals(NativeHandle<T> other)
        {
            return ptr == other.ptr;
        }

        public override bool Equals(object obj)
        {
            return obj is NativeHandle<T> other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine((nint) ptr);
        }

        public static bool operator ==(NativeHandle<T> lhs, NativeHandle<T> rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(NativeHandle<T> lhs, NativeHandle<T> rhs)
        {
            return !lhs.Equals(rhs);
        }

        #endregion
    }
}
