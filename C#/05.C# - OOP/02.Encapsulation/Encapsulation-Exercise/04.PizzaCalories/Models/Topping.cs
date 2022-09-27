using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int minWeight = 1;
        private const int maxWeight = 50;

        private const double meatModifier = 1.2;
        private const double veggiesModifier = 0.8;
        private const double cheeseModifier = 1.1;
        private const double sauceModifier = 0.9;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                isValidateType(value);
                this.type = value;
            }

        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                isValidateWeight(value);
                this.weight = value;
            }
        }

        public double CaloriesPerGram => 2 * this.Weight * this.GetToppingModifiers();

        private double GetToppingModifiers()        {
            switch (this.Type.ToLower())
            {
                case "meat":
                    return meatModifier;
                case "veggies":
                    return veggiesModifier;
                case "cheese":
                    return cheeseModifier;
                default:
                    return sauceModifier;
            }
        }

        private void isValidateWeight(double value)
        {
            if (value < minWeight || value > maxWeight)
            {
                throw new ArgumentException(string.Format(ExceptionMessage.invalidtToppingWeight, this.Type));
            }
        }

        private void isValidateType(string value)
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException(string.Format(ExceptionMessage.invalidtToppingType, value));
            }
        }
    }
}
