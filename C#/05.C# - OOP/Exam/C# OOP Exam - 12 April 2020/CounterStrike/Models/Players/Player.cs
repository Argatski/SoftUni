using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Numerics;
using System.Text;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string _name;
        private int health;
        private int armor;
        private IGun _gun;

        public Player(string name, int helath, int armor, IGun gun)
        {
            this.Username = name;
            this.Health = helath;
            this.Armor = armor;
            this.Gun = gun;
        }
        public string Username
        {
            get { return _name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
                _name = value;
            }
        }
        public int Health
        {
            get { return health; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }
                this.health = value;
            }
        }

        public int Armor
        {
            get { return this.armor; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }
                this.armor = value;
            }
        }

        public IGun Gun
        {
            get { return this._gun; }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }
            }
        }

        public bool IsAlive
        {
            get { return this.Health > 0; }

        }

        public void TakeDamage(int points)
        {
            if (this.armor - points > 0)
            {
                this.armor -= points;
                return;
            }
            else if (armor > 0)
            {
                points -= armor;
                armor = 0;
            }
            this.Health -= points;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.GetType().Name}: {this.Username}");
            stringBuilder.AppendLine($"--Health: {this.Health}");
            stringBuilder.AppendLine($"--Armor: {this.Armor}");
            stringBuilder.AppendLine($"--Gun: {this.Gun}");

            return base.ToString().TrimEnd();
        }
    }
}
