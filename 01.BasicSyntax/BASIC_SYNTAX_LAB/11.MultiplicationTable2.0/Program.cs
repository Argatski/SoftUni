using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplicationNumber = int.Parse(Console.ReadLine());

            if (multiplicationNumber>10)
            {
                Console.WriteLine($"{number} X {multiplicationNumber} = {number*multiplicationNumber}");
                return;
            }

            for (int i = multiplicationNumber; i <=10; i++)
            {
                Console.WriteLine($"{number} X {multiplicationNumber} = {multiplicationNumber*number}");
                multiplicationNumber++;
            }
        }
    }
}
//using system;

//namespace _11.multiplicationtabel2._0
//{
//    class program
//    {
//        static void main(string[] args)
//        {
//            int number = int.parse(console.readline());
//            int multiplier = int.parse(console.readline());

//            if (multiplier > 10)
//            {
//                console.writeline($"{number} x {multiplier} = {number * multiplier}");
//                return;
//            }
//            for (int i = multiplier; i <= 10; i++)
//            {
//                console.writeline($"{number} x {i} = {i * number}");
//            }

//        }
//    }
//}
