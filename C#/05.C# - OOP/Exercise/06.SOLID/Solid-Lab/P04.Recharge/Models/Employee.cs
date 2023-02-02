namespace P04.Recharge
{
    using P04.Recharge.Models.Interfaces;
    using System;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id)
            : base(id)
        {
        }

        public void Sleep()
        {
            Console.WriteLine("Employee is sleeping!");
        }


    }
}
