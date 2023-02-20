using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prototype
{
    [Serializable]
    internal class Address : ICloneable
    {
        public City City { get; set; } 
        public Country Country { get; set; }
        public string Street { get; set; }

        public object Clone()
        {   /*Shallow copy
            return this.MemberwiseClone();
            //new Address() { City = City, Country = Country, Street = Street };*/

            /*
            //Deep clone
            var clone = (Address)this.MemberwiseClone();
            clone.City = (City)City.Clone();
            clone.Country = (Country)Country.Clone();

            return clone;
            */

            return DeepClone<Address>(this);


        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public override string ToString()
        {
            return $"Country-{Country.Name} City-{City.Name} Street-{Street}";
        }
    }
}
