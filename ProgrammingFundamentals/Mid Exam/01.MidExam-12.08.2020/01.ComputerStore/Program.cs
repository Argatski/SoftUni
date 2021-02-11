using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string price = string.Empty;
            double priceTaxes = 0;
            double taxes = 0;
            double sum = 0;
            double totalPrices = 0;
            double additional = 0;
            int count = 0;
            

            while (true)
            {
                price = Console.ReadLine();
                
                if (price == "special")
                {
                    taxes = priceTaxes * 0.2;
                    sum = priceTaxes + taxes;
                    additional = sum * 0.1;
                    totalPrices = sum - additional;

                    if (totalPrices == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }

                    break;
                }
                if (price == "regular")
                {
                    taxes = priceTaxes * 0.2;
                    sum = priceTaxes + taxes;
                    totalPrices = sum;

                    if (totalPrices == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }

                    break;
                }


                double num = double.Parse(price);
               

                if (num < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                

                priceTaxes += num;
            }

            //Output
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrices:f2}$");
        }
    }
}
