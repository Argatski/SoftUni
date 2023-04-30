using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EDriveRent.Repositories.Entities
{
    public class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> routes;
        public RouteRepository()
        {
            routes = new List<IRoute>();
        }

        public void AddModel(IRoute model)
        {
            routes.Add(model);
        }

        public IRoute FindById(string identifier) => routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));


        public IReadOnlyCollection<IRoute> GetAll() => routes;


        public bool RemoveById(string identifier) => routes.Remove(FindById(identifier));

    }
}
