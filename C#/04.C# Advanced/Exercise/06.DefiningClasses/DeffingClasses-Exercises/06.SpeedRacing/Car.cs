using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //Properties
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        //Construnctors
        public Car()
        {
        }
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km, double travelledDistance) : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            TravelledDistance = travelledDistance;
        }


        //Methods
        public void Drive(double amountOfKm)
        {
            bool canMove = FuelAmount >= amountOfKm * FuelConsumptionPerKilometer;

            if (canMove)
            {
                FuelAmount -= (amountOfKm * FuelConsumptionPerKilometer);
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        /// <summary>
        /// Print all cars
        /// </summary>
        /// <param name="cars"></param>
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}"; 
        }
    }
}
