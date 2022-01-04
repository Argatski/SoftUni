using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        /// <summary>
        /// Constructor with default values:
        /// </summary>
        /// <param name="default"></param>
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        /// <summary>
        /// Constructor accepting make, model and year upon initialization and calls the base constructor with its default values for fuelQuantity and fuelConsumption.
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        public Car(string make, string model, int year)
            : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        /// <summary>
        /// Constructor accepting make, model, year, fuelQuantity and fuelConsumption upon initialization and reuses the second constructor to set the make, model and year values.
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="fuelQuantity"></param>
        /// <param name="fuelconsumption"></param>
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }


        //Methods
        public void Drive(double distance)
        {
            double result = FuelQuantity - distance * FuelConsumption;

            if (result >= 0)
            {
                FuelQuantity = result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        /*
        public string WhoAmI(Car car)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Make:{Make}");
            text.AppendLine($"Model:{Model}");
            text.AppendLine($"Year:{Year}");
            text.AppendLine($"Fuel:{FuelQuantity:f2}L");

            string message = text + "";

            return message;
        }
        */

       public override string ToString()
       {
           return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:f2}";
       }
    }
}
