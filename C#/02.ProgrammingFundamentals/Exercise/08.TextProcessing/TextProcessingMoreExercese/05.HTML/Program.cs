using System;
using System.Text;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string article = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            string coments;
            while ((coments=Console.ReadLine())!="end of comments")
            {
                sb.AppendLine("<div>");
                sb.AppendLine($"\t{coments}");
                sb.AppendLine("</div>");
            }

            Console.WriteLine($"<h1>\n\t{article}\n</h1>");
            Console.WriteLine($"<article>\n\t{content}\n</article>");
            Console.WriteLine(sb);
        }
    }
}
