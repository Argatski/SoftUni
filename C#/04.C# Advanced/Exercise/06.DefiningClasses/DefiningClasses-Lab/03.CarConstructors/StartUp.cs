using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Input
            string name = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            //Instant
            Car firstCar = new Car();
            Car secondCar = new Car(name, model, year);
            Car thirdCar = new Car(name, model, year, fuelQuantity, fuelConsumption);
           
            //Get distance
            firstCar.Drive(1);
            secondCar.Drive(2);
            thirdCar.Drive(3);

            //Print result
            Console.WriteLine($"{firstCar.ToString()}");
            Console.WriteLine("............");
            Console.WriteLine($"{secondCar.ToString()}");
            Console.WriteLine("............");
            Console.WriteLine($"{thirdCar.ToString()}");

        }
    }
}
