using System;

namespace _01.SortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallest = Math.Min(Math.Min(firstNum,secondNum),thirdNum);
            int largest = Math.Max(Math.Max(firstNum,secondNum),thirdNum);
            int midlle = (firstNum + secondNum + thirdNum) - (smallest + largest);

            Console.WriteLine(largest);
            Console.WriteLine(midlle);
            Console.WriteLine(smallest);
        }
    }
}



//using System;

//namespace _1.SortNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] intArray = new int[3];

//            for (int i = 0; i < intArray.Length; i++)
//            {
//                intArray[i] = int.Parse(Console.ReadLine());
//            }
//            Array.Sort(intArray);
//            Array.Reverse(intArray);

//            foreach (var item in intArray)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}

