using _03.FactoryMethodPattern.Contracts;

namespace _03.FactoryMethodPattern
{
    public class Lion : ICarnivore
    {
        private string eat = "Eat gazelle.";
        public Lion()
        {

        }
        public string AnimalsThatEat { get => this.eat; set => this.eat = value; }
    }
}