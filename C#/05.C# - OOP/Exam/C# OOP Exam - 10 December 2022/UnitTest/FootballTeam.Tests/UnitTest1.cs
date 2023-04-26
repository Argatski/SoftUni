using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FootballTeam.Tests
{
    public class Tests
    {

        [Test]
        public void CreateFootballTeam_ValidParameters()
        {
            FootballTeam team = new FootballTeam("B", 21);
            Assert.IsNotNull(team);
            Assert.AreEqual("B", team.Name);
            Assert.AreEqual(21, team.Capacity);

            Type t = team.Players.GetType();
            Type excpected = typeof(List<FootballPlayer>);

            Assert.AreEqual(excpected, t);
        }
        [Test]
        public void CreateFootballTeam_InvalidName()
        {
            FootballTeam team;

            Assert.Throws<ArgumentException>(() => team = new FootballTeam("", 15));
        }
        [Test]
        public void CreateFootballTeam_InvalidCapacity()
        {
            FootballTeam team;

            Assert.Throws<ArgumentException>(() => team = new FootballTeam("B", 14));
        }
        [Test]
        public void AddNewPlayer_ValidParameters()
        {
            FootballPlayer player = new FootballPlayer("Me", 8, "Forward");
            FootballTeam team = new FootballTeam("B", 20);

            var actualOutput = team.AddNewPlayer(player);

            var expectedOutput = "Added player Me in position Forward with number 8";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void AddNewPlayer_CapacityFull()
        {
            FootballPlayer player = new FootballPlayer("Me", 1, "Forward");
            FootballPlayer player1 = new FootballPlayer("Me", 1, "Forward");
            FootballPlayer player2 = new FootballPlayer("You2", 3, "Goalkeeper");
            FootballPlayer player3 = new FootballPlayer("Y", 4, "Goalkeeper");
            FootballPlayer player4 = new FootballPlayer("Y", 5, "Goalkeeper");
            FootballPlayer player5 = new FootballPlayer("You", 6, "Goalkeeper");
            FootballPlayer player6 = new FootballPlayer("Y", 7, "Goalkeeper");
            FootballPlayer player7 = new FootballPlayer("Y", 8, "Goalkeeper");
            FootballPlayer player8 = new FootballPlayer("Y", 8, "Goalkeeper");
            FootballPlayer player9 = new FootballPlayer("Player9Name", 9, "Midfielder");
            FootballPlayer player10 = new FootballPlayer("Player10Name", 10, "Midfielder");
            FootballPlayer player11 = new FootballPlayer("Player11Name", 11, "Midfielder");
            FootballPlayer player12 = new FootballPlayer("Player12Name", 12, "Forward");
            FootballPlayer player13 = new FootballPlayer("Player13Name", 13, "Forward");
            FootballPlayer player14 = new FootballPlayer("Player14Name", 14, "Forward");
            FootballPlayer player15 = new FootballPlayer("Player15Name", 15, "Forward");
            FootballPlayer player16 = new FootballPlayer("Player16Name", 16, "Forward");

            FootballTeam team = new FootballTeam("B", 16);

            team.AddNewPlayer(player);
            team.AddNewPlayer(player1);
            team.AddNewPlayer(player2);
            team.AddNewPlayer(player3);
            team.AddNewPlayer(player4);
            team.AddNewPlayer(player5);
            team.AddNewPlayer(player6);
            team.AddNewPlayer(player7);
            team.AddNewPlayer(player8);
            team.AddNewPlayer(player9);
            team.AddNewPlayer(player10);
            team.AddNewPlayer(player11);
            team.AddNewPlayer(player12);
            team.AddNewPlayer(player13);
            team.AddNewPlayer(player14);
            team.AddNewPlayer(player15);
            var actualResult = team.AddNewPlayer(player16);

            var expectedResult = "No more positions available!";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PickPlayer_ValidParameter()
        {
            FootballPlayer player = new FootballPlayer("1", 1, "Forward");
            FootballPlayer player2 = new FootballPlayer("2", 1, "Forward");

            FootballTeam team = new FootballTeam("A", 16);

            team.AddNewPlayer(player);
            team.AddNewPlayer(player2);

            var expectedPlayer = team.PickPlayer("1");

            Assert.AreSame(expectedPlayer, player);

        }
        [Test]
        public void PlayerScore_IncreasesStatistics()
        {
            FootballPlayer player = new FootballPlayer("1", 8, "Forward");
            FootballPlayer player2 = new FootballPlayer("2", 9, "Forward");

            FootballTeam team = new FootballTeam("A", 120);

            team.AddNewPlayer(player);
            team.AddNewPlayer(player2);

            var actualPlayer = team.PlayerScore(8);

            var expectedPlayer = "1 scored and now has 1 for this season!";

            Assert.AreEqual(expectedPlayer, actualPlayer);

        }
        [Test]
        public void CreatePlayer_InvalidName()
        {
            FootballPlayer player;

            Assert.Throws<ArgumentException>(() => player = new FootballPlayer("", 8, "Forward"));

        }
        [Test]
        public void CreatePlayer_InvalidPlayerNumber()
        {
            FootballPlayer player;

            Assert.Throws<ArgumentException>(() => new FootballPlayer("A", 0, "Forward"));


        }
        [Test]
        public void CreatePlayer_ValidPlayerNumber()
        {
            FootballPlayer player = new FootballPlayer("A", 20, "Forward");


            var expected = 20;

            Assert.AreEqual(expected, player.PlayerNumber);


        }
        [Test]
        public void CreatePlayer_InvalidPosition()
        {
            FootballPlayer player;


            Assert.Throws<ArgumentException>(() => new FootballPlayer("A", 20, "F"));


        }
        [Test]
        public void CreatePlayer_ValidPosition()
        {
            FootballPlayer player = new FootballPlayer("A", 20, "Forward");
            FootballPlayer player2 = new FootballPlayer("A", 20, "Midfielder");
            FootballPlayer player3 = new FootballPlayer("A", 20, "Goalkeeper");

            Assert.AreEqual("Forward", player.Position);
            Assert.AreEqual("Midfielder", player2.Position);
            Assert.AreEqual("Goalkeeper", player3.Position);
            


        }

        [Test]
        public void CreatePlayer_Parameters()
        {
            FootballPlayer player = new FootballPlayer("A", 2, "Forward");

            Assert.AreEqual("A", player.Name);
            Assert.AreEqual(2, player.PlayerNumber);
            Assert.AreEqual("Forward", player.Position);


        }

    }
}