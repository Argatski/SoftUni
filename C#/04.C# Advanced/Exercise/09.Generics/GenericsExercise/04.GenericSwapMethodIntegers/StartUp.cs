using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            //Instance
            Box<int> box = new Box<int>();

            //Read and add element in list
            for (int i = 0; i < count; i++)
            {
                int element = int.Parse(Console.ReadLine());
                box.Add(element);
            }

            //Read array of indexes
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = numbers[0];
            int secondIndex = numbers[1];

            //Swap
            box.Swap(firstIndex, secondIndex);

            //Print result
            Console.WriteLine(box.ToString());

        }
    }
}
