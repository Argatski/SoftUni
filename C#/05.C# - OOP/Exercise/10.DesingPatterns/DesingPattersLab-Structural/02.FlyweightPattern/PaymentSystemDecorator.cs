using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlyweightPattern
{
    internal class PaymentSystemDecorator : IPaymentSystem
    {
        private IPaymentSystem paymentSystem;
        public PaymentSystemDecorator(IPaymentSystem paymentSystem)
        {
            this.paymentSystem = paymentSystem;
        }

        public void LoanMoney(string from, string to, int amount)
        {
            Console.WriteLine($"Decorated payment system and loggin in our system loans");

            paymentSystem.LoanMoney(from, to, amount);
        }

        public void PayMoney(string from, string to, int amount)
        {
            Console.WriteLine($"Decorated payment system and loggin in our system payments");

            paymentSystem.PayMoney(from, to, amount);
        }
    }
}
