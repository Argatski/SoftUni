using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompositePattern
{
    internal class Composite : GiftBaseClass, IGiftOperation
    {
        private ICollection<GiftBaseClass> giftBaseClasses;

        public Composite(string name, int price)
            : base(name, price)
        {
            this.giftBaseClasses = new List<GiftBaseClass>();

        }

        public void Add(GiftBaseClass giftBaseClass)
        {
            this.giftBaseClasses.Add(giftBaseClass);

           
        }

        public bool Remove(GiftBaseClass giftBaseClass)
        {
            return this.giftBaseClasses.Remove(giftBaseClass);
        }
        public override int CalculateTotalPrice()
        {
            var totalPrice = 0;

            foreach (var item in giftBaseClasses)
            {
                totalPrice += item.CalculateTotalPrice();
            }
            return totalPrice;
        }
    }
}
