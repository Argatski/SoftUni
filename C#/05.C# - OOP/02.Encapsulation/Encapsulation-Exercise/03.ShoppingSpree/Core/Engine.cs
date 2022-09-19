
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;
        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }
        public void Run()
        {
            try
            {
                this.ParsePeopleInput();
                this.ParserProductsInput();

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string personName = cmdArgs[0];
                    string productName = cmdArgs[1];

                    Person person = this.people
                        .FirstOrDefault(p => p.Name == personName);
                    Product product = this.products
                        .FirstOrDefault(p => p.Name == productName);
                    if (person != null && product != null)
                    {
                        string result = person.AddProductToBag(product);
                        Console.WriteLine(result);
                    }

                }
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var person in this.people)
            {
                Console.WriteLine(person);
            }

        }
        private void ParsePeopleInput()
        {
            string[] peopleArgs = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var personStr in peopleArgs)
            {
                string[] personArgs = personStr
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string personName = personArgs[0];
                decimal personMoney = decimal.Parse(personArgs[1]);

                Person person = new Person(personName, personMoney);
                this.people.Add(person);
            }
        }
        private void ParserProductsInput()
        {
            string[] productsArgs = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var productStr in productsArgs)
            {
                string[] productArgs = productStr
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productName = productArgs[0];
                decimal productCost = decimal.Parse(productArgs[1]);

                Product product = new Product(productName, productCost);
                this.products.Add(product);
            }
        }
    }
}
