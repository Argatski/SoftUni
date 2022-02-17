using System;
using System.Linq;
namespace Threeuple
{
    class StrartUp
    {
        static void Main(string[] args)
        {
            //First input
            var input = Console.ReadLine()
                .Split();

            var fullName = input[0] + " " + input[1];
            var neighborhood = input[2];
            var city = isCityLongWord(input);



            Threeuple<string, string, string> firstOutput = new Threeuple<string, string, string>(fullName, neighborhood, city);

            Console.WriteLine(firstOutput);

            //Second input
            input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var name = input[0];
            int litersOfbeer = int.Parse(input[1]);
            var drunk = isDrunk(input[2]);

            var secondOutput = new Threeuple<string, int, string>(name, litersOfbeer, drunk);

            Console.WriteLine(secondOutput);

            //Third input
            input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            name = input[0];
            double balance = double.Parse(input[1]);
            var bankName = input[2];


            var thirdOutput = new Threeuple<string, double, string>(name, balance, bankName);

            Console.WriteLine(thirdOutput);
        }

        private static string isCityLongWord(string[] input)
        {
            string city = string.Empty;
            if (input.Count() > 4)
            {
                return city = input[3] + " " + input[4];
            }
            return city = input[3];
        }

        private static string isDrunk(string drunk)
        {

            if (drunk == "drunk")
            {
                drunk = "True";
            }
            else
            {
                drunk = "False";
            }
            return drunk;
        }
    }
}
