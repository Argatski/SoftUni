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
        //This is defualt constructor if we need.
        public Car()
        {
        }

        public Car(string make, string model, int year)
        : this()
        {
            Make = make;
            Model = model;
            Year = year;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        //Properties for Tire and engine
        public Tire[] Tires { get; set; }
        public Engine Engine { get; set; }

        //Constructor
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Tire[] tires, Engine engine)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Tires = tires;
            Engine = engine;
        }

        //Method
        //All car drive 20 kilometeres.
        public void Drive(double distance)
        {
            double result = FuelQuantity - (distance * FuelConsumption) / 100;
            if (result >= 0)
            {
                FuelQuantity = result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

       
    }
}
