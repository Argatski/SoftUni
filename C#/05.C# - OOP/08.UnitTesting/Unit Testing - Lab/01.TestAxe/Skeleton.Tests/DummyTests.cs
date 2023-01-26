using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        [TestCase(100, 90, 10)]
        //[TestCase(90, 80, 10)]
        //[TestCase(200, 100, 10)]
        public void DummyLosesHealthIfAttaked(int health, int exp, int attackPoint)
        {
            //Arrage
            Dummy dummy = new Dummy(health, exp);

            //Action
            dummy.TakeAttack(attackPoint);

            //Assert
            Assert.That(dummy.Health, Is.EqualTo(exp));
        }

        [Test]
        [TestCase(0, 100)]
        public void DeadDummyThrowExceptionIfAttacked
            (int health, int exp)
        {
            //Arrage
            Dummy dummy = new Dummy(health, exp);

            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
        }
        [Test]
        [TestCase(0, 100)]
        //[TestCase(0, 900)]
        public void DeadDummyCanBeXP(int health, int exp)
        {
            //Arrage
            Dummy dummy = new Dummy(health, exp);

            //Action
            var actualResult = dummy.GiveExperience();
            var expectedResult = 100;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        [TestCase(100, 100)]
        //[TestCase(0, 100)]
        public void AliveDummyCanNotBeXP(int health, int exp)
        {
            //Arrage
            Dummy dummy = new Dummy(health, exp);

            //Act-Assert
            Assert.Throws<InvalidOperationException>(()=>dummy.GiveExperience());
        }
    }
}