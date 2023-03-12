using OnlineShop.Common.Constants;
using OnlineShop.Common.Enums;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{


    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        public IReadOnlyCollection<IComponent> Components => components;

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals;


        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformence) : base(id, manufacturer, model, price, overallPerformence)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }
        public override double OverallPerformance => CalculateOverallPerformance();



        public override decimal Price => this.Peripherals.Sum(x => x.Price) + this.Components.Sum(x => x.Price) + base.Price;

        public void AddComponent(IComponent component)
        {
            if (components.Any(c => c.GetType() == component.GetType()))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }
            this.components.Add(component);
        }


        //TODO..............
        public IComponent RemoveComponent(string componentType)
        {
            if (!this.components.Any(c => c.GetType().Name == componentType))
            {
                var error = string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id);

                throw new ArgumentException(error);
            }

            var com = this.components.FirstOrDefault(x => x.GetType().Name == componentType);
            this.components.Remove(com);

            return com;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (this.peripherals.Any(p => p.GetType() == peripheral.GetType()))
            {
                var excMess = string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id);

                throw new ArgumentException(excMess);
            }
            this.peripherals.Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {

            if (this.peripherals.Any(p => p.GetType().Name != peripheralType))
            {
                var error = string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id);
                throw new ArgumentException(error);
            }

            var peripheral = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);
            this.peripherals.Remove(peripheral);

            return peripheral;
        }


        private double CalculateOverallPerformance()
        {

            if (this.Components.Count == 0)
            {
                return base.OverallPerformance;
            }
            var result = base.OverallPerformance + this.Components.Average(x => x.OverallPerformance);

            return result;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($" Components ({components.Count}):");
            foreach (var component in components)
            {
                sb.AppendLine($"  {component}");
            }
            string averageResult = this.Peripherals.Count == 0 ? "0.00" :
                this.Peripherals.Average(x => x.OverallPerformance).ToString("F2");

            sb.AppendLine($" Peripherals ({this.Peripherals.Count}); Average Overall Performance ({averageResult}):");

            foreach (var peripheral in peripherals)
            {
                sb.AppendLine($"  {peripheral}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
