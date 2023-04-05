using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons.Entities
{
    public class SpaceMissiles : Weapon
    {
        private const double spacePrice = 8.75;
        public SpaceMissiles(int destructionLevel) : base(destructionLevel, spacePrice)
        {
        }
    }
}
