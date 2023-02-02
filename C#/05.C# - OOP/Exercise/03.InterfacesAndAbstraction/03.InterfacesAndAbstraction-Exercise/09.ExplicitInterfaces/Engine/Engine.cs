using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Engine
{
    public class Engine
    {
        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                IPerson person = new Citizen(name, age, country);
                Console.WriteLine(person.GetName());

                IResident resident = new Citizen(name, age, country);
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
