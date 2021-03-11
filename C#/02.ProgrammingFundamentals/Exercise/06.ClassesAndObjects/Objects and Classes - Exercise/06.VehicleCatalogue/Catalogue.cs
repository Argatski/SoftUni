using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Catalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }

        public Catalogue(string type,string model,string color,int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HP = hp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HP}");

            return sb.ToString().Trim();
        }
    }
}
