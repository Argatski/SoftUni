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

            List<Person> people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split();

                string name = arguments[0];
                int age = int.Parse(arguments[1]);

                var person = new Person(name, age);

                people.Add(person);
            }

            var result = people.Where(p => p.Age > 30)
                .OrderBy(n => n.Name);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
