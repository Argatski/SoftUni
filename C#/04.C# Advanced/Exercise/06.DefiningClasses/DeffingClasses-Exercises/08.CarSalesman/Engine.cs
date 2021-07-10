using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        //Properties
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        //Constructors
        //When we have information for Model engine and power
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;

        }

        //When we have information for displacement engine
        public Engine(string model, int power, int displacement) : this(model, power)
        {
            Displacement = displacement;
        }

        //When we have information for Efficiency engine
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            Efficiency = efficiency;
        }
        //When we have information for All properties engine.
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            Efficiency = efficiency;
        }

        //Print methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");

            //Check displacement
            if (Displacement == 0)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {Displacement}");
            }

            //Check Efficiency
            if (Efficiency == null)
            {
                sb.Append($"    Efficiency: n/a");
            }
            else
            {
                sb.Append($"    Efficiency: {Efficiency}");
            }

            return sb.ToString();
        }
    }
}
