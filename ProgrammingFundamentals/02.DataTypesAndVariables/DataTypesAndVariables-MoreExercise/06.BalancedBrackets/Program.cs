using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            int countBracketOpen = 0;
            int countBracketClose = 0;
            string lastsumbol = string.Empty;


            for (int i = 0; i < numberLine; i++)
            {
                string sumbol = Console.ReadLine();

                switch (sumbol)
                {
                    case"(": countBracketOpen++;break;
                    case")":
                        countBracketClose++;
                        if (countBracketOpen-countBracketClose!=0)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                        break;
                    default:
                        break;
                }
                
            }
            
            if (countBracketClose==countBracketOpen)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
