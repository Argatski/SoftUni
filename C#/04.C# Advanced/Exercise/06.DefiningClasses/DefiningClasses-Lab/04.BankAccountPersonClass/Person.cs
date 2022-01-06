using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public class Person
    {
        //Fields
        private string name;
        private int age;
        private List<BankAccount> accounts;


        //Constructors
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, List<BankAccount> accounts)
            : this(name, age)
        {
            this.accounts = new List<BankAccount>();
        }

        //Methods
        public decimal GetBalance()
        {
            decimal sum = accounts.Sum(a => a.Balance);
            return sum;
        }
    }
}
