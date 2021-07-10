using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input 
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ");

                string name = arguments[0];
                int age = int.Parse(arguments[1]);

                var person = new Person(name, age);

                family.AddMember(person);
            }

            var oldPerson = family.GetOldestMember();

            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");
        }
    }
}
