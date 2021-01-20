using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            int counter = 0;

            while (true)
            {
                
                string inputPassword = Console.ReadLine();

                char[] cArray = username.ToCharArray();
                string password = string.Empty;

                counter++;

                for (int i = cArray.Length - 1; i >= 0; i--)
                {
                    password += cArray[i];
                }

                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                
            }
        }
    }
}
