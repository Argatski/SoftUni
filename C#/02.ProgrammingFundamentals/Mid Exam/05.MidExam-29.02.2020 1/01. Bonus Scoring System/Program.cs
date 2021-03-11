using System;
using System.ComponentModel;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            //Solution
            CalculateMaxBonus(students, lectures, initialBonus);
        }

        private static void CalculateMaxBonus(double students, double lectures, double initialBonus)
        {
            double currentBonus = 0;
            int lastAttend = 0;

            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double maxBonus = (attendances / lectures) * (5 + initialBonus);

                if (currentBonus < maxBonus)
                {
                    currentBonus = maxBonus;
                    lastAttend = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(currentBonus)}.");
            Console.WriteLine($"The student has attended {lastAttend} lectures.");
        }
    }
}
