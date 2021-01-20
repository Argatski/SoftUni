using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine().ToLower();

                double sum = 0.0;
                double price = 0.0;


                while (command != "Start")
                {
                    double money = double.Parse(command);
                    switch (money)
                    {
                        case 0.1: sum += money; break;
                        case 0.2: sum += money; break;
                        case 0.5: sum += money; break;
                        case 1: sum += money; break;
                        case 2: sum += money; break;

                        default:
                            Console.WriteLine($"Cannot accept {money}");
                            break;

                    }
                    command = Console.ReadLine();
                }

                string purchased = Console.ReadLine();

                while (purchased != "End")
                {
                    switch (purchased)
                    {
                        case "Nuts":
                            price = 2.0;
                            if (sum >= price)
                            {
                                sum -= price;
                                Console.WriteLine($"Purchased {purchased.ToLower()}");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            price = 0.7;
                            if (sum >= price)
                            {
                                sum -= price;
                                Console.WriteLine($"Purchased {purchased.ToLower()}");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;

                        case "Crisps":
                            price = 1.5;
                            if (sum >= price)
                            {
                                sum -= price;
                                Console.WriteLine($"Purchased {purchased.ToLower()}");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;

                        case "Soda":
                            price = 0.8;
                            if (sum >= price)
                            {
                                sum -= price;
                                Console.WriteLine($"Purchased {purchased.ToLower()}");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;

                        case "Coke":
                            price = 1.0;
                            if (sum >= price)
                            {
                                sum -= price;
                                Console.WriteLine($"Purchased {purchased.ToLower()}");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Product");
                            break;
                    }
                    purchased = Console.ReadLine();
                }
                Console.WriteLine($"Chage: {sum:f2}");

            }
        }
    }
}



//using System;
 
//namespace Vending
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string coin = Console.ReadLine();
//            decimal sumCoins = 0;

//            while (coin != "Start")
//            {
//                switch (coin)
//                {
//                    case "0.1":
//                    case "0.2":
//                    case "0.5":
//                    case "1":
//                    case "2":
//                        sumCoins = sumCoins + decimal.Parse(coin);
//                        break;
//                    default:
//                        Console.WriteLine($"Cannot accept {coin}");
//                        break;
//                }
//                coin = Console.ReadLine();
//            }

//            string product = Console.ReadLine();
//            decimal productPrice = 0;

//            while (product != "End")
//            {
//                switch (product)
//                {
//                    case "Nuts":
//                        productPrice = 2.0m;
//                        break;
//                    case "Water":
//                        productPrice = 0.7m;
//                        break;
//                    case "Crisps":
//                        productPrice = 1.5m;
//                        break;
//                    case "Soda":
//                        productPrice = 0.8m;
//                        break;
//                    case "Coke":
//                        productPrice = 1.0m;
//                        break;
//                    default:
//                        Console.WriteLine("Invalid product");
//                        break;
//                }

//                if (sumCoins >= productPrice && sumCoins > 0 && productPrice > 0)
//                {
//                    Console.WriteLine($"Purchased {product.ToLower()}");
//                    sumCoins = sumCoins - productPrice;
//                    productPrice = 0;
//                }
//                else if (productPrice > 0)
//                {
//                    Console.WriteLine("Sorry, not enough money");
//                    productPrice = 0;
//                }
//                product = Console.ReadLine();
//            }
//            Console.WriteLine($"Change: {sumCoins:F2}");
//        }
//    }

//}