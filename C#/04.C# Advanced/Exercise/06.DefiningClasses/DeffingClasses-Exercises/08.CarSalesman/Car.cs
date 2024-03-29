﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //Properties
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        //Constructor 
        //When we have information about model and engine.
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        //When we have information about model,engine and weight.
        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            Weight = weight;
        }

        //When we have information about model,engine and weight.
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        //When we have information about all properties
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            Color = color;
        }

        //Print result car
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"{Engine}");

            //Check weight 

            if (Weight == 0)
            {
                sb.AppendLine($"  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {Weight}");
            }

            //Check Color
            if (Color == null)
            {
                sb.Append($"  Color: n/a");
            }
            else
            {
                sb.Append($"  Color: {Color}");
            }
            return sb.ToString();
        }

    }
}
