using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, string> emailList = new Dictionary<string, string>();

            //Solution - add email
            AddEmail(emailList);
            RemoveUnValidEmaal(emailList);

            //Print result 
            PrintResult(emailList);

        }

        static void PrintResult(Dictionary<string, string> emailList)
        {
            foreach (var item in emailList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        static void RemoveUnValidEmaal(Dictionary<string, string> emailList)
        {
            foreach (var item in emailList)
            {
                string currentEmail = item.Value;
                if (currentEmail.Contains(".us") || currentEmail.Contains(".uk"))
                {
                    emailList.Remove(item.Key);
                }
            }
        }

        static void AddEmail(Dictionary<string, string> emailList)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                if (emailList.ContainsKey(command) == false)
                {
                    emailList.Add(command, email);
                }
            }
        }
    }
}
