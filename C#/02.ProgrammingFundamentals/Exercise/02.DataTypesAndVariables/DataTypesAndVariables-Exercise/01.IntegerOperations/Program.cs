using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            sum /= thirdNumber;
            sum *= fourNumber;

            Console.WriteLine(sum);
        }
    }
}
