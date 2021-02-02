using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbDays = double.Parse(Console.ReadLine());
            double eat = double.Parse(Console.ReadLine());
            double oneDayEat = double.Parse(Console.ReadLine());
            double twoDayEat = double.Parse(Console.ReadLine());
            double theerDayEat = double.Parse(Console.ReadLine());

            double oneEll = numbDays * oneDayEat;
            double twoEll = numbDays * twoDayEat;
            double threeEll = numbDays * theerDayEat;
            double allEat = oneEll+twoEll+threeEll;

            double razlika = Math.Abs(eat - allEat);

            if (eat>=allEat)
            {
                Console.WriteLine($"{Math.Floor(razlika)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(razlika)} more kilos of food are needed.");
            }





        }
    }
}
