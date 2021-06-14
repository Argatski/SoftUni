using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(name, model, year);
            Car thirdCar = new Car(name, model, year, fuelQuantity, fuelConsumption);

            firstCar.Drive(1);
            secondCar.Drive(2);
            thirdCar.Drive(3);

            Console.WriteLine($"{firstCar.WhoIam(firstCar)}");
            Console.WriteLine("............");
            Console.WriteLine($"{secondCar.WhoIam(secondCar)}");
            Console.WriteLine("............");
            Console.WriteLine($"{thirdCar.WhoIam(thirdCar)}");
        }
    }
}
