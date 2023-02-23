using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChainOfResponsibility
{
    abstract class Approver
    {
        protected Approver Next { get; set; }
        public abstract bool HandleRequest(int amount);

        public virtual void SetNext(Approver approver)
        {
            Next = approver;
        }
    }
}
