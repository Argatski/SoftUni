using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            short years =(short) (centuries * 100);
            int days = (int)(years * 365.2422);
            decimal hours = days * 24M;
            decimal minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days}" +
                $" days = {hours} hours = {minutes} minutes");

        }
    }
}
