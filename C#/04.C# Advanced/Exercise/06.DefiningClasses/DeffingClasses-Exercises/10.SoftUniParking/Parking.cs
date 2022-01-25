using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        //Fields
        private Dictionary<string, Car> cars;
        private int capacity;

        //Properties
        public int Count => cars.Count();

        //Constuctor
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new Dictionary<string, Car>();
        }

        //Methods
        /// <summary>
        /// The method first checks if there is already a car with the provided car registration number and if there is, the method returns the following message:"Car with that registration number, already exists!"
        /// Next checks if the count of the cars in the parking is more than the capacity and if it is returns the following message:"Parking is full!"
        /// Finally if nothing from the previous conditions is true it just adds the current car to the cars in the parking and returns the message:"Successfully added new car {Make} {RegistrationNumber}"
        /// </summary>
        /// <param name="car"></param>
        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count == this.capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car.RegistrationNumber, car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        /// <summary>
        /// Removes a car with the given registration number. If the provided registration number does not exist returns the message:"Car with that registration number, doesn't exist!"
        /// Otherwise, removes the car and returns the message:"Successfully removed {registrationNumber}"
        /// </summary>
        /// <param name="registrationNumber"></param>
        public string RemoveCar(string registrationNumber)
        {
            if (cars.ContainsKey(registrationNumber))
            {
                cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        /// <summary>
        /// Returns the Car with the provided registration number.
        /// </summary>
        /// <param name="registrationNumber"></param>
        /// <returns></returns>
        public Car GetCar(string registrationNumber) => cars[registrationNumber];

        /// <summary>
        /// A void method, which removes all cars that have the provided registration numbers. Each car is removed only if the registration number exists.
        /// </summary>
        /// <param name="RegistrationNumbers"></param>
        public void RemoveSetRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var registration in RegistrationNumbers)
            {
                if (cars.ContainsKey(registration))
                {
                    RemoveCar(registration);
                }
            }
        }
    }
}
