using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCar = Console.ReadLine();
            List<Catalog> list = new List<Catalog>();
            Catalog catalog = new Catalog();

            while (typeCar != "end")
            {
                string[] vehicle = typeCar.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = vehicle[0];
                string brand = vehicle[1];
                string model = vehicle[2];
                string characteristics = vehicle[3];


                if (type == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = characteristics
                    });
                }
                else
                {
                    catalog.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = characteristics
                    });
                }

                typeCar = Console.ReadLine();
            }


            if (catalog.Cars.Count >= 1)
            {
                Console.WriteLine($"Cars:");
                foreach (Car ct in catalog.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{ct.Brand}: {ct.Model} - {ct.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count >= 1)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck ct in catalog.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{ct.Brand}: {ct.Model} - {ct.Weight}kg");
                }
            }
        }
    }
}
