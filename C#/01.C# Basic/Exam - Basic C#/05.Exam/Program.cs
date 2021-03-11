using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 5 * n;
            int h = 2 * n + 3;
            string dash = new string('-', n * 2);
            string star = new string('*', n);


            Console.WriteLine("{0}{1}{0}", dash, star);
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', n * 2 - 2 - 2 * i),
                                               new string('*', i + 1),
                                                new string('&', n + 2 + 2 * i));

            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}**{1}**{0}", new string('-', n - 1 - i),
                                               new string('~', n + 2 * n - 2 + 2 * i));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2),
                                            new string('|', 5 * n - (n / 2 + 1) * 2));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}**{1}**{0}", new string('-', n / 2 + i),
                                               new string('~', 5 * n - n - 4 - 2 * i));

            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', n  + 2 * i),
                                          new string('*',n/2 -i),
                                          new string('&', n + 2 -  2 * i+ n-2));
                                              
            }

            Console.WriteLine("{0}{1}{0}", dash, star);

        }





    }

}
