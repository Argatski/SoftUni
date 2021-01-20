using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int odd = 0;
            int sum = 0;


            for (int i = 1; i <= number; i++)
            {
                odd = i * 2 - 1;
                Console.WriteLine(odd);
                sum += odd;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

//using system;

//namespace _9.sumofoddnumbers
//{
//    class program
//    {
//        static void main(string[] args)
//        {
//            int number = int.parse(console.readline());

//            int sum = 0;

//            for (int i = 1; i <= 2 * number; i++)
//            {
//                if (i % 2 == 1)
//                {
//                    console.writeline(i);
//                    sum += i;
//                }
//            }
//            console.writeline("sum:" + " " + sum);
//        }
//    }
//}
