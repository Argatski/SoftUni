namespace PlanetWars.Models.Weapons.Entities
{
    public class NuclearWeapon : Weapon
    {
        private const double nuclearPrice = 15.0;

        public NuclearWeapon(int destructionLevel) : base(destructionLevel, nuclearPrice)
        {
        }
    }
}
