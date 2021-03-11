using System;
using System.Collections.Generic;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string destination = Console.ReadLine();

            //Input countries in list

            Processing(destination);
        }

        static void Processing(string destination)
        {
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(":");

                if (command[0] == "Travel")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add Stop":
                        destination = AddDestination(command, destination);
                        break;
                    case "Remove Stop":
                        destination = RemoveStop(command, destination);
                        break;
                    case "Switch":
                        destination = SwitchStop(command, destination);
                        break;
                }
                Console.WriteLine(destination);

            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destination}");
        }

        static string SwitchStop(string[] command, string destination)
        {
            string oldString = command[1];
            string newString = command[2];

            if (destination.Contains(oldString))
            {
                destination = destination.Replace(oldString, newString);
            }
            return destination;
        }

        static string RemoveStop(string[] command, string destination)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            int lenght = endIndex - startIndex;

            if ((startIndex >= 0 && startIndex <= destination.Length - 1)
                && (endIndex <= destination.Length-1 && endIndex >= 0))
            {
                destination = destination.Remove(startIndex, lenght + 1);
            }
            return destination;
        }

        static string AddDestination(string[] command, string destination)
        {
            int index = int.Parse(command[1]);
            string name = command[2];

            if (index >= 0 || index <= destination.Length-1 )
            {
                destination = destination.Insert(index, name);
            }

            return destination;
        }
    }
}
