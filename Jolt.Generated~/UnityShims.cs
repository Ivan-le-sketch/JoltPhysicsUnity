// Shims for a handful of Unity types that are needed to generate the Jolt wrappers without errors. The implementation
// is irrelevant, we just need the types to be present so that the project can compile.

namespace Unity.Mathematics
{
    public struct double3 { }

    public struct float2
    {
        public float2(float x, float y) { } // used by Bindings_JPH_HingeConstraint
    }

    public struct float3
    {
        public static float3 zero { get; } // used by ExtendedUpdateSettings

        public float3(float x, float y, float z) { } // used by ExtendedUpdateSettings
    }

    public struct float4 { }

    public struct float4x4 { }

    public struct quaternion { }

    public static class math
    {
        public static float radians(float angle) => angle; // used by ExtendedUpdateSettings
        public static float cos(float value) => value; // used by ExtendedUpdateSettings
    }
}

namespace UnityEngine
{
    public static class Debug
    {
        public static void LogWarning(string _) { }

        public static void LogException(System.Exception _) { }
    }

    public class RuntimeInitializeOnLoadMethodAttribute : System.Attribute { }
}

namespace Unity.Collections
{
    public struct NativeList<T> : System.IDisposable
    {
        public NativeList(int _, Allocator __) { }

        public bool IsCreated => true;

        public void Add(T _) { }

        public bool Contains(T _) => true;

        public void Dispose() { }
    }

    public unsafe struct NativeArray<T> : System.IDisposable
    {
        public NativeArray(int _, Allocator __) { }

        public bool IsCreated => true;

        public int Length => 0;

        public void Dispose() { }

        public void* GetUnsafePtr() => null;
    }

    public struct NativeHashSet<T> : System.IDisposable
    {
        public NativeHashSet(int _, Allocator __) { }

        public bool IsCreated => true;

        public void Add(T _) { }

        public bool Contains(T _) => true;

        public void Dispose() { }
    }

    public enum Allocator
    {
        Temp, Persistent,
    }
}

namespace Unity.Collections.LowLevel
{

}

namespace Unity.Collections.LowLevel.Unsafe
{

}
