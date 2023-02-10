using FizzBuzz.Contracts;
using FizzBuzz.Tests.Fakes;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzWithMOCK
    {
        private Mock<IWriter> writer;
        private FizzBuzz fizzBuzz;
        private string result;
        [SetUp]
        public void Setup()
        {
            writer = new Mock<IWriter>();
            writer.Setup(w => w.WriteLine(It.IsAny<string>()))
                .Callback<string>(i => result += i);

            fizzBuzz = new FizzBuzz(writer.Object);
            this.result = string.Empty;
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAreOneToTwoThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(1, 2);

            //Assert
            Assert.AreEqual("12", result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAreOneToThreeThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(1, 3);

            //Assert
            Assert.AreEqual("12fizz", result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre4To6ThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(4, 6);

            //Assert
            Assert.AreEqual("4buzzfizz", result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre14To17ThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(14, 17);

            //Assert
            Assert.AreEqual("14fizzbuzz1617", result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAreMinus5To2ThenResultShouldBeCorrect()
        {
            //Arrange
            //Action
            fizzBuzz.PrintNumbers(-5, 2);

            //Assert
            Assert.AreEqual("12", result);
        }



    }
}