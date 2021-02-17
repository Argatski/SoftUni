using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Patterm
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d+)\$";


            decimal totalPrice = 0.0m;
            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "end of shift")
            {
                Match currentMatch = Regex.Match(cmd, pattern);

                if (currentMatch.Success)
                {
                    string name = currentMatch.Groups["customer"].Value;
                    string product = currentMatch.Groups["product"].Value;
                    int quantity = int.Parse(currentMatch.Groups["quantity"].Value);
                    decimal price = decimal.Parse(currentMatch.Groups["price"].Value);

                    totalPrice += quantity * price;

                    Console.WriteLine($"{name}: {product} - {quantity*price:f2} ");
                }

            }
            Console.WriteLine($"Total income: {totalPrice:f2}");

        }
    }
}
