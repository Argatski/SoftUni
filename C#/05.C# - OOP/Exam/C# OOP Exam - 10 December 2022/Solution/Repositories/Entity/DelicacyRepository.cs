using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories.Entity
{
    public class DelicacyRepository : IRepository<IDelicacy>
    {
        private readonly List<IDelicacy> _delicacies;

        public DelicacyRepository()
        {
            this._delicacies = new List<IDelicacy>();
        }

        public IReadOnlyCollection<IDelicacy> Models => this._delicacies;

        public void AddModel(IDelicacy model)
        {
            this._delicacies.Add(model);
        }
    }
}
