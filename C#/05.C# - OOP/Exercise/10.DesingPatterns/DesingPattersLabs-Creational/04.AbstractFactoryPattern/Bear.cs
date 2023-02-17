using _04.AbstractFactoryPattern.Contracts;

namespace _04.AbstractFactoryPattern
{
    internal class Bear : ICarnivore
    {
        private string eat = "Eat sheep.";
        public Bear()
        {

        }
        public string AnimalsThatEat { get => eat; set => eat = value; }
    }
}