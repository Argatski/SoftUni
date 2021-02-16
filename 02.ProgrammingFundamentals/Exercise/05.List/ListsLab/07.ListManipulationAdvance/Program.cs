using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace _07.ListManipulationAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            //Solution
            GetCommand(numbers);

        }

        static void GetCommand(List<int> num)
        {
            bool isChage = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    if (isChage == true)
                    {
                        Console.WriteLine(string.Join(' ', num));
                        break;
                    }
                    break;
                }

                int numberManipulation;

                switch (command[0])
                {
                    case "Add":
                        numberManipulation = (int.Parse)(command[1]);
                        AddNumber(num, numberManipulation);
                        isChage = true;
                        break;

                    case "Remove":
                        numberManipulation = (int.Parse)(command[1]);
                        RemoveNumber(num, numberManipulation);
                        isChage = true;
                        break;

                    case "RemoveAt":
                        numberManipulation = (int.Parse)(command[1]);
                        RemoveAtNumber(num, numberManipulation);
                        isChage = true;
                        break;

                    case "Insert":
                        numberManipulation = (int.Parse)(command[1]);
                        int indexManipulation = (int.Parse)(command[2]);
                        InsertNumber(num, numberManipulation, indexManipulation);
                        isChage = true;
                        break;

                    case "Contains":
                        int token = int.Parse(command[1]);
                        IsContains(num, token);
                        break;
                    case "PrintEven":
                        GetEvenNumbers(num);
                        break;
                    case "PrintOdd":
                        GetOddNumbers(num);
                        break;
                    case "GetSum":
                        GetSum(num);
                        break;
                    case "Filter":
                        string symbol = command[1];
                        int numberFilter = int.Parse(command[2]);
                        FilterNumbers(num, symbol, numberFilter);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Index manupulation in list
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="numManip"></param>
        /// <param name="indexManip"></param>
        /// <returns></returns>
        static List<int> InsertNumber(List<int> numb, int numManip, int indexManip)
        {
            numb.Insert(indexManip, numManip);
            return numb;
        }

        /// <summary>
        /// Remove at number in list
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="remAtNum"></param>
        /// <returns></returns>
        static List<int> RemoveAtNumber(List<int> numb, int remAtNum)
        {
            numb.RemoveAt(remAtNum);
            return numb;
        }
        /// <summary>
        /// Add number in list
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="addNum"></param>
        /// <returns></returns>
        static List<int> AddNumber(List<int> numb, int addNum)
        {
            numb.Add(addNum);
            return numb;
        }
        /// <summary>
        /// Remove number in list
        /// </summary>
        /// <param name="numb"></param>
        /// <param name="remNum"></param>
        /// <returns></returns>
        static List<int> RemoveNumber(List<int> numb, int remNum)
        {
            numb.Remove(remNum);
            return numb;
        }
        static void FilterNumbers(List<int> num, string symbol, int numFilter)
        {

            switch (symbol)
            {
                case "<":
                    Console.WriteLine(string.Join(' ', num.Where(x => x < numFilter)));
                    break;

                case "<=":
                    Console.WriteLine(string.Join(' ', num.Where(x => x <= numFilter)));
                    break;

                case ">":
                    Console.WriteLine(string.Join(' ', num.Where(x => x > numFilter)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(' ', num.Where(x => x >= numFilter)));
                    break;
            }
            //Another Solution

            //List<int> result = new List<int>();

            //switch (symbol)
            //{
            //    case "<":
            //        for (int i = 0; i < num.Count; i++)
            //        {
            //            if (num[i] < numFilter)
            //            {
            //                result.Add(num[i]);
            //            }
            //        }
            //        break;

            //    case "<=":
            //        for (int i = 0; i < num.Count; i++)
            //        {
            //            if (num[i] > numFilter)
            //            {
            //                result.Add(num[i]);
            //            }
            //        }
            //        break;

            //    case ">":
            //        for (int i = 0; i < num.Count; i++)
            //        {
            //            if (num[i] > numFilter)
            //            {
            //                result.Add(num[i]);
            //            }
            //        }
            //        break;
            //    case ">=":
            //        for (int i = 0; i < num.Count; i++)
            //        {
            //            if (num[i] >= numFilter)
            //            {
            //                result.Add(num[i]);
            //            }
            //        }
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(string.Join(' ', result));
        }

        static void GetSum(List<int> num)
        {
            int sum = num.Sum();
            Console.WriteLine(sum);
        }

        static void GetOddNumbers(List<int> num)
        {
            List<int> odd = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 != 0)
                {
                    odd.Add(num[i]);
                }
            }
            Console.WriteLine(string.Join(' ', odd));
        }

        static void GetEvenNumbers(List<int> num)
        {
            List<int> even = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even.Add(num[i]);
                }
            }
            Console.WriteLine(string.Join(" ", even));
        }

        static void IsContains(List<int> num, int token)
        {

            if (num.Contains(token))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
