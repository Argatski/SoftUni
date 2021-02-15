using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int firstEmployees = int.Parse(Console.ReadLine());
            int secondEmployees = int.Parse(Console.ReadLine());
            int thirdEmployees = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            //Solution

            int allAnswerSudent = firstEmployees + secondEmployees + thirdEmployees;

            int hour = 0;

            while (students > 0)
            {
                students -= allAnswerSudent;
                hour++;
                if (hour % 4 == 0)
                {
                    hour++;
                }

            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
