using System;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;

        }
        public decimal Cost
        {
            get { return this.cost; }
            private set
            {
                ValidateCost(value);
                this.cost = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                ValidateName(value);
                this.name = value;
            }

        }

        private void ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(GlobalConstants.EmptyNameExcMsg);
            };
        }
        private void ValidateCost(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException(GlobalConstants.EmptyMoneyExcMsg);
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
