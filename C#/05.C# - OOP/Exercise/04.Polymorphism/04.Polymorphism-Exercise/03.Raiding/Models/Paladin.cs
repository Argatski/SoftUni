namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int PALADINPOWER = 100;
        public Paladin(string name)
            : base(name, PALADINPOWER)
        {
        }
        
    }
}
