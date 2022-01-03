using System;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instant
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Deposit(25);
            acc.Withdraw(10);
            
            //Print result
            Console.WriteLine(acc);

            //Another method of printing the result
            /*Console.WriteLine(acc.Print());*/
        }
    }
}


