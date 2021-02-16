using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] cmdArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //Solution
            Processing(cmdArgs);

        }

        static void Processing(string[] cmdArgs)
        {
            double result = 0;
            double totalSum = 0;


            for (int i = 0; i < cmdArgs.Length; i++)
            {
                string arg = cmdArgs[i];

                if (char.IsUpper(arg[0]) && char.IsLower(arg[arg.Length - 1]))
                {
                    result = UpperLower(arg);
                    totalSum += result;
                }
                else if (char.IsUpper(arg[0]) && char.IsUpper(arg[arg.Length - 1]))
                {
                    result = UpperUpper(arg);
                    totalSum += result;
                }
                else if (char.IsLower(arg[0]) && char.IsUpper(arg[arg.Length - 1]))
                {
                    result = LowerUpper(arg);
                    totalSum += result;
                }
                else if (char.IsLower(arg[0]) && char.IsLower(arg[arg.Length - 1]))
                {
                    result = LowerLower(arg);
                    totalSum += result;
                }
            }

            totalSum = Math.Round(totalSum, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine($"{totalSum:f2}");
        }

        static double LowerLower(string arg)
        {

            int startIndex = arg.IndexOf(arg[1]);
            int lenght = arg.Length - 1 - startIndex;
            double number = (double.Parse)(arg.Substring(startIndex, lenght));

            double multiplier = arg[0] - 96;
            double add = arg[arg.Length - 1] - 96;

            double result = (number * multiplier) + add;

            return result;
        }

        static double LowerUpper(string arg)
        {
            int startIndex = arg.IndexOf(arg[1]);
            int lenght = arg.Length - 1 - startIndex;
            double number = (double.Parse)(arg.Substring(startIndex, lenght));

            double multiplier = arg[0] - 96;
            double subtract = arg[arg.Length - 1] - 64;

            double result = (number * multiplier) - subtract;
            return result;
        }

        static double UpperUpper(string arg)
        {
            int startIndex = arg.IndexOf(arg[1]);
            int lenght = arg.Length - 1 - startIndex;
            double number = (double.Parse)(arg.Substring(startIndex, lenght));

            double subtract = arg[arg.Length - 1] - 64;
            double dividerFirst = arg[0] - 64;

            double result = (number / dividerFirst) - subtract;
            return result;
        }

        static double UpperLower(string arg)
        {
            int startIndex = arg.IndexOf(arg[1]);
            int lenght = arg.Length - 1 - startIndex;
            double number = (double.Parse)(arg.Substring(startIndex, lenght));

            double divider = arg[0] - 64;
            double add = arg[arg.Length - 1] - 96;

            double div = number / divider;

            double result = div + add;

            return result;
        }
    }
}
