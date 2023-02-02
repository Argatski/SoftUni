using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int maxLongerName = 15;
        private const int maxToppingNumber = 10;

        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > maxLongerName)
                {
                    throw new ArgumentException(ExceptionMessage.invalidtLenghtName);
                }
                this.name = value;
            }
        }
        public Dough Dough { get; private set; }

        public double TotalCalories => this.Dough.CaloriesPerGram + this.toppings.Sum(t => t.CaloriesPerGram);
        public int ToppingCount => this.toppings.Count();

        /// <summary>
        /// Add topping in List<Topping>
        /// </summary>
        /// <param name="topping"></param>
        public void AddTopping(Topping topping)
        {
            if (this.ToppingCount > maxToppingNumber)
            {
                throw new ArgumentException(ExceptionMessage.invalidToppingsRange);
            }
            this.toppings.Add(topping);
        }

        /// <summary>
        /// Return string result.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - {this.TotalCalories:f2} Calories.");
            return sb.ToString();
        }

    }
}
