using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class BankAccount
    {

        //Properties
        public int Id { get; set; }
        public decimal Balance { get; set; }

        //Methods
        public decimal Deposit(decimal amount)
        {
            return Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            return Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{Id}, balance {Balance:f2}";
        }

    }
}
