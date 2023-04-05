namespace PlanetWars.Models.Weapons.Entities
{
    public class BioChemicalWeapon : Weapon
    {
        private const double bioChemicalWeaponPrice = 3.2;

        public BioChemicalWeapon(int destructionLevel) : base(destructionLevel, bioChemicalWeaponPrice)
        {
        }
    }
}

