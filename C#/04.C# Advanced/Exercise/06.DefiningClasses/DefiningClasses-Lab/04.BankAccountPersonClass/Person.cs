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

        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount> Accounts { get; set; }

        //Constructor

        public Person(string name, int age):this(name,age, new List<BankAccount>())
        {
        }
        public Person(string name, int age, List<BankAccount> accounts)
        {
            Name = name;
            Age = age;
            Accounts = accounts;
        }

        //Methods
        public decimal GetBalance()
        {
            return accounts.Sum(a=>a.Balance) ;
        }
    }
}
