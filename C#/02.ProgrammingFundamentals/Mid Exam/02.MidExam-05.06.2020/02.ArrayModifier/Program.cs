using System;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] elements = Console.ReadLine()
                 .Split(" ").Select(int.Parse).ToArray();

            //Solution
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] typeComm = command.Split(" ").ToArray();

                switch (typeComm[0])
                {
                    case "swap":
                        int firstIndex = int.Parse(typeComm[1]);
                        int secondIndex = int.Parse(typeComm[2]);

                        SwapArray(elements, firstIndex, secondIndex);
                        break;

                    case "multiply":
                        firstIndex = int.Parse(typeComm[1]);
                        secondIndex = int.Parse(typeComm[2]);

                        MultiplyArray(elements, firstIndex, secondIndex);
                        break;

                    case "decrease":
                        DecreaseArray(elements);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",elements));

        }
        /// <summary>
        /// Take two elements and swap their places.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        static void SwapArray(int[] arr, int first, int second)
        {
            int firstNum = arr[first];
            int secondNum = arr[second];

            arr[first] = secondNum;
            arr[second] = firstNum;
        }
        /// <summary>
        /// take Element at the 1st index and multiply it with element at 2nd index. Save the product at the 1st index.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="f"></param>
        /// <param name="s"></param>
        static void MultiplyArray(int[] arr, int f, int s)
        {
            int mult = arr[f] * arr[s];

            arr[f] = mult;
        }
        /// <summary>
        /// Decreases all elements in the array with 1.
        /// </summary>
        /// <param name="arr"></param>
        static void DecreaseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
    }
}
