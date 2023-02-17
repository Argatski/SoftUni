
namespace _04.AbstractFactoryPattern.Contracts
{
    public interface IAnimalFactory
    {
        public ICarnivore GetCarnivore();
        public IVegan GetVegan();
        public IInsect GetInsect();

    }
}
