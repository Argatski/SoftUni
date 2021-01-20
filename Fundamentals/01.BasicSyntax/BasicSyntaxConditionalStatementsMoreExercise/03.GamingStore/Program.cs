using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string commond = Console.ReadLine();

            double price = 0;
            double sum = 0;

            while (commond != "Game Time")
            {
                switch (commond)
                {
                    case "OutFall 4":
                        price = 39.99;
                        if (balance >= price)
                        {
                            balance -= price;
                            Console.WriteLine($"Bought {commond}");
                            sum += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        price = 15.99;
                        if (balance >= price)
                        {
                            balance -= price;
                            Console.WriteLine($"Bought {commond}");
                            sum += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        price = 19.99;
                        if (balance >= price)
                        {
                            balance -= price;
                            Console.WriteLine($"Bought {commond}");
                            sum += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        price = 59.99;
                        if (balance >= price)
                        {
                            balance -= price;
                            Console.WriteLine($"Bought {commond}");
                            sum += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        price = 29.99;
                        if (balance >= price)
                        {
                            balance -= price;
                            Console.WriteLine($"Bought {commond}");
                            sum += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        if (balance >= price)
                        {
                            balance -= price;
                            Console.WriteLine($"Bought {commond}");
                            sum += price;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money");
                }

                commond = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${sum:F2}. Remaining: ${balance:F2}");
        }
    }
}
