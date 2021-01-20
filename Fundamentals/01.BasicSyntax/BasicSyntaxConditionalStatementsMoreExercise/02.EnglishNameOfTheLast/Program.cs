using System;

namespace _02.EnglishNameOfTheLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string nameNumber = string.Empty; 

            number %= 10;

            switch (number)
            {
                case 1:nameNumber = "one";break;
                case 2:nameNumber = "two";break;
                case 3:nameNumber = "three";break;
                case 4:nameNumber = "four";break;
                case 5:nameNumber = "five";break;
                case 6:nameNumber = "six";break;
                case 7:nameNumber = "seven";break;
                case 8:nameNumber = "eight";break;
                case 9:nameNumber = "nine";break;
                case 0:nameNumber = "zero";break;
                default:
                    break;
            }
            Console.WriteLine(nameNumber);

        }
    }
}
