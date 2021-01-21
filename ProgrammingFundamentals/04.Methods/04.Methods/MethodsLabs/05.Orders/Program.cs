using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string orders = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            //Output
            Orders(orders, num);
        }

        //Sulution
        static void Orders(string ord, double num)
        {
            double price = 0;
            double cash = 0;
            switch (ord)
            {
                case "coffee":
                    price = 1.50;
                    Calculation(price, num);
                    break;
                case "water":
                    price = 1.00;
                    Calculation(price, num);
                    break;
                case "coke":
                    price = 1.40;
                    Calculation(price, num);
                    break;
                case "snacks":
                    price = 2.00;
                    Calculation(price, num);
                    break;
                default:
                    break;
            }
        }

        static void Calculation(double price, double num)
        {
            double sum = price * num;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
