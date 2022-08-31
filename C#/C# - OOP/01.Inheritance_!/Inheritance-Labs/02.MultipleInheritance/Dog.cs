using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Dog : Animal //Inheritance Dog->Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking…");
        }
    }
}
