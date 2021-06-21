using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelCunsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelCunsumption;
        }



        public Tire[] Tires { get; set; }
        public Engine Engine { get; set; }


        public Car(string make, string model, int year, double fuelQuantity, double fuelCunsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelCunsumption)
        {
            Engine = engine;
            Tires = tires;
        }


        //All car drive 20 kilometers
        public void Drive(double distance)
        {
            double result = FuelQuantity - (distance * FuelConsumption)/100;

            if (result >= 0)
            {
                FuelQuantity = result;
            }
        }


    }
}
