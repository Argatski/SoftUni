using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instance dog  
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            //Instance cat
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
