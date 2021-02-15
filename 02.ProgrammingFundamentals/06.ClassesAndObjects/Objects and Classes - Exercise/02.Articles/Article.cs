using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Content = title;
            Author = content;
            Title = author;
        }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }


        public override string ToString()// method for printing
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
