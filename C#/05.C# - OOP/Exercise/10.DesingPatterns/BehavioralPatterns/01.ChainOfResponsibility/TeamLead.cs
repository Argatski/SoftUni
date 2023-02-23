using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChainOfResponsibility
{
    internal class TeamLead : Approver
    {

        public override bool HandleRequest(int amount)
        {
            if (amount < 5)
            {
                Console.WriteLine("Get my money");
                return true;
            }
            else
            {
               return Next.HandleRequest(amount);
            }
        }
    }
}
