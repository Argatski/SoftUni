using _04.AbstractFactoryPattern.Contracts;

namespace _04.AbstractFactoryPattern.Factories
{
    class AfricanFactory : IAnimalFactory
    {
        public ICarnivore GetCarnivore()
        {
            return new Lion();
        }

        public IInsect GetInsect()
        {
            return new Idolomantis();
        }

        public IVegan GetVegan()
        {
            throw new NotImplementedException();
        }
    }
}
