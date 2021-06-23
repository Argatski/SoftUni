using System;

namespace BankAccount
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            //Instance
            acc.Id = 1;
            acc.Balance = 15;

            Console.WriteLine($"Account {acc.Id}, balance{acc.Balance}");
        }
    }
}
