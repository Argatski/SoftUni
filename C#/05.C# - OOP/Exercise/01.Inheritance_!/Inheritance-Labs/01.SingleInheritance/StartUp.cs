using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instance of public class dog
            Dog dog = new Dog();
           
            //Method from public class dog
            dog.Bark();

            //Method from public class Animal.The class dog inheritance method "Eat".
            dog.Eat(); 
        }
    }
}
