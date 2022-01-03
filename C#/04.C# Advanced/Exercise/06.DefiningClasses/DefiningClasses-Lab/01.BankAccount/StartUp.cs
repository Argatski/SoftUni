using System;

namespace BankAccount
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Instance
            BankAccount account = new BankAccount();

            account.Id = 1;
            account.Balance = 15;

            //Print result
            Console.WriteLine($"Account {account.Id}, balance {account.Balance}");

           
        }
    }
}
