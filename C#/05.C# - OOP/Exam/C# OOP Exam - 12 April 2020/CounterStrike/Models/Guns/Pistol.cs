namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private const int strikeBullets = 1;
        public Pistol(string name, int bulletsCount)
            : base(name, bulletsCount)
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
                return 0;
            }
        }
    }
}
