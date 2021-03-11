using System;
using System.Collections.Generic;
using System.Text;

namespace _05.NetherRealms
{
    class Demons
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public decimal Damage { get; set; }

        public Demons(string name , double healt ,decimal damage)
        {
            Name = name;
            Health = healt;
            Damage = damage;
        }
    }
}
