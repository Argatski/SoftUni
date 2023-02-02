using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private const string CardIsNull = "Card cannot be null!";
        private List<ICard> cards;

        public CardRepository()
        {
            this.cards = new List<ICard>();
        }
        public int Count => this.cards.Count();

        public IReadOnlyCollection<ICard> Cards => this.cards.AsReadOnly();

        public void Add(ICard card)
        {
            this.ChekedIfCardIsNull(card);
            if (this.cards.Any(c => c.Name == card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }
            this.cards.Add(card);
        }

        public ICard Find(string name) => this.cards.FirstOrDefault(c => c.Name == name);

        public bool Remove(ICard card)
        {
            this.ChekedIfCardIsNull(card);
            return this.cards.Remove(card);
        }

        private void ChekedIfCardIsNull(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException(CardIsNull);
            }
        }
    }
}
