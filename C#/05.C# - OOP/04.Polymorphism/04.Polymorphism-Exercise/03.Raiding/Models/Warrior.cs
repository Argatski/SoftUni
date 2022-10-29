using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int WARRIONPOWER = 100;
        public Warrior(string name)
            : base(name, WARRIONPOWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {base.Name} hit for {base.Power} damage";
        }
    }
}
