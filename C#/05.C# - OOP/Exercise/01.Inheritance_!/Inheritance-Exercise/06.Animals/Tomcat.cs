using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public const string genderTomcat = "male";
        public Tomcat(string name, int age)
            : base(name, age, genderTomcat)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
