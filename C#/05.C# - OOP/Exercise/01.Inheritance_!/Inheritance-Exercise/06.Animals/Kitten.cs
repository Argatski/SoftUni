using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public const string genderKittens = "famale";
        public Kitten(string name, int age)
            : base(name, age, genderKittens)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
