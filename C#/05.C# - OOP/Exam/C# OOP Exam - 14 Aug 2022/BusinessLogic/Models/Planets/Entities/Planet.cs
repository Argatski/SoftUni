using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.MilitaryUnits.Entities;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Entities;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets.Entities
{
    public class Planet : IPlanet
    {
        private string _name;
        private double _budget;
        private UnitRepository units;
        private WeaponRepository wepons;

        public Planet(string name, double budget)
        {
            Name = name;
            Budget = budget;
            this.units = new UnitRepository();
            this.wepons = new WeaponRepository();

        }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }
                _name = value;
            }
        }

        public double Budget
        {
            get { return _budget; }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);

                }
                _budget = value;
            }
        }

        public double MilitaryPower => Math.Round(CalculateMilitaryPower(), 3);



        public IReadOnlyCollection<IMilitaryUnit> Army => this.units.Models;

        public IReadOnlyCollection<IWeapon> Weapons => this.wepons.Models;

        public void AddUnit(IMilitaryUnit unit)
        {
            this.units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.wepons.AddItem(weapon);
        }

        public string PlanetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Planet: {this.Name}");

            stringBuilder.AppendLine($"--Budget: {this.Budget} billion QUID");

            stringBuilder.Append($"--Forces: ");

            if (this.Army.Count == 0)
            {
                stringBuilder.AppendLine("No units");
            }
            else
            {
                Queue<IMilitaryUnit> militaryUnits = new Queue<IMilitaryUnit>();

                foreach (var force in Army)
                {
                    stringBuilder.Append(force.GetType().Name);
                }
            }

            stringBuilder.Append("--Combat equipment: ");

            if (this.Weapons.Count == 0)
            {
                stringBuilder.AppendLine("No weapons");
            }
            else
            {
                foreach (var weapon in Weapons)
                {
                    stringBuilder.AppendLine(weapon.GetType().Name);
                }
            }

            stringBuilder.AppendLine($"--Military Power: {this.MilitaryPower}");

            return stringBuilder.ToString();
        }

        public void Profit(double amount)
        {
            this.Budget += amount;
        }

        public void Spend(double amount)
        {

            if (this.Budget < amount)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }
            this.Budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (var force in Army)
            {
                force.IncreaseEndurance();
            }
        }

        //TODO....
        private double CalculateMilitaryPower()
        {
            throw new NotImplementedException();
        }
    }
}
