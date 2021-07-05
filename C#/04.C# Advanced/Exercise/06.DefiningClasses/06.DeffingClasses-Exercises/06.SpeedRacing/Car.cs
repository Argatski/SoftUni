using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //Proprties
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        //Constructors
        public Car()
        {

        }
        public Car(string model,double fuelAmount,double fuelConsumptionPerKilometer,double distance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = distance; 
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


        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}
