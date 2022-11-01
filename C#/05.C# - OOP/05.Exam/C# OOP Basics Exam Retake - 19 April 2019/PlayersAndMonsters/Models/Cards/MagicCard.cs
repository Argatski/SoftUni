namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int damagePoints = 5;
        private const int healthPoints = 80;
        public MagicCard(string name)
            : base(name, damagePoints, healthPoints)
        {
        }
    }
}
