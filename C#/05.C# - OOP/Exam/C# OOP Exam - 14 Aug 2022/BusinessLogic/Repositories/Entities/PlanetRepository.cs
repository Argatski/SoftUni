using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories.Entities
{
    internal class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> _planets;

        public PlanetRepository()
        {
            this._planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this._planets;

        public void AddItem(IPlanet model)
        {
            this._planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            return this._planets.FirstOrDefault(p => p.Name == name);
        }

        public bool RemoveItem(string name)
        {
            return this._planets.Remove(FindByName(name));
        }
    }
}
