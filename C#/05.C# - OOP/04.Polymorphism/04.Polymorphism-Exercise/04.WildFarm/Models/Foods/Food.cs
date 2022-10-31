using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Core
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; }
    }
}
