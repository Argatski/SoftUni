using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    internal class Motherboard : Component
    {
        private const double MotherBoardMultiplier = 1.25;
        public Motherboard(int id, string manufacturer, string model, decimal price, double overallPerformence, int generation) : base(id, manufacturer, model, price, overallPerformence, generation)
        {
        }
        public override double OverallPerformance => base.OverallPerformance*MotherBoardMultiplier;
    }
}
