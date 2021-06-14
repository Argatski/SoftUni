using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }


        //Constructors
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        //Methods and functions

        public void Drive(double distance)
        {
            double result = FuelQuantity - (FuelConsumption * distance);

            if (result >= 0)
            {
                FuelQuantity = result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoIam(Car car)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Make);
            sb.AppendLine(Model);
            sb.AppendLine(Year.ToString());
            sb.AppendLine(FuelQuantity.ToString());
            sb.AppendLine(FuelConsumption.ToString());

            return sb.ToString();
        }
    }
}
