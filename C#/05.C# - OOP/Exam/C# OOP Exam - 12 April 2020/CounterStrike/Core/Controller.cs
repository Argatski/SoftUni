using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private IMap map;

        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }
        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun;
            if (type == "Pistol")
            {
                gun = new Pistol(name, bulletsCount);

            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name, bulletsCount);
            }
            else
            {
                return "Invalid gun type!";
            }
            guns.Add(gun);
            return string.Format(OutputMessages.SuccessfullyAddedGun, name);

        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun gun = guns.FindByName(gunName);
            if (gun == null)
            {
                return "Gun cannot be found!";
            }

            IPlayer player;
            if (type == "Terrorist")
            {
                player = new Terrorist(username, health, armor, gun);

            }
            else if (type == "CounterTerrorist")
            {
                player = new CounterTerrorist(username, health, armor, gun);
            }
            else
            {
                return "Invalid player type!";
            }

            players.Add(player);

            return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string Report()
        {
            var sorterPlayers = players.Models
                .OrderBy(p => p.GetType().Name)
                .ThenByDescending(h => h.Health)
                .ThenByDescending(u => u.Username);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var player in sorterPlayers)
            {
                stringBuilder.Append(player.ToString());
            }
            return stringBuilder.ToString().TrimEnd();

        }

        public string StartGame()
        {
            return map.Start(players.Models.ToList());
        }
    }
}
