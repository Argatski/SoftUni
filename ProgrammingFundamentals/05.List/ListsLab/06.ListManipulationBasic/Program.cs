using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _06.ListManipulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();

            //Solution
            Solution(numbers);

            //Print output
            Console.WriteLine(string.Join(' ',numbers));

        }

        /// <summary>
        /// Logic and solution of programs
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static List<int> Solution(List<int> numbers)
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                int numberManipulation = (int.Parse)(command[1]);

                if (command[0] == "Add")
                {
                    AddNumber(numbers, numberManipulation);
                }
                else if (command[0] == "Remove")
                {
                    RemoveNumber(numbers, numberManipulation);
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveAtNumber(numbers, numberManipulation);
                }
                else if (command[0] == "Insert")
                {
                    int indexManipulation = (int.Parse)(command[2]);

                    InsertNumber(numbers, numberManipulation, indexManipulation);
                }
                
            }
            return numbers;
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
    }
}
