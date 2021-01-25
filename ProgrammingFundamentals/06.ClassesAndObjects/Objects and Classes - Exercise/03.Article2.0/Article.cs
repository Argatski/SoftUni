using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Article2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString() // type
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
