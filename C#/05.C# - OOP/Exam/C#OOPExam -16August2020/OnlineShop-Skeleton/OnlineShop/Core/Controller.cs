using OnlineShop.Common.Constants;
using OnlineShop.Common.Enums;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private readonly List<IComputer> computers;
        private readonly List<IComponent>
            components;

        private readonly List<IPeripheral>
            peripherals;

        public Controller()
        {
            computers = new List<IComputer>();
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            DoesComputerExist(computerId);
            if (this.components.Any(i => i.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }
            IComponent component = null;
            if (componentType == "CentralProcessingUnit")
            {
                component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "Motherboard")
            {
                component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "PowerSupply")
            {
                component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "RandomAccessMemory")
            {
                component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "SolidStateDrive")
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "VideoCard")
            {
                component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }
            this.components.Add(component);

            this.computers.FirstOrDefault(x => x.Id == computerId)
                .AddComponent(component);

            return string.Format(SuccessMessages.AddedComponent, componentType, id, computerId);
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (this.computers.Any(i => i.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            IComputer computer = null;
            if (computerType == "Laptop")
            {
                computer = new Laptop(id, manufacturer, model, price);
            }
            else if (computerType == "DesktopComputer")
            {
                computer = new DesktopComputer(id, manufacturer, model, price);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
            this.computers.Add(computer);

            return string.Format(SuccessMessages.AddedComputer, id);
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            DoesComputerExist(computerId);
            if (this.peripherals.Any(i => i.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }

            IPeripheral peripheral = null;

            if (peripheralType == "Headset")
            {
                peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Keyboard")
            {
                peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Monitor")
            {
                peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Mouse")
            {
                peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }

            this.peripherals.Add(peripheral);

            this.computers.First(i => i.Id == computerId).AddPeripheral(peripheral);

            return string.Format(SuccessMessages.AddedPeripheral, peripheralType, peripheral.Id, computerId);
        }


        //TODO ... Use where price<= budget
        public string BuyBest(decimal budget)
        {
            string output = string.Format(ExceptionMessages.CanNotBuyComputer, budget);

            var topComputer = this.computers.OrderByDescending(o => o.OverallPerformance).
                ThenByDescending(p => p.Price <= budget)
                .FirstOrDefault();

            if (topComputer == null)
            {
                throw new ArgumentException(output);
            }

            this.computers.Remove(topComputer);
            return topComputer.ToString();
        }

        public string BuyComputer(int id)
        {
            DoesComputerExist(id);
            var currentPS = this.computers.FirstOrDefault(i => i.Id == id);

            this.computers.Remove(currentPS);

            return currentPS.ToString();

        }

        public string GetComputerData(int id)
        {
            DoesComputerExist(id);

            var currentPC = this.computers.FirstOrDefault(I => I.Id == id);

            return currentPC.ToString();
        }

        //TODO...then removes component from the collection of components.
        public string RemoveComponent(string componentType, int computerId)
        {
            DoesComputerExist(computerId);
            var componet =  this.computers.FirstOrDefault(c => c.Id == computerId)
                .RemoveComponent(componentType);


            return string.Format(SuccessMessages.RemovedComponent, componentType, componet.Id);

        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            DoesComputerExist(computerId);

            var peripheral = this.computers.FirstOrDefault(x => x.Id == computerId).RemovePeripheral(peripheralType);

            return string.Format(SuccessMessages.RemovedPeripheral, peripheralType, peripheral.Id);
        }

        private void DoesComputerExist(int id)
        {

            if (!this.computers.Any(i => i.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }
    }
}
