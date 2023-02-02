using System.Reflection;

namespace PlayersAndMonsters.Core.Factories
{
    using Contracts;
    using Models.Cards.Contracts;
    using System;
    using System.Linq;

    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            var cardTyper = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(n => n.Name == $"{type}Card" && !n.IsAbstract)
                .FirstOrDefault();

            if (cardTyper == null)
            {
                throw new ArgumentException("Invalid card typer!");
            }

            var card = (ICard)Activator.CreateInstance(cardTyper, name);

            return card;
        }
    }
}
