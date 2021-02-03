using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = n; i < n; i++)
            {
                for (int j = m; j < m; j++)
                {
                    

                        int sum1 = i % 10;
                        int sum2 = i / 10;
                        int sum3 = sum2 % 10;
                        int sum4 = i / 100;
                        int sum5 = sum4 % 10;
                        int sum6 = i / 1000;

                        if (sum1 % 2 != 0 && sum3 % 2 != 0 && sum5 % 2 != 0 && sum6 % 2 != 0)
                        {
                            Console.WriteLine(i);

                        }
                    }
            }


            






        }
    }
}
