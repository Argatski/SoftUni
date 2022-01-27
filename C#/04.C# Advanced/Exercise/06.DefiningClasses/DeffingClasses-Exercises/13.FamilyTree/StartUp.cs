using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.FamilyTree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var familyTree = new List<Person>();
            var familyRelations = new List<string>();

            var query = Console.ReadLine();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                if (!line.Contains("-"))
                {
                    var persoInfo = line.Split();
                    var name = persoInfo[0] + " " + persoInfo[1];
                    var birthdate = persoInfo[2];
                    familyTree.Add(new Person(name, birthdate));
                }
                else
                {
                    familyRelations.Add(line);
                }
            }

            foreach (var relation in familyRelations)
            {
                var personInfo = relation.Split('-').Select(x => x.Trim()).ToArray();
                var parentParam = personInfo[0];
                var childParam = personInfo[1];

                var parent = new Person();
                var child = new Person();

                parent = AddParentAndChildInfo(parentParam, familyTree, parent);
                child = AddParentAndChildInfo(childParam, familyTree, child);

                child.Parents.Add(parent);
                parent.Children.Add(child);
            }
            PrintQueryPerson(familyTree, query);
        }

        /// <summary>
        /// Print result
        /// </summary>
        /// <param name="familyTree"></param>
        /// <param name="query"></param>
        private static void PrintQueryPerson(List<Person> familyTree, string query)
        {
            Person queryPerson;
            if (IsBirthday(query))
            {
                queryPerson = familyTree.FirstOrDefault(p => p.BirthDate == query);
            }
            else
            {
                queryPerson = familyTree.FirstOrDefault(p => p.Name == query);
            }
            Console.WriteLine(queryPerson);
        }

        private static Person AddParentAndChildInfo(string personInfo, List<Person> familyTree, Person person)
        {
            if (IsBirthday(personInfo))
            {
                person = familyTree.FirstOrDefault(p => p.BirthDate == personInfo);
            }
            else
            {
                person = familyTree.FirstOrDefault(p => p.Name == personInfo);
            }
            return person;
        }

        //Check that the input is digital
        private static bool IsBirthday(string input)
        {
            return Char.IsDigit(input[0]);
        }
    }
}
