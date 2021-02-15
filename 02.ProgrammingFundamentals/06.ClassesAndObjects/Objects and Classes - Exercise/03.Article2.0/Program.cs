using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Article2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            //Solution
            Proccessing(articles);
            //Output
            PrintOutput(articles);
        }

        static void PrintOutput(List<Article> articles)
        {
            string printType = Console.ReadLine();

            // Order articles by type.
            if (printType=="title")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(t => t.Title))); // whit environment.NewLine  printing array index by one by one (foreach) 
            }
            else if (printType=="content")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(c => c.Content))); // whit environment.NewLine  printing array index by one by one (foreach) 

            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(a => a.Author))); // whit environment.NewLine  printing array index by one by one (foreach) 

            }
        }

        static List<Article> Proccessing(List<Article> articles)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine().Split(", ");

                Article article = new Article(text[0], text[1], text[2]);
                articles.Add(article);
            }
            return articles;
        }

        //class Article
        //{
        //    public string Title { get; set; }
        //    public string Content { get; set; }
        //    public string Author { get; set; }

        //    public Article(string title, string content, string author)
        //    {
        //        Title = title;
        //        Content = content;
        //        Author = author;
        //    }

        //    public override string ToString() // type
        //    {
        //        return $"{Title} - {Content}: {Author}";
        //    }
        //}
    }
}
