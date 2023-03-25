namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private const int strikeBullets = 10;
        public Rifle(string name, int bulletsCount) : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount - strikeBullets >= 0)
            {
                BulletsCount -= strikeBullets;
                return strikeBullets;
            }
            else
            {
                int resultingBullets = BulletsCount;
                BulletsCount = 0;
                return BulletsCount;
            }
        }
    }
}
