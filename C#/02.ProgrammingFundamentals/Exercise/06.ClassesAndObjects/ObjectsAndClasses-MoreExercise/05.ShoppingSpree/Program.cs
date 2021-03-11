using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();
            List<Product> allProduct = new List<Product>();

            FillPeopleList(allPeople);
            FillProductLilst(allProduct);

            Proccessing(allPeople, allProduct);
            Console.WriteLine(string.Join(Environment.NewLine,allPeople));

        }

        static void Proccessing(List<Person> allPeople, List<Product> allProduct)
        {
            string command;
            while ((command=Console.ReadLine())!="END")
            {
                string[] args = command.Split(" ");
                string namePerson = args[0];
                string nameProduct = args[1];

                Person currentPerson = allPeople.Find(p => p.Name == namePerson); 
                Product currentProduc = allProduct.Find(pr => pr.NameProduct == nameProduct);

                if (currentPerson.Money>=currentProduc.Cost)
                {
                    currentPerson.Money -= currentProduc.Cost;

                    currentPerson.BagOfProducts.Add(nameProduct);

                    Console.WriteLine($"{namePerson} bought {nameProduct}");
                }
                else
                {
                    Console.WriteLine($"{namePerson} can't afford {nameProduct}");
                }
            }
        }

        static void FillProductLilst(List<Product> allProduct)
        {
            string[] produucts = Console.ReadLine().Split(";");
            produucts = produucts.Where(x => x != "").ToArray();

            for (int i = 0; i < produucts.Length; i++)
            {
                string[] args = produucts[i].Split("=");

                string name = args[0];
                decimal money = decimal.Parse(args[1]);

                Product product = new Product(name,money);
                allProduct.Add(product);
            }
        }

        static void FillPeopleList(List<Person> allPeople)
        {
            string[] people = Console.ReadLine().Split(";");

            for (int i = 0; i < people.Length; i++)
            {
                string[] args = people[i].Split("=");

                string name = args[0];
                decimal money = decimal.Parse(args[1]);

                Person person = new Person(name,money);

                allPeople.Add(person);
            }
        }
        class Person
        {
            public string Name { get; set; }
            public decimal Money { get; set; }

            public List<string> BagOfProducts;

            public Person(string name, decimal money)
            {
                Name = name;
                Money = money;
                BagOfProducts = new List<string>();
            }
            public override string ToString()
            {
                if (BagOfProducts.Count == 0)
                {
                    return $"{Name} - Nothing bought";
                }
                return $"{Name} - {string.Join(", ", BagOfProducts)}";
            }
        }
        class Product
        {
            public string NameProduct { get; set; }
            public decimal Cost { get; set; }

            public Product(string name, decimal cost)
            {
                NameProduct = name;
                Cost = cost;
            }
        }
    }
}
