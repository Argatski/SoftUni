using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number;
                bool isInteger = int.TryParse(input, out number);

                double floatingPoint;
                bool isFloat = double.TryParse(input, out floatingPoint);

                char character;
                bool isCharacters = char.TryParse(input, out character);

                bool boolean;
                bool isBoolean = bool.TryParse(input, out boolean);

                if (isInteger)
                {
                    Console.WriteLine($"{number} is integer type");
                }
                else if (isFloat)
                {
                    Console.WriteLine($"{floatingPoint} is floating point type");
                }
                else if (isCharacters)
                {
                    Console.WriteLine($"{character} is character type");
                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");/// print input because bolean type is uppercase
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
/// Other solution

//while (true)
//            {
//                string input = Console.ReadLine();
//                if (input == "END")
//                {
//                    break;
//                }

//                if (int.TryParse(input, out int integer))
//                {
//                    Console.WriteLine($"{input} is integer type");
//                }
//                else if (double.TryParse(input, out double flotingPoint))
//                {
//                    Console.WriteLine($"{input} is floating point type");
//                }
//                else if (char.TryParse(input, out char character))
//                {
//                    Console.WriteLine($"{input} is character type");
//                }
//                else if (bool.TryParse(input, out bool boolean))
//                {
//                    Console.WriteLine($"{input} is boolean type");
//                }
//                else
//                {
//                    Console.WriteLine($"{input} is string type");
//                }
//{