using System;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool[] array = new bool[number + 1];

            for (int k = 0; k <= number; k++)
            {
                array[k] = true;
            }
            array[0]= false; array[1]= false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] ==true)
                {
                    for (int p = 2; p*i <=number ; p++)
                    {
                        array[p * i] = false;
                    }
                }
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j]==true)
                {
                    Console.Write($"{j} ");
                }
            }
            Console.WriteLine();
        }
    }
}
