﻿using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        protected Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformence, string connectionType) : base(id, manufacturer, model, price, overallPerformence)
        {
            this.ConnectionType = connectionType;
        }

        public string ConnectionType { get; }

        public override string ToString()
        {
            return base.ToString() + "" +string.Format(SuccessMessages.PeripheralToString,this.ConnectionType);
        }

    }
}
