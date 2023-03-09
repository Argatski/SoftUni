using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    internal class Keyboard : Peripheral
    {
        public Keyboard(int id, string manufacturer, string model, decimal price, double overallPerformence, string connectionType) : base(id, manufacturer, model, price, overallPerformence, connectionType)
        {
        }
    }
}
