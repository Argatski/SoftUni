using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars.Repositories.Entities
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private List<IMilitaryUnit> _units;
        public UnitRepository()
        {
            this._units = new List<IMilitaryUnit>();
        }

        public IReadOnlyCollection<IMilitaryUnit> Models => this._units;

        public void AddItem(IMilitaryUnit model)
        {
            this._units.Add(model);
        }

        public IMilitaryUnit FindByName(string name)
        {
            return this._units.FirstOrDefault(n => n.GetType().Name == name);
        }

        //TODO .......
        public bool RemoveItem(string name)
        {
            return this._units.Remove(FindByName(name));
        }
    }
}
