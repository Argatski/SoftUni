using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories.Entity
{
    public class BoothRepository : IRepository<IBooth>
    {
        private readonly List<IBooth> _booths;

        public BoothRepository()
        {
            this._booths = new List<IBooth>();
        }

        public IReadOnlyCollection<IBooth> Models => this._booths;

        public void AddModel(IBooth model)
        {
            this._booths.Add(model);
        }
    }
}
