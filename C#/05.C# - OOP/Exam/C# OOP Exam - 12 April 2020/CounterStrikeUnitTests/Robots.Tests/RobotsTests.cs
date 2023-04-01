namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager manager;
        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Test", 10);
            manager = new RobotManager(10);
        }
        [Test]
        public void WhenRobotsIsCreated_PropertiesShouldBeSet()
        {
            Assert.AreEqual("Test", robot.Name);
            Assert.AreEqual(10, robot.Battery);
            Assert.AreEqual(10, robot.MaximumBattery);
        }

        [Test]
        public void WhenRobotManagerIsCreated_CapacityBeSet()
        {
            Assert.AreEqual(10, manager.Capacity);
        }
        [Test]
        public void WhenRobotManagerIsNegative_ExceptionShouldBeThrown()
        {

            Assert.Throws<ArgumentException>(() => { RobotManager robotManager = new RobotManager(-5); });
        }

        [Test]
        public void WhenRobotManagerIsZero_CountShouldBeZero()
        {
            Assert.AreEqual(0, manager.Count);
        }
    }
}
