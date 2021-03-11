using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string activator = Console.ReadLine();
            //Sulution
            Generated(activator);

        }

        static void Generated(string activator)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Generate")
            {
                List<string> type = command.Split(">>>").ToList();
                switch (type[0])
                {
                    case "Contains":
                        string subString = type[1];
                        if (activator.Contains(subString))
                        {
                            Console.WriteLine($"{activator} contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }
                        break;

                    case "Flip":
                        string typerCase = type[1];
                        int startIndex = int.Parse(type[2]);
                        int endIndex = int.Parse(type[3]);
                        int lenght = endIndex - startIndex;

                        string toChages = activator.Substring(startIndex, lenght);

                        if (typerCase == "Upper")
                        {
                            toChages = toChages.ToUpper();
                            StringBuilder sb = new StringBuilder();
                            sb.Append(activator);
                            sb.Insert(endIndex, toChages);
                            sb.Remove(startIndex, lenght);
                            activator = sb.ToString();

                        }
                        else
                        {
                            toChages = toChages.ToLower();
                            StringBuilder sb = new StringBuilder();
                            sb.Append(activator);
                            sb.Insert(endIndex, toChages);
                            sb.Remove(startIndex, lenght);
                            activator = sb.ToString();
                        }
                        Console.WriteLine(activator);
                        break;

                    case "Slice":
                        int startX = int.Parse(type[1]);
                        int endX = int.Parse(type[2]);
                        int count = endX - startX;
                        StringBuilder deleter = new StringBuilder();
                        deleter.Append(activator);
                        deleter.Remove(startX, count);
                        activator = deleter.ToString();

                        Console.WriteLine(activator);
                        break;
                    default:
                        throw new Exception("wrong input!!!");
                        break;
                }

            }
            Console.WriteLine($"Your activation key is: {activator}");

        }
    }
}

//Another Solution
/*
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string activator = Console.ReadLine();
            //Sulution
            Generated(activator);

        }

        static void Generated(string activator)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Generate")
            {
                List<string> type = command.Split(">>>").ToList();
                switch (type[0])
                {
                    case "Contains":
                        string subString = type[1];
                        if (activator.Contains(subString))
                        {
                            Console.WriteLine($"{activator} contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }
                        break;

                    case "Flip":
                        string typerCase = type[1];
                        int startIndex = int.Parse(type[2]);
                        int endIndex = int.Parse(type[3]);
                        int lenght = endIndex - startIndex;

                        string toChages = activator.Substring(startIndex, lenght);

                        if (typerCase == "Upper")
                        {
                            toChages = toChages.ToUpper();
                            StringBuilder sb = new StringBuilder();
                            sb.Append(activator);
                            sb.Insert(endIndex, toChages);
                            sb.Remove(startIndex, lenght);
                            activator = sb.ToString();

                        }
                        else
                        {
                            toChages = toChages.ToLower();
                            StringBuilder sb = new StringBuilder();
                            sb.Append(activator);
                            sb.Insert(endIndex, toChages);
                            sb.Remove(startIndex, lenght);
                            activator = sb.ToString();
                        }
                        Console.WriteLine(activator);
                        break;

                    case "Slice":
                        int startX = int.Parse(type[1]);
                        int endX = int.Parse(type[2]);
                        int count = endX - startX;
                        StringBuilder deleter = new StringBuilder();
                        deleter.Append(activator);
                        deleter.Remove(startX, count);
                        activator = deleter.ToString();

                        Console.WriteLine(activator);
                        break;
                    default:
                        throw new Exception("wrong input!!!");
                        break;
                }

            }
            Console.WriteLine($"Your activation key is: {activator}");

        }
    }
}
 

 */
