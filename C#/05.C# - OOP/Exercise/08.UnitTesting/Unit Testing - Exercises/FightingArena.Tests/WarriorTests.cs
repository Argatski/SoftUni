namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        [Test]
        [TestCase("Gosho", 10, 10)]
        [TestCase("Pesho", 20, 10)]
        [TestCase("Pesho", 20, 0)]
        public void WarriorConstructorShouldSetAllCorrectly(string name, int damage, int hp)
        {
            //Arrage
            Warrior warrior = new Warrior(name, damage, hp);

            //Action
            Assert.AreEqual(warrior.Name, name);
            Assert.AreEqual(warrior.Damage, damage);
            Assert.AreEqual(warrior.HP, hp);
        }

        [Test]
        [TestCase("", 10, 10)]
        [TestCase(" ", 10, 10)]
        [TestCase(null, 20, 10)]
        public void WarriorThrowArgumentExceptionNameShouldNotBeEmptyOrWhitespace(string name,int damage,int hp)
        {

            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase("Gosho", 0, 10)]
        [TestCase("Pesho", -1, 10)]
        public void WarriorThrowArgumentExceptionDamageShouldBePositive(string name, int damage, int hp)
        {

            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }
        [Test]
        [TestCase("Gosho", 10, -1)]
        [TestCase("Pesho", 20, -10)]
        public void WarriorThrowArgumentExceptionHPShouldNotBeNegative(string name, int damage, int hp)
        {

            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        
        [Test]
        [TestCase("Gosho", 10, 10, "Pesho", 10, 10)]
        [TestCase("Gosho", 10, 100, "Pesho", 10, 10)]
        [TestCase("Gosho", 10, 50, "Pesho", 100, 50)]
        public void WarriorAttackOperationShouldThrowInvalidOperationExceptionIfHpIsInvalid(string fighterName, int fighterDMG, int fighterHP, string diffenderName, int diffenderDMG, int diffenderHP)
        {
            Warrior fighter = new Warrior(fighterName,fighterDMG,fighterHP);
            Warrior diffender = new Warrior(diffenderName,diffenderDMG,diffenderHP);

            //Assert
            Assert.Throws<InvalidOperationException>(() => fighter.Attack(diffender));

        }
        [Test]
        [TestCase("Gosho", 20, 50,30, "Pesho", 20, 50,30)]
        [TestCase("Gosho", 20, 100,90, "Pesho", 10, 70,50)]
        public void WarriorAttackOperationShouldDecreaseHP(string fighterName, int fighterDMG, int fighterHP,int fighterHpLeft, string diffenderName, int diffenderDMG, int diffenderHP,int diffenderHpLeft)
        {
            //Arrage
            Warrior fighter = new Warrior(fighterName, fighterDMG, fighterHP);
            Warrior diffender = new Warrior(diffenderName, diffenderDMG, diffenderHP);

            //Act
            fighter.Attack(diffender);

            //Assert
            var expFighterHP = fighterHpLeft;
            var expDiffenderHP = diffenderHpLeft;

            Assert.AreEqual(expFighterHP, fighter.HP);
            Assert.AreEqual(expDiffenderHP,diffender.HP);

        }
    } 
}