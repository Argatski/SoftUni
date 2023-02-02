﻿namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int damagePoints = 120;
        private const int healthPoints = 5;
        public TrapCard(string name)
            : base(name, damagePoints, healthPoints)
        {
        }
    }
}
