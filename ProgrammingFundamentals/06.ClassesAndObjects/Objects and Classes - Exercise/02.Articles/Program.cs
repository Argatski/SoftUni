using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(arguments[0], arguments[1], arguments[2]);

            Proccessing(article);

            Console.WriteLine(article);

        }

        static void Proccessing(Article article)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] commands = Console.ReadLine().Split(": ").ToArray();

                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;
                    case "Rename":
                        article.Rename(commands[1]);
                        break;
                }

            }
        }
    }
}
