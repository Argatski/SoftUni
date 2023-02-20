using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LazyInitialization
{
    public class Cart
    {
        public Cart(string param)
        {
            Console.WriteLine("Initializaed" + param);
        }
        public int Balance { get; set; }
    }
}
