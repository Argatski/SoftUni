using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(1,2.1),
                new Tire(2,2.3),
                new Tire(3,1.8)
            };

            Engine engine = new Engine(680, 6300);

            Car car = new Car($"Lamborgini", "Urus", 2010, 250, 9, engine, tires);

            /*Console.WriteLine($"Mark{car.Make}\nModel{car.Model}\nYear{car.Year}\nTires{string.Join("\n",car.Tires)}");*/
        }
    }
}
