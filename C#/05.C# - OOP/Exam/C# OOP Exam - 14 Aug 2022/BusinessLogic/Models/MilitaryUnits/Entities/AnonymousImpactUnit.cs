using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits.Entities
{
    public class AnonymousImpactUnit : MilitaryUnit
    {
        private const double costAnonymous = 30;
        public AnonymousImpactUnit() : base(costAnonymous)
        {
        }
    }
}
 