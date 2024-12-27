namespace Jolt
{
    /// <summary>
    /// A widened Shape instance handle.
    /// </summary>
    [GenerateHandle("JPH_Shape"), GenerateBindings("JPH_Shape")]
    public readonly partial struct Shape
    {
        public void AddUser()
        {
            var userCount = GetUserData();
            userCount++;
            SetUserData(userCount);
        }

        public void RemoveUser()
        {
            var userCount = GetUserData();
            if (userCount > 0) userCount--;
            if (userCount == 0)
            {
                Destroy();
            }
            else
            {
                SetUserData(userCount);
            }
        }

        [OverrideBinding("JPH_Shape_Destroy")]
        public void Destroy()
        {
            Bindings.JPH_Shape_Destroy(Handle);
        }

        public static implicit operator Shape(BoxShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(CapsuleShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(ConvexShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(ConvexHullShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(CylinderShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(EmptyShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(MeshShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(MutableCompoundShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(SphereShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }

        public static implicit operator Shape(TaperedCapsuleShape shape)
        {
            return new Shape(shape.Handle.Reinterpret<JPH_Shape>());
        }
    }
}
