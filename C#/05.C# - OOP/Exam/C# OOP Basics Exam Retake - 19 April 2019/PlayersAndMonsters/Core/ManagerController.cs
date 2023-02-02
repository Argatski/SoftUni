namespace PlayersAndMonsters.Core
{
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Core.Factories;
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System.Text;

    public class ManagerController : IManagerController
    {
        private readonly IPlayerRepository playerRepository;
        private readonly ICardRepository cardRepository;

        private readonly IBattleField battleField;

        private readonly PlayerFactory playerFactory;
        private readonly CardFactory cardFactory;

        public ManagerController(
            IPlayerRepository playerRepository,
            ICardRepository cardRepository,
            IBattleField battleField,
            PlayerFactory playerFactory,
            CardFactory cardFactory)
        {
            this.playerRepository = playerRepository;
            this.cardRepository = cardRepository;
            this.battleField = battleField;
            this.playerFactory = playerFactory;
            this.cardFactory = cardFactory;
        }

        public string AddPlayer(string type, string username)
        {
            var player = playerFactory.CreatePlayer(type, username);

            this.playerRepository.Add(player);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, username);
        }

        public string AddCard(string type, string name)
        {
            var card = this.cardFactory.CreateCard(type, name);

            cardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var player = this.playerRepository.Find(username);
            var card = this.cardRepository.Find(cardName);

            player.CardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, cardName, username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var attackPlayer = playerRepository.Find(attackUser);
            var enemyPlayer = playerRepository.Find(enemyUser);

            battleField.Fight(attackPlayer, enemyPlayer);

            return string.Format(ConstantMessages.FightInfo, attackPlayer.Health, enemyPlayer.Health); /// attackPlayer, enemyPlayer
        }

        public string Report()
        {
            StringBuilder stb = new StringBuilder();
            foreach (var player in playerRepository.Players)
            {
                stb.AppendLine($"{player}");
                foreach (var card in player.CardRepository.Cards)
                {
                    stb.AppendLine($"{card}");
                }
                stb.AppendLine(ConstantMessages.DefaultReportSeparator);
            }
            return stb.ToString().TrimEnd();
        }
    }
}
