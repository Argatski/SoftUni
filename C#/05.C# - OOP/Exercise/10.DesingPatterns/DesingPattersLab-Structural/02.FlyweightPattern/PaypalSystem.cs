using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlyweightPattern
{
    internal class PaypalSystem : IPaymentSystem
    {
        public void LoanMoney(string from, string to, int amount)
        {
            Console.WriteLine($"Loaned {amount} momney from {from} to {to}");
        }

        public void PayMoney(string from, string to, int amount)
        {
            Console.WriteLine($"Paid {amount} momney from {from} to {to}");

        }
    }
}
