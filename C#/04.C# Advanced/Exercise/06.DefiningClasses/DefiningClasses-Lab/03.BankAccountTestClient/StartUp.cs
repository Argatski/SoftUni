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
            string command = string.Empty;

            //Processing
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (input[0])
                {
                    case "Create":
                        Create(accounts, input);
                        break;
                    case "Deposit":
                        Deposit(accounts, input);
                        break;
                    case "Withdraw":
                        Withdraw(accounts, input);
                        break;
                    case "Print":
                        Print(accounts, input);
                        //TODO: The Print command should print "Account ID{id}, balance {balance}". Round the balance to the second digit after the decimal separator.
                        break;

                }
            }
        }

        private static void Print(Dictionary<int, BankAccount> accounts, string[] input)
        {
            var currentId = int.Parse(input[1]);
            if (accounts.ContainsKey(currentId))
            {
                Console.WriteLine(accounts[currentId]);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        /// <summary>
        /// The user withdraws money from his account
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="input"></param>
        private static void Withdraw(Dictionary<int, BankAccount> accounts, string[] input)
        {
            var currentId = int.Parse(input[1]);
            if (accounts.ContainsKey(currentId))
            {
                var money = decimal.Parse(input[2]);

                if (accounts[currentId].Balance >= money)
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
        /// <summary>
        /// The user deposits money. We need to check if the user exists?
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="input"></param>
        private static void Deposit(Dictionary<int, BankAccount> accounts, string[] input)
        {
            var currentId = int.Parse(input[1]);

            if (accounts.ContainsKey(currentId) == false)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var balance = decimal.Parse(input[2]);

                accounts[currentId].Deposit(balance);
            }
        }

        /// <summary>
        /// Create accounт.
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="input"></param>
        private static void Create(Dictionary<int, BankAccount> accounts, string[] input)
        {
            var currentId = int.Parse(input[1]);

            if (accounts.ContainsKey(currentId))
            {
                Console.WriteLine("Account already exist");
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
