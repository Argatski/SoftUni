using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompositePattern
{
    public interface IGiftOperation
    {
        void Add(GiftBaseClass giftBaseClass);
        bool Remove(GiftBaseClass giftBaseClass);
    }
}
