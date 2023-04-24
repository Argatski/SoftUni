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
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                this.name = value;
            }
        }
        public string Size
        {
            get { return this.size; }
            private set
            {
                this.size = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if (this.Size == "Middle")
                {
                    value = (value / 3) * 2;
                }
                else if (this.Size == "Small")
                {
                    value /= 3;
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();

            strb.AppendLine($"{this.Name}  ({this.Size}) - {this.Price:F2} lv");
            return strb.ToString();
        }
    }
}
