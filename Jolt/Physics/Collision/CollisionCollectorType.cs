namespace Jolt
{
    public enum CollisionCollectorType
    {
        AllHit = 0,
        AllHitSorted = 1,
        ClosestHit = 2,
        ClosestHitPerBody = 3,
        ClosestHitPerBodySorted = 4,
        AnyHit = 5,
        Count,
        Force32 = 0x7FFFFFFF,
    }
}
