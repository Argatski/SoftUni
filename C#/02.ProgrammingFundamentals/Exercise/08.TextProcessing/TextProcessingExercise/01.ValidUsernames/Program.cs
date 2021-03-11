using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] users = Console.ReadLine()
                .Split(", ");

            //Solution
            Processing(users);

        }

        static void Processing(string[] users)
        {
            List<string> validUserNames = new List<string>();

            foreach (var user in users)
            {
                if (user.Length >= 3 && user.Length < 16)
                {
                    bool validUser = ValidUser(user);
                    if (validUser==true)
                    {
                        validUserNames.Add(user);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }

        static bool ValidUser(string user)
        {
            for (int i = 0; i < user.Length; i++)
            {
                if (char.IsLetterOrDigit(user[i]) ||
                    user[i] == '-' || user[i] == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
