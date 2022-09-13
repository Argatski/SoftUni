using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Person person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));

                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            decimal per = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(per));
            people.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
