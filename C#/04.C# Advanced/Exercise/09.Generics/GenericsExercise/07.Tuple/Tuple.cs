﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T1, T2>
    {
        //Field
        private T1 item1;
        private T2 item2;

        //Constructor
        public Tuple(T1 item1, T2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        //Print the tuples items in format.
        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
