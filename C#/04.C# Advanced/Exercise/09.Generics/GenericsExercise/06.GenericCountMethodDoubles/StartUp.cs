using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Instace
            List<Box<double>> numbers = new List<Box<double>>();

            //On the first line, you will receive n - the number of elements to add to the list.
            int n = int.Parse(Console.ReadLine());

            //Add elements in List<Box<double>>
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                Box<double> element = new Box<double>(num);

                numbers.Add(element);
            }

            //On the last line, you will get the value of the element for comparison.

            double value = double.Parse(Console.ReadLine());

            int count = CountGreater(numbers, value);

            Console.WriteLine(count);
        }


        static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
            where T : IComparable<T>
        {
            int count = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
