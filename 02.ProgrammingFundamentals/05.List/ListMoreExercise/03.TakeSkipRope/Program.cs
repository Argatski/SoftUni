using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipeList = new List<int>();
            StringBuilder result = new StringBuilder();
            List<string> nonNumbers = new List<string>();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (char.IsDigit(encryptedMessage[i]))
                {
                    numbers.Add(int.Parse(encryptedMessage[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(encryptedMessage[i].ToString());
                }
            }

            for (int t = 0; t < numbers.Count; t++)
            {
                if (t % 2 == 0)
                {
                    takeList.Add(numbers[t]);
                }
                else
                {
                    skipeList.Add(numbers[t]);
                }
            }

            int indexSkip = 0;

            for (int k = 0; k <takeList.Count; k++)
            {
                List<string> temp = new List<string>(nonNumbers);

                temp = temp.Skip(indexSkip).Take(takeList[k]).ToList();

                result.Append(string.Join("", temp));

                indexSkip += takeList[k] + skipeList[k];
            }

            Console.WriteLine(result.ToString());
        }

    }
}
