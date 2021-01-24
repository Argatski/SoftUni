using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string text = Console.ReadLine();
            
            //Solution
            string message = sendMessage(numbers, text);
           
            //Output
            Console.WriteLine(message);
        }
        /// <summary>
        /// Create script message 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        static string sendMessage(List<int> numbers, string text)
        {
            string message = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int digit = numbers[i];
                char symbol;

                while (digit > 0)
                {
                    int num = digit % 10;
                    sum += num;
                    digit /= 10;
                }

                int lenghtText = text.Count();
                int position = 0;
                if (lenghtText < sum)
                {
                    position = Math.Abs(lenghtText - sum);
                }
                else
                {
                    position = sum;
                }

                message += text.ElementAt(position);
                text = text.Remove(position, 1);
            }

            return message;
        }
    }
}
