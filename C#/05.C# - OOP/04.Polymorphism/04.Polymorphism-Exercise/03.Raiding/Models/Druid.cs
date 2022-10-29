namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int DRUIDPOWER = 80;
        public Druid(string name)
            : base(name, DRUIDPOWER)
        {
        }
    }
}
