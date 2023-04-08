using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.MilitaryUnits.Entities;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Planets.Entities;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Models.Weapons.Entities;
using PlanetWars.Repositories.Entities;
using PlanetWars.Utilities.Messages;
using System;
using System.Linq;
using System.Text;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private IPlanet planet;

        private PlanetRepository planets;

        public Controller()
        {

            this.planets = new PlanetRepository();
        }


        public string AddUnit(string unitTypeName, string planetName)
        {
            planet = planets.FindByName(planetName);

            if (planet == default)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            bool isAvaible = unitTypeName != nameof(AnonymousImpactUnit) && unitTypeName != nameof(SpaceForces) && unitTypeName != nameof(StormTroopers);

            if (isAvaible)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.ItemNotAvailable, unitTypeName));
            }
            if (planet.Army.Any(u => u.GetType().Name == unitTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnitAlreadyAdded, unitTypeName, planetName));
            }

            IMilitaryUnit unit;

            if (unitTypeName == "AnonymousImpactUnit")
            {
                unit = new AnonymousImpactUnit();
            }
            else if (unitTypeName == "SpaceForces")
            {
                unit = new SpaceForces();
            }
            else
            {
                unit = new StormTroopers();
            }

            planet.Spend(unit.Cost);
            planet.AddUnit(unit);

            return string.Format(OutputMessages.UnitAdded, unitTypeName, planetName);
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            planet = planets.FindByName(planetName);

            if (planet == default)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            bool isAlreadyAdded = weaponTypeName != nameof(BioChemicalWeapon) && weaponTypeName != nameof(NuclearWeapon) && weaponTypeName != nameof(SpaceMissiles);

            if (isAlreadyAdded)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.WeaponAlreadyAdded, weaponTypeName, planetName));
            }

            if (planet.Weapons.Any(w => w.GetType().Name == weaponTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.ItemNotAvailable, weaponTypeName));
            }

            IWeapon weapon;
            if (weaponTypeName == "BioChemicalWeapon")
            {
                weapon = new BioChemicalWeapon(destructionLevel);
            }
            else if (weaponTypeName == "NuclearWeapon")
            {
                weapon = new NuclearWeapon(destructionLevel);
            }
            else
            {
                weapon = new SpaceMissiles(destructionLevel);
            }

            planet.Spend(weapon.Price);
            planet.AddWeapon(weapon);

            return string.Format(OutputMessages.WeaponAdded, planetName, weaponTypeName);
        }

        public string CreatePlanet(string name, double budget)
        {

            if (this.planets.FindByName(name) != default)
            {
                return string.Format(OutputMessages.ExistingPlanet, name);
            }
            else
            {

                IPlanet planet = new Planet(name, budget);

                this.planets.AddItem(planet);

                return string.Format(OutputMessages.NewPlanet, name);
            }
        }

        public string ForcesReport()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine("***UNIVERSE PLANET MILITARY REPORT***");

            foreach (var item in planets.Models.OrderByDescending(x => x.MilitaryPower).ThenBy(x => x.Name))
            {
                stb.Append(item.PlanetInfo());
            }

            return stb.ToString().TrimEnd();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            IPlanet firstPlanet = this.planets.FindByName(planetOne);
            IPlanet secondPlanet = this.planets.FindByName(planetTwo);

            double firstPlanetHalfBudget = firstPlanet.Budget / 2;
            double secondPlanetHalfBudget = secondPlanet.Budget / 2;

            double firstCalculatedValue = firstPlanet.Army.Sum(x => x.Cost) + firstPlanet.Weapons.Sum(w => w.Price);
            double secondCalculatedValue = secondPlanet.Army.Sum(x => x.Cost) + secondPlanet.Weapons.Sum(w => w.Price);

            double firstPowerRatio = firstPlanet.MilitaryPower;
            double secondPowerRatio = secondPlanet.MilitaryPower;

            var firstHasNuclear = firstPlanet.Weapons.Any(n => n.GetType().Name == nameof(NuclearWeapon));
            var secondHasNuclear = secondPlanet.Weapons.Any(n => n.GetType().Name == nameof(NuclearWeapon));

            var firstNuclear = firstPlanet.Weapons.FirstOrDefault(x => x.GetType().Name == nameof(NuclearWeapon));
            var secondNuclear = secondPlanet.Weapons.FirstOrDefault(x => x.GetType().Name == nameof(NuclearWeapon));


            if (firstPowerRatio > secondPowerRatio)
            {
                firstPlanet.Spend(firstPlanetHalfBudget);
                firstPlanet.Profit(secondPlanetHalfBudget);
                firstPlanet.Profit(secondCalculatedValue);

                this.planets.RemoveItem(secondPlanet.Name);
                return string.Format(OutputMessages.WinnigTheWar, planetOne, planetTwo);
            }
            else if (firstPowerRatio < secondPowerRatio)
            {
                secondPlanet.Spend(secondPlanetHalfBudget);
                secondPlanet.Profit(firstPlanetHalfBudget);
                secondPlanet.Profit(firstCalculatedValue);

                this.planets.RemoveItem(firstPlanet.Name);

                return string.Format(OutputMessages.WinnigTheWar, planetTwo, planetOne);
            }
            else
            {
                if (firstNuclear != null && secondNuclear != null)
                {
                    if (firstNuclear.DestructionLevel > secondNuclear.DestructionLevel)
                    {
                        firstPlanet.Spend(firstPlanetHalfBudget);
                        firstPlanet.Profit(secondPlanetHalfBudget);
                        firstPlanet.Profit(secondCalculatedValue);

                        planets.RemoveItem(secondPlanet.Name);
                        return string.Format(OutputMessages.WinnigTheWar, planetOne, planetTwo);
                    }
                    else if (firstNuclear.DestructionLevel < secondNuclear.DestructionLevel)
                    {
                        secondPlanet.Spend(secondPlanetHalfBudget);
                        secondPlanet.Profit(firstPlanetHalfBudget);
                        secondPlanet.Profit(firstCalculatedValue);

                        planets.RemoveItem(firstPlanet.Name);
                        return string.Format(OutputMessages.WinnigTheWar, planetTwo, planetOne);
                    }
                    else
                    {
                        firstPlanet.Spend(firstPlanetHalfBudget);
                        secondPlanet.Spend(secondPlanetHalfBudget);
                    }
                    return string.Format(OutputMessages.NoWinner);
                }
                else if (firstNuclear != null)
                {
                    firstPlanet.Spend(firstPlanetHalfBudget);
                    firstPlanet.Profit(secondPlanetHalfBudget);
                    firstPlanet.Profit(secondCalculatedValue);

                    planets.RemoveItem(secondPlanet.Name);
                    return string.Format(OutputMessages.WinnigTheWar, planetOne, planetTwo);
                }
                else if (secondNuclear != null)
                {

                    secondPlanet.Spend(secondPlanetHalfBudget);
                    secondPlanet.Profit(firstPlanetHalfBudget);
                    secondPlanet.Profit(firstCalculatedValue);

                    planets.RemoveItem(firstPlanet.Name);
                    return string.Format(OutputMessages.WinnigTheWar, planetTwo, planetOne);
                }
                else
                {
                    firstPlanet.Spend(firstPlanetHalfBudget);
                    secondPlanet.Spend(secondPlanetHalfBudget);

                    return string.Format(OutputMessages.NoWinner);
                }

            }
        }

        public string SpecializeForces(string planetName)
        {
            planet = this.planets.FindByName(planetName);
            //TODO ...
            if (planet == default)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }
            if (this.planet.Army.Count == 0)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NoUnitsFound));
            }
            else
            {
                double specCost = 1.25;
                planet.TrainArmy();
                planet.Spend(specCost);

                return string.Format(OutputMessages.ForcesUpgraded, planetName);
            }

        }


        public void IsPlanetExist(string planetName)
        {
            planet = planets.FindByName(planetName);

            if (planet != default)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

        }
    }
}
