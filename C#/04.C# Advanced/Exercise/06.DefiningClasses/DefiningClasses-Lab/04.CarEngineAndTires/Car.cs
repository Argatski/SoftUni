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

        }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        //Properties for Tire and Engine

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        //Constructor for Tire and engine
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }
        //Methods
        public string WhoIAm(Car car)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Make}");
            sb.AppendLine($"{Model}");
            sb.AppendLine($"{Year}");
            sb.AppendLine($"{FuelQuantity}");
            sb.AppendLine($"{FuelConsumption}");

            return sb.ToString();
        }
    }
}
