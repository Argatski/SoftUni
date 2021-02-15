using System;
using System.Runtime.CompilerServices;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //First line
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());

            //Second line
            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());

            // Solutiom

            double lineA = FirstLineLenght(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            double lineB = FirstLineLenght(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
            bool closetPoint = CoordinatesPoint(firstLineX1, firstLineY1, secondLineX1, secondLineY2);

            if (lineA >= lineB && closetPoint)
            {
                Console.Write("({0}, {1})", firstLineX1, firstLineY1);
                Console.Write("({0}, {1})", firstLineX2, firstLineY2);
                Console.WriteLine();

            }
            else if (lineB > lineA && closetPoint)
            {
                Console.Write("({0}, {1})", secondLineX1, secondLineY1);
                Console.Write("({0}, {1})", secondLineX2, secondLineY2);
                Console.WriteLine();

            }
            else if (lineB > lineA && closetPoint == false)
            {
                Console.Write("({0}, {1})", secondLineX2, secondLineY2);
                Console.Write("({0}, {1})", secondLineX1, secondLineY1);
                Console.WriteLine();

            }

        }

        static double FirstLineLenght(double x1, double y1, double x2, double y2)
        {
            double lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lenght;
        }

        static bool CoordinatesPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x1 + y1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x2 + y2, 2));

            bool isClosetToZero = false;

            if (firstPoint <= secondPoint)
            {
                 isClosetToZero = true;
            }
            return isClosetToZero;
        }
    }
}
