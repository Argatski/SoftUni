using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            Console.WriteLine(stackOfStrings.IsEmpty());// Return "True"

            stackOfStrings.AddRange(new string[] { "Pesho", "Gosho", "Stamat" });

            Console.WriteLine(stackOfStrings.IsEmpty()); //Return "False"
        }
    }
}
