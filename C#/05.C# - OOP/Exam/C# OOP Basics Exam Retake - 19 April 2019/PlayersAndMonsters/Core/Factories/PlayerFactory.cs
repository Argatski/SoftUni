using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PlayersAndMonsters.Core.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            var playerType = Assembly
                 .GetCallingAssembly()
                 .GetTypes()
                 .Where(p => p.Name == type && !p.IsAbstract)
                 .FirstOrDefault();

            if (playerType == null)
            {
                throw new ArgumentException("Invalid player type!");
            }

            var parameters = new object[]
            {
                new CardRepository(),
                username
            };

            var player = (IPlayer)Activator.CreateInstance(playerType, parameters);

            return player;
        }
    }
}
