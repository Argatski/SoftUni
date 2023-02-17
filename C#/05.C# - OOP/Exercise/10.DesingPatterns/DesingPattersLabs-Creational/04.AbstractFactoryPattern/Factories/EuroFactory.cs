using _04.AbstractFactoryPattern.Contracts;

namespace _04.AbstractFactoryPattern.Factories
{
    class EuroFactory : IAnimalFactory
    {
        public ICarnivore GetCarnivore()
        {
            return new Bear();
        }

        public IInsect GetInsect()
        {
            throw new NotImplementedException();
        }

        public IVegan GetVegan()
        {
            throw new NotImplementedException();
        }
    }
}
