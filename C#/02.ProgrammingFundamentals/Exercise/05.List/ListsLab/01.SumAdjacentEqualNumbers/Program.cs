using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var printList = SumAdjacentEqualNum(number);

            Console.WriteLine(string.Join(" ", printList));
        }

        static List<double> SumAdjacentEqualNum(List<double> num)
        {

            for (int i = 1; i < num.Count; i++)
            {
                if (num[i] == num[i - 1])
                {
                    num[i] += num[i - 1];
                    num.RemoveAt(i - 1);
                    i = 0;
                }
                
            }

            return num;
        }
    }
}
