using FizzBuzz.Contracts;
using FizzBuzz.Tests.Fakes;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBussTestsWithout
    {
        private FakeConsoleWriter writer;
        private FizzBuzz fizzBuzz;
        [SetUp]
        public void Setup()
        {
            writer = new FakeConsoleWriter();
            fizzBuzz = new FizzBuzz(writer);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAreOneToTwoThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(1, 2);

            //Assert
            Assert.AreEqual("12", ((FakeConsoleWriter)writer).Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAreOneToThreeThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(1, 3);

            //Assert
            Assert.AreEqual("12fizz", ((FakeConsoleWriter)writer).Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre4To6ThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(4, 6);

            //Assert
            Assert.AreEqual("4buzzfizz", ((FakeConsoleWriter)writer).Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre14To17ThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(14, 17);

            //Assert
            Assert.AreEqual("14fizzbuzz1617", ((FakeConsoleWriter)writer).Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAreMinus5To2ThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(-5, 2);

            //Assert
            Assert.AreEqual("12", ((FakeConsoleWriter)writer).Result);
        }



    }
}