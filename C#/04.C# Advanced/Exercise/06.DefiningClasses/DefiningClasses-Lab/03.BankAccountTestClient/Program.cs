using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instant
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            //Input
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] argumment = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (argumment[0])
                {
                    case "Create":
                        Create(argumment, accounts);
                        break;
                    case "Deposit":
                        Deposit(argumment, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(argumment, accounts);
                        break;
                    case "Print":
                        Print(argumment, accounts);
                        break;
                }
            }


        }

        private static void Print(string[] argumment, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(argumment[1]);
            if (accounts.ContainsKey(currentId))
            {
                Console.WriteLine(accounts[currentId]);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] argumment, Dictionary<int, BankAccount> accounts)
        {

            var currentId = int.Parse(argumment[1]);

            if (accounts.ContainsKey(currentId))
            {
                var money = decimal.Parse(argumment[2]);

                if (accounts[currentId].Balance>money)
                {
                    accounts[currentId].Withdraw(money);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] argumment, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(argumment[1]);
            

            if (accounts.ContainsKey(currentId))
            {
                var money = decimal.Parse(argumment[2]);
                accounts[currentId].Deposit(money);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] argumment, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(argumment[1]);
            if (accounts.ContainsKey(currentId))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.Id = currentId;
                accounts.Add(currentId, acc);
            }
        }
    }
}
