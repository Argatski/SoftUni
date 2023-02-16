using _03.FactoryMethodPattern.Contracts;

namespace _03.FactoryMethodPattern
{
    internal class Bear : ICarnivore
    {
        private string eat = "Eat sheep.";
        public Bear()
        {

        }
        public string AnimalsThatEat { get => this.eat; set => eat = value; }
    }
}