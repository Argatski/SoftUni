using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //Instance list of people
            List<Person> people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.Add(person);
            }

            /*
            var result = people.Where(a => a.Age > 30)
                .OrderBy(a => a.Name);
            */

            PrintResult(people);

        }
        /// <summary>
        /// Prints all people, whose age is more than 30 years, sorted in alphabetical order.
        /// </summary>
        /// <param name="people"></param>
        private static void PrintResult(List<Person> people)
        {
            foreach (var person in people.OrderBy(a=>a.Name))
            {
                if (person.Age>30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
}

