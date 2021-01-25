using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> catalogues = new List<Catalogue>();
            //Input

            RegistredVehicle(catalogues);

            PrintVehicle(catalogues);
            PrintVehicleAvrage(catalogues);

        }

        static void PrintVehicle(List<Catalogue> catalogues)
        {
            string command;
            while ((command= Console.ReadLine())!="Close the Catalogue")
            {
                Catalogue current = catalogues.Find(m => m.Model == command);
                if (current!=null)
                {
                    Console.WriteLine(current.ToString());
                }

            }
        }

        private static void PrintVehicleAvrage(List<Catalogue> cat)
        {
            List<Catalogue> cars = cat.Where(t=>t.Type =="Car").ToList();
            List<Catalogue> trucks = cat.Where(t=>t.Type=="Truck").ToList();

            decimal carAverage = 0;
            decimal truskAvrage = 0;

            if (cars.Any())
            {
                carAverage = GetAvarageHp(cars);
            }
            if (trucks.Any())
            {
                truskAvrage = GetAvarageHp(trucks);
            }
            Console.WriteLine($"Cars have average horsepower of: {carAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truskAvrage:f2}.");
        }

        static decimal GetAvarageHp(List<Catalogue> v)
        {
            decimal sum = 0;
            for (int i = 0; i < v.Count; i++)
            {
                sum += v[i].HP;
            }
            return sum / v.Count;
        }

        static void RegistredVehicle(List<Catalogue> catalogues)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicle = input.Split(" ");

                string type = vehicle[0];
                string model = vehicle[1];
                string color = vehicle[2];
                int horsePower = int.Parse(vehicle[3]);

                string typeFormat = GetTypeFormated(type);

                Catalogue catalogue = new Catalogue(typeFormat, model, color, horsePower);
                catalogues.Add(catalogue);
            }
        }

        static string GetTypeFormated(string type)
        {
            string output = string.Empty;
            output += char.ToUpper(type[0]);

            for (int i = 1; i < type.Length; i++)
            {
                output += type[i];
            }
            return output;
        }

        //class Catalogue
        //{
        //    public string Type { get; set; }
        //    public string Model { get; set; }
        //    public string Color { get; set; }
        //    public int HP { get; set; }

        //    public Catalogue(string type, string model, string color, int hp)
        //    {
        //        Type = type;
        //        Model = model;
        //        Color = color;
        //        HP = hp;
        //    }
        //    public override string ToString()
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.AppendLine($"Type: {Type}");
        //        sb.AppendLine($"Model: {Model}");
        //        sb.AppendLine($"Color: {Color}");
        //        sb.AppendLine($"Horsepower: {HP}");

        //        return sb.ToString().Trim();
        //    }
        //}
    }
}
