using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private const string PlayerCannotNull = "Player cannot be null";

        private List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public int Count => this.players.Count();

        public IReadOnlyCollection<IPlayer> Players => this.players.AsReadOnly();

        public void Add(IPlayer player)
        {
            this.ChekIfPlayerIsNull(player);

            if (this.players.Any(x => x.Username == player.Username))
            {
                throw new ArgumentException($"Player {player.Username} already exists!");
            }
            this.players.Add(player);
        }

        public IPlayer Find(string username)
        {
            IPlayer player = this.players.FirstOrDefault(x => x.Username == username);
            return player;
        }

        public bool Remove(IPlayer player)
        {
            this.ChekIfPlayerIsNull(player);
            return this.players.Remove(player);
        }
        private void ChekIfPlayerIsNull(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException(PlayerCannotNull);
            }
        }
    }
}
