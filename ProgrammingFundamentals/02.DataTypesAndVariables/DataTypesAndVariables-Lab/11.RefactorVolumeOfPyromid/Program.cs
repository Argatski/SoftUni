using System;

namespace _09.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = 0;
            double width = 0;
            double heigth = 0;
            double volume = 0;

            Console.Write($"Length: ");
            lenght = double.Parse(Console.ReadLine());

            Console.Write($"Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write($"Height: ");
            heigth = double.Parse(Console.ReadLine());

            volume = (lenght * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
