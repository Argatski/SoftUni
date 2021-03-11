using System;
using System.Collections.Generic;
using System.Text;

namespace _06.StoreBoxes
{
    class Box
    {
        public Box() //Class Item in class Box
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public  decimal ItemPrice { get; set; }

    }
}
