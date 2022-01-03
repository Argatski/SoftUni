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

        /*//Another solution
        //Fields
        private int id;
        private decimal balance;


        
        /*
        public int Id
        {
            get { return id; }
            set { balance = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        */

        //Methods
        public void Deposit(decimal amount) 
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount) 
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {Id}, Balance {Balance}";
        }

        /// <summary>
        /// Another method of printing the result
        /// </summary>
        /// <returns></returns>
        /*
        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Account {Id}, Balamce {Balance}");

            return sb.ToString();
        }*/
    }
}
