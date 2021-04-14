using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            HashSet<string> parkingLot = new HashSet<string>();

            //Processing
            Processing(parkingLot);

            //Print all car in parkinglot
            if (!parkingLot.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                Environment.Exit(0);
            }
            Print(parkingLot);

        }

        private static void Print(HashSet<string> parkingLot)
        {
            foreach (var car in parkingLot)
            {
                Console.WriteLine(car);
            }
        }

        private static void Processing(HashSet<string> parkingLot)
        {
            string input = string.Empty;

            while ((input=Console.ReadLine())!="END")
            {
                string[] arguments = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = arguments[0];
                string carNumber = arguments[1];

                switch (direction)
                {
                    case "IN":
                        parkingLot.Add(carNumber);
                        break;

                    case "OUT":
                        parkingLot.Remove(carNumber);
                        break;
                }
            }
        }

    }
}
