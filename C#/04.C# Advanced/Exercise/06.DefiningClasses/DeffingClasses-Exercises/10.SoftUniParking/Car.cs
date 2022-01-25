using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        //Constructor
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        //Method
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"Make: {Make}");
            result.AppendLine($"Model: {Model}");
            result.AppendLine($"HorsePower: {HorsePower}");
            result.Append($"RegistrationNumber: {RegistrationNumber}");

            return result.ToString();
        }
    }
}
