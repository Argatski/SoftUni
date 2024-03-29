﻿using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Cocktails.Entity;
using ChristmasPastryShop.Repositories.Contracts;
using System.Collections.Generic;

namespace ChristmasPastryShop.Repositories.Entity
{
    public class CocktailRepository : IRepository<ICocktail>
    {
        private readonly List<ICocktail> _cocktails;

        public CocktailRepository()
        {
            this._cocktails= new List<ICocktail>();
        }

        public IReadOnlyCollection<ICocktail> Models => this._cocktails;

        public void AddModel(ICocktail model)
        {
            this._cocktails.Add(model);
        }
    }
}
