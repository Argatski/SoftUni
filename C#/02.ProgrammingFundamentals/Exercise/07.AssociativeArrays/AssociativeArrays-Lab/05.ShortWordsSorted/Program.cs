using System;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            string[] text = Console.ReadLine()
                .ToLower().Split(new char[] {' ','.', ',',':',';', '(', ')','[',
                ']', '"', '\'' ,'\\' ,'/' ,'!' ,'?'  }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();

            //Solution

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
