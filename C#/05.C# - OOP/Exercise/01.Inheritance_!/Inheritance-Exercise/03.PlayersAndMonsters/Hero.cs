using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        //Constructor
        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        //Properties
        public string Username { get; set; }
        public int Level { get; set; }

        //Method
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }

    }
}
