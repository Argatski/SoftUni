using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails.Entity
{
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private string size;
        private double price;

        public Cocktail(string cocktailName, string size, double price)
        {
            this.Name = cocktailName;
            this.Size = size;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                this.name = value;
            }
        }
        //TODo ...
        public string Size
        {
            get { return this.size; }
            protected set
            {

            }
        }

        public double Price
        {
            get { return this.price; }
            protected set
            {
                if (this.Size == "Large")
                {
                    this.price = value;
                }
                else if (this.Size == "Middle")
                {
                    this.price = value * 2 / 3;
                }
                else if (this.Size == "Small")
                {
                    this.price = value / 3;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();

            strb.AppendLine($"{this.Name}  ({this.Size}) - {this.Price:F2}");
            return strb.ToString();
        }
    }
}
