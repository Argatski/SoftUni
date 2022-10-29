namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int ROGUEPOWER = 100;
        public Rogue(string name)
            : base(name, ROGUEPOWER)
        {
        }
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {base.Name} hit for {base.Power} damage";
        }
    }
}
