using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class ParkingLot
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
        /// <summary>
        /// Print all car in parkinglot after command "END".
        /// </summary>
        /// <param name="parkingLot"></param>
        private static void Print(HashSet<string> parkingLot)
        {
            foreach (var car in parkingLot)
            {
                Console.WriteLine(car);
            }
        }

        /// <summary>
        /// Records a car number and removes a car number
        /// </summary>
        /// <param name="parkingLot"></param>
        private static void Processing(HashSet<string> parkingLot)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] args = input
                    .Split(", ");

                string command = args[0];
                string numberCar = args[1];

                switch (command)
                {
                    case "IN":
                        parkingLot.Add(numberCar);
                        break;
                    case "OUT":
                        parkingLot.Remove(numberCar);
                        break;
                }
            }
        }
    }
}
