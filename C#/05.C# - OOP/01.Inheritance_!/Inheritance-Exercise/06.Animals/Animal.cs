using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        //Fields
        private int age;

        //Constructor
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }
        public string Gender { get; set; }

        public virtual string ProduceSound()
        {
            return null;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine(this.ProduceSound());

            return result.ToString().TrimEnd();
        }
    }
}
