using FakeAxeAndDummy.Contracts;


namespace FakeAxeAndDummy.Tests.FakeTesters
{
    public class FakeTarget : ITarget
    {
        public int Health => 0;

        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
        }
    }
}
