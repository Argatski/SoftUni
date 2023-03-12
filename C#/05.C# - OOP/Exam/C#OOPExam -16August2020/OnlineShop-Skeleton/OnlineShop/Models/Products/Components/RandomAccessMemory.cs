using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public class RandomAccessMemory : Component
    {
        private const double RandomAccessMemoryMultiplier = 1.20;
        public RandomAccessMemory(int id, string manufacturer, string model, decimal price, double overallPerformence, int generation) : base(id, manufacturer, model, price, overallPerformence, generation)
        {
        }
        public override double OverallPerformance => base.OverallPerformance*RandomAccessMemoryMultiplier;
    }
}
