using System;
namespace FoodShortage
{
    public class Citizen : Person, IIdentifiable
    {
        private const int food = 10;
        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age, birthdate)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

        public override void BuyFood()
        {
            this.Food += food;
        }
    }
}
