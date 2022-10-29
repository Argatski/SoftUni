using Raiding.Exceptions;
using Raiding.Models;
using System;

namespace Raiding.Factories
{
    public class FactoriesHeroes
    {
        public static BaseHero CeateHero(string type, string name)
        {
            BaseHero baseHero;
            switch (type)
            {
                case "Druid":
                    baseHero = new Druid(name);
                    break;
                case "Paladin":
                    baseHero = new Paladin(name);
                    break;
                case "Rogue":
                    baseHero = new Rogue(name);
                    break;
                case "Warrior":
                    baseHero = new Warrior(name);
                    break;
                default:
                    throw new ArgumentException(InvalidInput.InvalidHero);
            }
            return baseHero;
        }
    }

}
