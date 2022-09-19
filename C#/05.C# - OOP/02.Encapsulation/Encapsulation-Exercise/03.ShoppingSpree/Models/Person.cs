using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private const string notEnoughtMoney = "{0} can't afford {1}";
        private const string buyProduct = "{0} bought {1}";

        private string name;
        private decimal money;
        private readonly ICollection<Product> bagOfProducts;

        private Person()
        {
            this.bagOfProducts = new List<Product>();
        }
        public Person(string name, decimal money)
            : this()
        {
            //Variand -2
            this.Name = name;
            this.Money = money;

            //Variant  - 1
            /*
            this.bagOfProducts = new List<Product>();
            this.Name = name;
            this.Money = money;
            */
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                isValidName(value);
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            private set
            {
                isValidMoney(value);
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get { return (IReadOnlyCollection<Product>)this.bagOfProducts; }
        }
        //Methods
        /// <summary>
        /// If the person can afford a product, add it to his bag. If a person doesn’t have enough money, print an appropriate message ("{personName} can't afford {productName}").
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string AddProductToBag(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new ArgumentException(string.Format(notEnoughtMoney, this.Name, product.Name));
            }
            this.Money -= product.Cost;
            this.bagOfProducts.Add(product);

            return string.Format(buyProduct, this.Name, product.Name);
        }

        public override string ToString()
        {
            string productsOutput = this.bagOfProducts.Count > 0 ? string.Join(", ", this.bagOfProducts) : "Nothing bought";


            return $"{this.Name} - {productsOutput}";
        }

        private void isValidName(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(GlobalConstants.EmptyNameExcMsg);
            }
        }
        private void isValidMoney(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException(GlobalConstants.EmptyMoneyExcMsg);
            }
        }
    }
}
