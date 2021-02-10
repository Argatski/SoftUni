using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbGudje = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double sandClock = 0.0;
            double magent = 0.0;
            double cup = 0.0;
            double tshirt = 0.0;






            for (int i = 1; i <= numbGudje; i++)
            {
                string prodaraka = Console.ReadLine();
                switch (prodaraka)
                {
                    case "sand clock": sandClock = sandClock + 2.20; break;
                    case "magnet":magent = magent + 1.5;break;
                    case "cup": cup = cup + 5.00;break;
                    case "t-shirt":tshirt = tshirt + 10.00;break;
                    default:
                        break;
                }

            }
            double sum = sandClock + magent + cup + tshirt;
            double all = Math.Abs( money - sum);
            if (money >=sum)
            {
                Console.WriteLine("Santa Claus has {0:f2} more leva left!",all);
            }
            else
            {
                Console.WriteLine("Santa Claus will need {0:f2} more leva.",all);
            }


        }
    }
}
