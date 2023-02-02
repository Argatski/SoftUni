namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void SetUp ()
        {
            //Arrage
            this.arena = new Arena();
        }
        [Test]
        public void ConstructorShouldInitializeDependentValues()
        {
            //Action-Assert
            Assert.IsNotNull(this.arena.Warriors);
        }

        [Test]
        [TestCase("Stoyan", 10, 10)]
        public void EnrollShouldThrowExcepitonIfWarriorExsts(string name, int DMG, int HP)
        {
            //Arrage
            Warrior warrior = new Warrior(name, DMG, HP);

            //Action
            arena.Enroll(warrior);

            //Asssert
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));

        }
        [Test]
        public void ErollShouldAddWarrionToCollection()
        {
            //Arrage
            Warrior warrior = new Warrior("Gosho", 10, 10);

            //Action
            arena.Enroll(warrior);

            var expectedCount = 1;
            var isAny = arena.Warriors.Any(n => n.Name == "Gosho");
            //Assert
            Assert.AreEqual(expectedCount, arena.Count);

            Assert.IsTrue(isAny);

        }
        [Test]
        public void ArenaFightMethodShouldWorkCorrectly()
        {
            var attacker = new Warrior("Pesho", 10, 100);
            var defender = new Warrior("Gosho", 5, 50);

            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            this.arena.Fight(attacker.Name, defender.Name);

            var expectedAttackerHp = 95;
            var expectedDefenderHp = 40;

            Assert.AreEqual(expectedAttackerHp, attacker.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }

        [Test]
        [TestCase("Gosho","Stoyan")]
        [TestCase("Pesho", "Gosho")]
        public void FightShouldThrowExceptionIfWorrionDoesntExists(string fighter,string defender)
        {
            //Arrage
            Warrior warrior = new Warrior(fighter, 10, 10);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(fighter, defender));

            //Action
            arena.Enroll(warrior);


            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight(fighter, defender));

        }


    }
}
