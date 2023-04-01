using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorists;
        private List<IPlayer> countreTerrorists;

        public Map()
        {
            terrorists = new List<IPlayer>();
            countreTerrorists = new List<IPlayer>();
        }
        public string Start(ICollection<IPlayer> players)
        {
            SeparateTeams(players);

            while (true)
            {
                AttackTeam(terrorists, countreTerrorists);
                
                AttackTeam(countreTerrorists, terrorists);
                

            }
            if (IsTeamAlive(countreTerrorists))
            {
                return "Counter Terrorist wins!";
            }
            else if (IsTeamAlive(terrorists))
            {
                return "Terrorist wins!";
            }

            return "Somthing horrible happened";
        }
        private bool IsTeamAlive(List<IPlayer> players)
        {
            return players.Any(p => p.IsAlive);
        }

        private void AttackTeam(List<IPlayer> attacingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attacingTeam)
            {
                /*if (!attacker.IsAlive)
                { 
                    continue;
                }*/

                foreach (var defender in defendingTeam)
                {
                    if (defender.IsAlive)
                    {
                        defender.TakeDamage(attacker.Gun.Fire());
                    }
                }

            }
        }

        /// <summary>
        /// Separates the players in two types - Terrorist and Counter Terrorist. 
        /// </summary>
        /// <param name="players"></param>
        private void SeparateTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is CounterTerrorist)
                {
                    countreTerrorists.Add(player);
                }
                else if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
            }
        }
    }
}
