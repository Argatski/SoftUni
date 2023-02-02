using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        [TestCase(100, 100, 100, 100, 99)]
        //[TestCase(100, 100, 100, 100, 98)]
        public void AxeLoosesDurabilityAfterAttack
            (int health,
            int exp,
            int attack,
            int durability,
            int expectedResult)
        {
            //Arrage
            Axe axe = new Axe(health, exp);
            Dummy dummy = new Dummy(attack, durability);

            //Action
            axe.Attack(dummy);

            //Assert
            var actualResult = axe.DurabilityPoints;

            Assert.AreEqual(expectedResult, actualResult);
            //Assert.That(axe.DurabilityPoints, Is.EqualTo(99), "Axe Durability doesn`t change after attack.");
        }
        [Test]
        public void BrokenWeponThrowInvalidOperationException()
        {
            //Arrage
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);

            //Action
            axe.Attack(dummy);

            //Assert
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo
                ("Axe is broken."));
           // Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}