﻿using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        private const string INVALID_USER_NAME = "Player's username cannot be null or an empty string.";
        private const string HEALTH_LESS_ZERO = "Player's health bonus cannot be less than zero.";
        private const string DAMAGE_LESS_ZERO = "Damage points cannot be less than zero.";

        private string name;
        private int health;

        protected Player(ICardRepository cardRepository, string username, int health)
        {
            this.CardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository
        {
            get;
            private set;
        }

        public string Username
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(INVALID_USER_NAME);
                }
                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(HEALTH_LESS_ZERO);
                }
                this.health = value;
            }
        }

        public bool IsDead => this.Health == 0;

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException(DAMAGE_LESS_ZERO);
            }
            if (this.Health - damagePoints < 0)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= damagePoints;
            }
        }

        public override string ToString()
        {
            //$"Username: {this.Username} - Health: {this.Health} – Cards {this.CardRepository.Count}"

            return string.Format(ConstantMessages.PlayerReportInfo, this.Username, this.Health, this.CardRepository.Count);
        }
    }
}
