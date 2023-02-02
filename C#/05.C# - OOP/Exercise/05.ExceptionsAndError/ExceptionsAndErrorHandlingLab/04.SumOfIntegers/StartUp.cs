using System;

namespace _04.SumOfIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                 .Split(" ");

            int sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                try
                {
                    int num = int.Parse(elements[i]);

                    sum += num;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{elements[i]}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{elements[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{elements[i]}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
