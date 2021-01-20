using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());


            double totalSabers = Math.Ceiling(students * 0.10 + students) * priceLightsabers;
            double totalRobes = students * priceRobes;
            double freeBels = students / 6;
            double totalBelts = (students - freeBels) * priceBelts;

            double totalPrice = totalBelts + totalRobes + totalSabers;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                totalPrice -= money;
                Console.WriteLine($"Ivan Cho will need {totalPrice:f2}lv more.");
            }
        }
    }
}
