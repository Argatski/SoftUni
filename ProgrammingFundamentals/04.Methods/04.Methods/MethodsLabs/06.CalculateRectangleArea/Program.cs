using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Output
            double area = RectangleArea(width, height);
            Console.WriteLine(area);
        }

        static double RectangleArea(double w, double h)
        {
            double area = w * h;
            return area;
        }
    }
}
