namespace Jolt
{
    public interface ICharacterContactListener
    {
        public void OnAdjustBodyVelocity();
        public bool OnCharacterBodyContactValidate();
        public void OnCharacterBodyContactAdded();
        public void OnCharacterBodyContactSolve();
    }
}