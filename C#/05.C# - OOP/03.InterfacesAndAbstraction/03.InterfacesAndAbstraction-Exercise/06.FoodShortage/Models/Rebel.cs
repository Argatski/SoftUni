namespace FoodShortage
{
    public class Rebel : Person
    {
        public const int food = 5;
        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
        }
        public string Group
        { get; private set; }
        public override void BuyFood()
        {
            this.Food += food;
        }
    }
}
