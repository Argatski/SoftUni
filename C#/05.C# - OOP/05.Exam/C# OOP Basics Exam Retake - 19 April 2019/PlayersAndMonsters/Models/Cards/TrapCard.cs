namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCad : Card
    {
        private const int damagePoints = 120;
        private const int healthPoints = 5;
        public TrapCad(string name)
            : base(name, damagePoints, healthPoints)
        {
        }
    }
}
