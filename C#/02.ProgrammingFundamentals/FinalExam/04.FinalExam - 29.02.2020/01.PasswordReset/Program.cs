using System;
using System.Linq;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string passText = Console.ReadLine();

            //Proccesing
            Proccesing(passText);
        }

        static void Proccesing(string password)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] args = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (args[0])
                {
                    case "TakeOdd":
                        password = TakeOddCharacters(password, args);
                        break;

                    case "Cut":
                        password = CutCharactersText(password, args);
                        break;

                    case "Substitute":
                        password = SubstituteText(password, args);
                        break;
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }

        static string SubstituteText(string password, string[] args)
        {
            string substring = args[1];
            string chageWhitCharacters = args[2];

            if (password.Contains(substring))
            {
                password = password.Replace(substring, chageWhitCharacters);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            return password;
        }

        static string CutCharactersText(string password, string[] args)
        {
            int startIndex = int.Parse(args[1]);
            int lenght = int.Parse(args[2]);

            password = password.Remove(startIndex, lenght);
            Console.WriteLine(password);
            return password;
        }

        static string TakeOddCharacters(string password, string[] args)
        {
            StringBuilder oddCharacters = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddCharacters.Append(password[i]);
                }
            }
            password = oddCharacters.ToString();
            Console.WriteLine(oddCharacters);
            return password;
        }
    }
}
