using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            //Instance Motorcycle
            Vehicle vehicle = new Motorcycle(100, 150.0);
            Console.WriteLine(vehicle);

            vehicle.Drive(1.5);
            Console.WriteLine(vehicle);
            
            //Instance RaceMotorcycle
            vehicle = new RaceMotorcycle(125, 200);
            Console.WriteLine(vehicle);

            vehicle.Drive(2);
            Console.WriteLine(vehicle);

            //Instance CrossMotorcycle
            vehicle = new CrossMotorcycle(150, 20);
            Console.WriteLine(vehicle);

            vehicle.Drive(3);
            Console.WriteLine(vehicle);

            //Instance CrossMotorcycle
            vehicle = new Car(1500, 150);
            Console.WriteLine(vehicle);

            vehicle.Drive(100);
            Console.WriteLine(vehicle);
            
        }
    }
}
