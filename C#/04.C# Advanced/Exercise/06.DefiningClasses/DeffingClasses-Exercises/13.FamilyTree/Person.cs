using System;
using System.Collections.Generic;
using System.Text;

namespace _13.FamilyTree
{
    class Person
    {
        //Properteis
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        //Constructor   
        public Person()
        {
            Parents = new List<Person>();
            Children = new List<Person>();
        }
        public Person(string name, string birthDate) : this()
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            //Parents output
            sb.AppendLine(Name + " " + BirthDate);
            sb.AppendLine("Parents:");
            foreach (var parent in Parents)
            {
                sb.AppendLine(parent.Name + " " + parent.BirthDate);
            }

            //Children output
            sb.AppendLine("Children:");

            foreach (var child in Children)
            {
                sb.AppendLine(child.Name + " " + child.BirthDate);
            }

            return sb.ToString();
        }
    }
}
