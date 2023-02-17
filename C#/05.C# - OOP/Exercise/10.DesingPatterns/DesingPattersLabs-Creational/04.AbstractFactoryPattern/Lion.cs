using _04.AbstractFactoryPattern.Contracts;

namespace _04.AbstractFactoryPattern
{
    public class Lion : ICarnivore
    {
        private string eat = "Eat gazelle.";
        public Lion()
        {

        }
        public string AnimalsThatEat { get => eat; set => eat = value; }
    }
}