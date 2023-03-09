using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public class CentralProcessingUnit : Component
    {
        private const double CentralProcessingMultiplier = 1.25;
        public CentralProcessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformence, int generation) : base(id, manufacturer, model, price, overallPerformence, generation)
        {
            this.OverallPerformance *= CentralProcessingMultiplier;
        }
    }
}
