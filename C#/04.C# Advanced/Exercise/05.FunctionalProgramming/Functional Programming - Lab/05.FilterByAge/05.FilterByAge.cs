using System;

namespace _05.FilterByAge
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            Person[] people = new Person[number];

            //Create the list of people
            for (int i = 0; i < number; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(", ");

                string namePerson = arr[0];
                int agePerson = int.Parse(arr[1]);

                people[i] = new Person();

                people[i].Name = namePerson;
                people[i].Age = agePerson;
            }

            //Older,younger,
            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());

            Func<Person, bool> conditional = GetAgeCondition(filter, filterAge);

            string printConditonal = Console.ReadLine();

            Func<Person, string> formatter = GetFormatter(printConditonal);
            PrintPeople(people, conditional, formatter);

        }

        static Func<Person, string> GetFormatter(string format)
        {
            switch (format)
            {
                case "name":return p => $"{p.Name}";
                case "name age": return p => $"{p.Name} - {p.Age}";
                case "age": return p => $"{p.Age}";
                default:
                    return null;
            }
        }

        static Func<Person, bool> GetAgeCondition(string conditional, int filterAge)
        {
            switch (conditional)
            {
                case "younger":
                    return p => p.Age < filterAge;
                case "older":
                    return p => p.Age >= filterAge;
                default:
                    return null;
            }
        }


        static void PrintPeople(Person[] people, Func<Person, bool> fillter, Func<Person,string> formatter)
        {
            foreach (var person in people)
            {
                if (fillter(person))
                {
                    Console.WriteLine($"{formatter(person)}"/*"{person.Name} - {person.Age}"*/);
                }
            }
        }
    }
}
