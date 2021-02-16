using System;

namespace _03.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[] { 1, 1 };
            int sum = 0;

            switch (num)
            {
                case 1:
                    Console.WriteLine("1"); break;

                case 2:
                    Console.WriteLine("1"); break;

                    return;
            }

            for (int i = 2; i <== num; i++)
            {
                sum = array[0] + array[1];
                int[] newArray = new int[] { array[1], sum };
                array = newArray;
            }
            Console.WriteLine(sum);
        }
    }
}



