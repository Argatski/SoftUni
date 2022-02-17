using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<T1, T2, T3>
    {
        //Properties
        public T1 first { get; set; }
        public T2 second { get; set; }
        public T3 third { get; set; }


        //Constructor
        public Threeuple(T1 first, T2 second, T3 third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        //Print result
        public override string ToString()
        {
            return $"{first} -> {second} -> {third}"; 
        }
    }
}
