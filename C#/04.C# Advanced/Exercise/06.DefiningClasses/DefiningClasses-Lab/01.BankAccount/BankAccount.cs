using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        //Prive 
        private int id;
        private decimal balance;

        //Properties
        public int Id { get; set; }
        public decimal Balance { get; set; }

        /*
        //Another type of Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }*/
    }
}
