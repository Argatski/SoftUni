using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Google
{
    public class Car
    {
        //Fields
        public string model;
        public int speed;

        //Constructr
        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        //Print format
        public override string ToString()
        {
            return this.model + " " + this.speed;
        }
    }
}
