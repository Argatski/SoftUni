using System;

namespace _05.FilterByAge
{
    class FilterByAge
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

            //Array of people
            Person[] people = new Person[number];

            //List of people
            CreateListPeople(people);

            //Filter person
            string filter = Console.ReadLine();//•	Condition - "younger" or "older"
            int filterAge = int.Parse(Console.ReadLine());

            Func<Person, bool> condition = GetAgeCondition(filter, filterAge);

            //Print result
            string printCondition = Console.ReadLine();

            //Format of print
            Func<Person, string> formatter = GetFormatter(printCondition);

            //Print result
            PrintResult(condition, people, formatter);
        }
        /// <summary>
        /// Print result 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="people"></param>
        /// <param name="formatter"></param>
        private static void PrintResult(Func<Person, bool> condition, Person[] people, Func<Person, string> formatter)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine($"{formatter(person)}"/*"{person.Name} - {person.Age}"*/);
                }
            }
        }

        /// <summary>
        /// The function represents how to print results in different cases.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        private static Func<Person, string> GetFormatter(string format)
        {
            switch (format)
            {
                case "name age":
                    return p => $"{p.Name} - {p.Age}";
                case "age":
                    return p => $"{p.Age}";
                case "name":
                    return p => $"{p.Name}";
                default:
                    return null;
            }
        }

        /// <summary>
        /// The function checked person age.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="filterAge"></param>
        /// <returns></returns>
        private static Func<Person, bool> GetAgeCondition(string filter, int filterAge)
        {
            switch (filter)
            {
                case "younger":
                    return p => p.Age < filterAge;
                case "older":
                    return p => p.Age >= filterAge;
                default:
                    return null;
            }
        }

        /// <summary>
        /// The method creates a list of people with "Name" and "Age".
        /// </summary>
        /// <param name="people"></param>
        private static void CreateListPeople(Person[] people)
        {
            for (int p = 0; p < people.Length; p++)
            {
                string[] arr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = arr[0];
                int age = int.Parse(arr[1]);

                people[p] = new Person();

                people[p].Name = name;
                people[p].Age = age;
            }
        }
    }
}
