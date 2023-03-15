using NUnit.Framework;
using System;
using System.Security.Cryptography;

namespace Computers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfNullOrDuplicateDataIsPass()
        {

            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);

            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null));

            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer));
        }
        [Test]
        public void AddMethodShouldWorkAsExpected()
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            Assert.AreEqual(1, computerManager.Count);
            Assert.AreEqual(1, computerManager.Computers.Count);
        }
        [Test]
        public void GetComputerShouldThrowExceptionOmInvalidData()
        {
            ComputerManager computerManager = new ComputerManager();

            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer("test", null));
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "test"));

            Assert.Throws<ArgumentException>(() => computerManager.GetComputer("Test", "test"));

        }
        [Test]
        public void GetComputerShouldWorkAsExpected()
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            var computerFromComputerManager = computerManager.GetComputer("Test", "Test");


            Assert.AreEqual(computerFromComputerManager, computer);

        }
        [Test]
        public void RemoveComputerShouldWorkAsExpected()
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            var computerFromComputerManager = computerManager.RemoveComputer("Test", "Test");

            Assert.AreEqual(computerFromComputerManager, computer);
            Assert.AreEqual(computerManager.Computers.Count, 0);
            Assert.AreEqual(computerManager.Count, 0);

        }
        [Test]
        public void RemoveComputerShouldThrowException()
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            var computerFromComputerManager = computerManager.RemoveComputer("Test", "Test");

            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer(null, "Test"));
            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer("Test", null));
            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("wow", "wow"));

        }
        [Test]
        public void GetComputersByManufactureShouldWorkAsExpected()
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            var computer2 = new Computer("Test", "Test12", 10);
            var computer3 = new Computer("Test2", "Test12", 10);

            computerManager.AddComputer(computer);
            computerManager.AddComputer(computer2);
            computerManager.AddComputer(computer3);

            var computerFromComputerManager = computerManager.GetComputersByManufacturer("Test");

            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputersByManufacturer(null));

            CollectionAssert.Contains(computerFromComputerManager, computer);
            CollectionAssert.Contains(computerFromComputerManager, computer2);
            CollectionAssert.DoesNotContain(computerFromComputerManager, computer3);


        }

    }
}