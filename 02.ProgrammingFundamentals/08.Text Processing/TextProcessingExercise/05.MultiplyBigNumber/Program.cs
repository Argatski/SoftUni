using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string numberAsString = Console.ReadLine().TrimStart('0');
            int multiplyer = int.Parse(Console.ReadLine());
            string reversedNumber = ReversedString(numberAsString);

            if (multiplyer == 0)
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder result = new StringBuilder();
            int remaider = 0;

            for (int i = 0; i < reversedNumber.Length; i++)
            {
                int currentNumber = int.Parse(reversedNumber[i].ToString());
                int resultNumber = multiplyer * currentNumber + remaider;

                remaider = resultNumber / 10;
                result.Append(resultNumber % 10);
            }

            if (remaider > 0)
            {
                result.Append(remaider);
            }

            Console.WriteLine(ReversedString(result.ToString()));

        }

        static string ReversedString(string numberAsString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                sb.Append(numberAsString[i]);
            }
            return sb.ToString();
        }
    }
}
