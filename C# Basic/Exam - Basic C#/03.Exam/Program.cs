using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double numDays = double.Parse(Console.ReadLine());
            string pomeshtenie = Console.ReadLine();
            string exxselent = Console.ReadLine();

            double apartment = 0.0;


            switch (pomeshtenie)
            {
                case "room for one person":
                    apartment = (numDays-1) * 18.00;
                    break;
                case "apartment":
                    if (numDays > 15)
                    {
                        apartment = (numDays-1) * 25.00 * 0.5;
                    }
                    else if (numDays > 10 && numDays <= 15)
                    {
                        apartment = (numDays-1) * 25.00 * 0.65;
                    }
                    else
                    {
                        apartment = (numDays-1) * 25.00 * 0.70;
                    }
                    break;
                case "president apartment":
                    if (numDays > 15)
                    {
                        apartment = (numDays-1) * 35.00 * 0.8;
                    }
                    else if (numDays > 10 && numDays <= 15)
                    {
                        apartment = (numDays-1) * 35.00 * 0.85;
                    }
                    else
                    {
                        apartment = (numDays-1) * 35.00 * 0.90;
                    }
                    break;
                default:
                    break;
            }

            if (exxselent == "positive")
            {
                apartment = apartment * 1.25;
                Console.WriteLine("{0:f2}",apartment);
            }
            else if (exxselent == "negative")
            {
                apartment = apartment * 0.9;
                Console.WriteLine("{0:f2}",apartment);
            }
        }
    }
}
