using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {

        //Properties
        public int Id { get; set; }
        public decimal Balance { get; set; }

        //Methonds
        public  void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }

    }
}
