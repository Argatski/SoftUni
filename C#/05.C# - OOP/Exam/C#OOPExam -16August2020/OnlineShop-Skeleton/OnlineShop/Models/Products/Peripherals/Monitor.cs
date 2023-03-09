using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public class Monitor : Peripheral
    {
        public Monitor(int id, string manufacturer, string model, decimal price, double overallPerformence, string connectionType) : base(id, manufacturer, model, price, overallPerformence, connectionType)
        {
        }
    }
}
