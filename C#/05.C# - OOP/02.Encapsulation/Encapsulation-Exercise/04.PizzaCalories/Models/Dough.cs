using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double minWeight = 1;
        private const double maxWeight = 200;

        //Flour type const
        private const double whiteModifier = 1.5;
        private const double wholegrainModifier = 1.0;

        //Baking tupe const
        private const double crispyModifier = 0.9;
        private const double chewyModifier = 1.1;
        private const double homemadeModifier = 1.0;

        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechnique,double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(ExceptionMessage.invalidTupe);
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(ExceptionMessage.invalidTupe);
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new AggregateException(ExceptionMessage.invalidWeight);
                }
                this.weight = value;
            }
        }

        public double CaloriesPerGram => 2 * this.Weight * GetFlourModifier() * GetBakingModifier();
        private double GetFlourModifier()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return whiteModifier;
            }
            return wholegrainModifier;
        }
        private double GetBakingModifier()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return crispyModifier;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return chewyModifier;
            }
            return homemadeModifier;
        }
    }
}
