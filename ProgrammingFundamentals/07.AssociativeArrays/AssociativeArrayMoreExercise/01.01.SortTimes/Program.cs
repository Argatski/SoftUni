using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _01._01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> input = Console.ReadLine()
                .Split(" ").OrderBy(t=>t).ToList();

            Console.WriteLine(string.Join(", ",input));
        }
    }
}
