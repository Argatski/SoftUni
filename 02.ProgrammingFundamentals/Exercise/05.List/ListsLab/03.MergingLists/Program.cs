using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> firstList = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();


            List<int> secondList = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();

            var printResult = MergingLists(firstList, secondList);

            Console.WriteLine(string.Join(' ', printResult));
        }
        static List<int> MergingLists(List<int> first, List<int> second)
        {
            int minCount = Math.Min(first.Count, second.Count);
            int maxCount = Math.Max(first.Count, second.Count);

            List<int> result = new List<int>();

            if (first.Count <= second.Count)
            {
                for (int i = 0; i < minCount; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                    if (i == minCount - 1)
                    {
                        for (int k = minCount; k < maxCount; k++)
                        {
                            result.Add(second[k]);
                        }
                        break;
                    }
                }
            }

            else
            {
                for (int i = 0; i < minCount; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                    if (i == minCount - 1)
                    {
                        for (int k = minCount; k < maxCount; k++)
                        {
                            result.Add(first[k]);
                        }
                        break;
                    }
                }
            }
            return result;
        }
    }
}
