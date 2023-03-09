using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public abstract class Component : Product, IComponent
    {
        protected Component(int id, string manufacturer, string model, decimal price, double overallPerformence, int generation) : base(id, manufacturer, model, price, overallPerformence)
        {
            this.Generation = generation;
        }

        public int Generation { get; }

        public override string ToString()
        {
            return base.ToString() + " " +string.Format(SuccessMessages.ComponentToString, this.Generation);
        }
    }
}
