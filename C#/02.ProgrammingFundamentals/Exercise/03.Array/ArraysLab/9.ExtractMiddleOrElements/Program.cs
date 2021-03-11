using System;
using System.Linq;

namespace _9.ExtractMiddleOrElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numbersArr.Length == 1)
            {
                Console.Write(string.Join("{ 0 }", numbersArr));
                return;
            }
            if (numbersArr.Length % 2 == 0)
            {
                Console.Write($"{numbersArr[numbersArr.Length / 2 - 1]}" + ", " +
                    $"{numbersArr[numbersArr.Length / 2]}");
            }
            else
            {
                Console.Write($"{numbersArr[numbersArr.Length / 3]}" + ", "
                    + $"{numbersArr[numbersArr.Length / 3 + 1]}" + ", " +
                    $"{numbersArr[numbersArr.Length / 3 + 2]}");
            }
            Console.WriteLine();
        }
    }
}

///Another sullution///
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _10.Extract_Middle_1__2_or_3_Elements
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            int n = array.Length;
//            int[] result;

//            if (n == 1)
//            {
//                result = new int[1];
//                result[0] = array[0];
//            }
//            else if (n % 2 == 0)
//            {
//                result = new int[2];
//                result[0] = array[n / 2 - 1];
//                result[1] = array[n / 2];
//            }
//            else
//            {
//                result = new int[3];
//                result[0] = array[n / 2 - 1];
//                result[1] = array[n / 2];
//                result[2] = array[n / 2 + 1];
//            }

//            Console.WriteLine(string.Join(", ", result));
//        }
//    }
//}
