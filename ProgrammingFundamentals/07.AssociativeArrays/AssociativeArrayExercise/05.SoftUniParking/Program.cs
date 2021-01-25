using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numComands = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>()
;
            //Processing
            Processing(numComands, dict);

            //Print
            PrintResult(dict);

        }

        public static void PrintResult(Dictionary<string,string> d)
        {
            foreach (var name in d)
            {
                Console.WriteLine($"{name.Key} => {name.}");
            }
        }

        public static void Processing(int n, Dictionary<string, string> d)
        {
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string user = cmdArgs[1];

                switch (command)
                {
                    case "register":
                        string carRegisrationNumber = cmdArgs[2];
                        RegistrationCar(user, carRegisrationNumber, d);
                        break;
                    case "unregister":
                        UnregisterCar(user, d);
                        break;
                }
            }
        }

        static void UnregisterCar(string user, Dictionary<string, string> d)
        {
            if (d.ContainsKey(user))
            {
                d.Remove(user);

                Console.WriteLine($"{user} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
        }

        static void RegistrationCar(string user, string licensePlateNumber, Dictionary<string, string> d)
        {
            if (d.ContainsKey(user))
            {
                string plateNumber = d[user];

                Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
            }
            else
            {
                d[user] = licensePlateNumber;

                Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
            }

        }
    }
}
