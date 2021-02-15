using System;
using System.Collections.Generic;
using System.Text;

namespace _07.OrderByAge
{
    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name,string id , int age)
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

            //return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
