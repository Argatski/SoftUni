using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string readType = Console.ReadLine();

            //Output
            if (readType=="int")
            {
                int resultIntiger = GetIntTypes(readType);

                Console.WriteLine(resultIntiger);
            }
            else if (readType=="real")
            {
                double resultReal = GetRealsTypes(readType);
                Console.WriteLine($"{resultReal:f2}");
            }
            else
            {
                GetString(readType);
            }
        }
       
        static void GetString(string readType)
        {
            string result = Console.ReadLine();
            Console.WriteLine("$"+ result +"$");
        }

        static int GetIntTypes(string Type)
        {
            int number = int.Parse(Console.ReadLine());
            int result = number * 2;
            return result;
        }
        static double GetRealsTypes(string Type)
        {
            double realNum = double.Parse(Console.ReadLine());

            double result = realNum * 1.5;
            return result;
        }

    }
}
