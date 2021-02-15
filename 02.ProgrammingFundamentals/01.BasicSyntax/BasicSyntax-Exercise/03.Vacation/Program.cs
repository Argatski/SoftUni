using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal price = 0.0M;
            decimal total = 0.0M;
            
            /// Student Group
            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45M;
                    total = price * numberOfPeople;
                }
                else if (dayOfWeek== "Saturday")
                {
                    price = 9.80m;
                    total = price * numberOfPeople;
                }
                else if (dayOfWeek == "Sunday") // maybe is a problem
                {
                    price = 10.46m;
                    total = price * numberOfPeople;
                }

                if (numberOfPeople>=30)// promotion
                {
                    total *= 0.85m;
                }
            }
            ////Business group
            if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90m;
                    total = price * numberOfPeople;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60m;
                    total = price * numberOfPeople;
                }
                else if (dayOfWeek == "Sunday")// maybe is a problem
                {
                    price = 16;
                    total = price * numberOfPeople;
                }

                if (numberOfPeople >= 100)// promotion
                {
                    total = total -(10*price);
                }
            }
            ////Regular group
            if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                    total = price * numberOfPeople;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                    total = price * numberOfPeople;
                }
                else if (dayOfWeek=="Sunday") // maybe is a problem
                {
                    price = 22.50m;
                    total = price * numberOfPeople;
                }
                if (numberOfPeople >= 10 && numberOfPeople<=20)// promotion
                {
                    total = total*0.95m;
                }
            }

            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}
