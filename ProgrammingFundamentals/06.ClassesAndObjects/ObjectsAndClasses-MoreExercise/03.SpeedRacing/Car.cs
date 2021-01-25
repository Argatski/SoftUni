using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumation { get; set; }
        public double TraveDistance { get; set; }

        public Car(string model, double fuel, double consumation,double distance)
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumation = consumation;
            TraveDistance = distance;
        }
        /// <summary>
        /// Chek the fuel is enough
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        public bool Calculate(double distance,Car car)
        {
            double fuelNeeded = distance * car.FuelConsumation;
            if (fuelNeeded<=car.FuelAmount)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TraveDistance}";
        }
    }
}
