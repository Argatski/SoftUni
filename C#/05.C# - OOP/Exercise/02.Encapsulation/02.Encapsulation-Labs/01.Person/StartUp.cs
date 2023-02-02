using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var personList = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(firstName, lastName, age);

                personList.Add(person);
            }

            //Another solution
            /*foreach (var person in personList.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList())
            {
                person.ToString();
            }*/

            personList.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));


        }
    }
}
