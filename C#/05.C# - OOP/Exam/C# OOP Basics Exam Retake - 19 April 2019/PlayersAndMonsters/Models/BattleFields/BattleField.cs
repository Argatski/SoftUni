using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Linq;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        private const string PlayerDead = "Player is dead!";
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException(PlayerDead);
            }
            if (attackPlayer.GetType() == typeof(Beginner))
            {
                attackPlayer.Health += 40;
                attackPlayer.CardRepository.Cards.ToList().ForEach(c => c.DamagePoints += 30);
            }
            if (enemyPlayer.GetType() == typeof(Beginner))
            {
                enemyPlayer.Health += 40;
                enemyPlayer.CardRepository.Cards.ToList().ForEach(c => c.DamagePoints += 30);
            }
            attackPlayer.Health += attackPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);
            enemyPlayer.Health += enemyPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);

            while (true)
            {
                var attacPlayerDamage = attackPlayer
                    .CardRepository
                    .Cards
                    .Sum(d => d.DamagePoints);

                enemyPlayer.TakeDamage(attacPlayerDamage);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                var enemyPlayerDamage = enemyPlayer
                    .CardRepository
                    .Cards
                    .Sum(d => d.DamagePoints);

                attackPlayer.TakeDamage(enemyPlayerDamage);

                if (attackPlayer.IsDead)
                {
                    break;
                }

            }
        }
    }
}
