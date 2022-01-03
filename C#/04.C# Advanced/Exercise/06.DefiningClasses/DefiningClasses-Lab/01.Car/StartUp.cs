using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Istant
            Car car = new Car()
            {
                Make = "Vw",
                Model = "MK3",
                Year = 1992
            };

            //Print result
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
