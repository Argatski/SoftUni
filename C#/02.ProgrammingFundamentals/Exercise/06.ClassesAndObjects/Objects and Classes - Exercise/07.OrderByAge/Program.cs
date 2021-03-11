using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<People> peoples = new List<People>();

            //Solution
            RegisterPeople(peoples);

            //Sorted and Print
            SortedByAge(peoples);
        }

        static void SortedByAge(List<People> peoples)
        {
            List<People> ages =  peoples.OrderBy(a => a.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, ages));
        }

        static void RegisterPeople(List<People> peoples)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] person = input.Split(" ");

                string name = person[0];
                string id = person[1];
                int age = int.Parse(person[2]);

                People people = new People(name, id, age);
                peoples.Add(people);
            }
        }
        class People
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public People(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{Name} with ID: {ID} is {Age} years old.");
                return sb.ToString().Trim();
            }
        }
    }
}
