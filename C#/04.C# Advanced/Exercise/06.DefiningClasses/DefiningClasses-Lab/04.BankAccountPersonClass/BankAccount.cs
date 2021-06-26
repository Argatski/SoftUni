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
            return $"Acount ID{Id}, balance {Balance:F2}";
        }
    }
}
