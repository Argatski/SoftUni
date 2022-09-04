using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        //Fields
        private string author;
        private string title;
        private decimal price;

        //Constructor
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        //Properties
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                string[] names = value.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (names.Length > 1)
                {
                    if (char.IsDigit(names[1][0]))
                    {
                        throw new ArgumentException("Author not valid");
                    }
                }
                this.author = value;
            }
        }
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        //Method
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();

            return result;
        }
    }
}
