using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prototype
{

    public class Drink
    {
        public Drink(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }


    }

    public class Sandwich : SandwichPrototype<Sandwich>
    {

        public Sandwich(string bread, string cheese, string meat, string veggies, Drink drink)
        {
            this.Bread = bread;
            this.Meat = meat;
            this.Chease = cheese;
            this.Veggies = veggies;
            this.Drink = drink;
        }

        public Drink Drink { get; set; }
        public string Bread { get; set; }
        public string Meat { get; set; }
        public string Chease { get; set; }
        public string Veggies { get; set; }

        public override Sandwich ShalloClone()
        {
            return MemberwiseClone() as Sandwich;
        }

        public override Sandwich DeepClone()
        {
            var sandwich = this.MemberwiseClone() as Sandwich;

            sandwich.Bread = this.Bread;
            sandwich.Meat = this.Meat;
            sandwich.Chease = this.Chease;
            sandwich.Veggies = this.Veggies;

            sandwich.Drink = new Drink(this.Drink.Name);

            return sandwich;

        }


        public override string ToString()
        {
            return $"{this.Bread},{this.Chease},{this.Meat},{this.Veggies},{this.Drink.Name}";
        }

    }
}
