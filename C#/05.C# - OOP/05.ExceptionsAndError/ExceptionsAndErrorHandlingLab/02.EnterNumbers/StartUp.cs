using System;

namespace _02.EnterNumbers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);
                    if (numbers[i] <= start || numbers[i] > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    i--;
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - {end}!");
                    i--;
                    continue;
                }
                start = numbers[i];
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        public static int ReadNumber(int start, int end)
        {

            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                throw new FormatException();
            }
            return num;
        }
    }
}
