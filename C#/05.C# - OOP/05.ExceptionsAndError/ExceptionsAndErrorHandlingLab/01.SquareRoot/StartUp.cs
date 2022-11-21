using System;

namespace _01.SquareRoot
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            try
            {

                if (num < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }
                Console.WriteLine(Math.Sqrt(num));

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
