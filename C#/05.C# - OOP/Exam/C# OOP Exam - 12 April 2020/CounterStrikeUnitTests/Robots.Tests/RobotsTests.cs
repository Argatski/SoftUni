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

        [Test]
        public void WhenAddSameRobots_ExceptionShouldBeThrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                manager.Add(robot);
                manager.Add(robot);
            });

        }
        [Test]
        public void WhenAddWithoutCapacity_ExceptionShouldBeThrown()
        {
            Robot robot2 = new Robot("Test2", 3);
            Robot robot3 = new Robot("Test3", 3);
            Robot robot4 = new Robot("Test4", 3);

            Assert.Throws<InvalidOperationException>(() =>
            {
                RobotManager robotManager2 = new RobotManager(3);
                robotManager2.Add(robot);
                robotManager2.Add(robot2);
                robotManager2.Add(robot3);
                robotManager2.Add(robot4);
            });

            Assert.Throws<InvalidOperationException>(() =>
            {
                RobotManager robotManager = new RobotManager(0);
                robotManager.Add(robot);
            });

        }
        [Test]
        public void WhenAddWithCorrectData_ShouldBeWork()
        {
            manager.Add(robot);
            Assert.AreEqual(1, manager.Count);
            manager.Add(new Robot("s", 2));
            Assert.AreEqual(2, manager.Count);
        }


        [Test]
        public void WhenRemoveNotExistingRobot_ExceptionShould()
        {
            Assert.Throws<InvalidOperationException>(() => manager.Remove("B"));
        }

        [Test]
        public void WhenRemoveExistingRobot_ShouldWork()
        {
            robot = new Robot("Test", 10);
            manager.Add(robot);

            manager.Remove("Test");

            Assert.AreEqual(0, manager.Count);
        }

        [Test]
        public void WhenWorkNotExistingRobot_ExceptionShouldBeThrown()
        {
            Assert.Throws<InvalidOperationException>(() => manager.Work("No", "Jobs", 20));
        }

        [Test]
        public void WhenWorkNotCharegedRobot_ExceptionShouldBeThrown()
        {
            manager.Add(new Robot("No", 10));
            Assert.Throws<InvalidOperationException>(() => manager.Work(robot.Name, "Jobs", robot.Battery + 10));
        }
        [Test]
        public void WhenWorkNotCharegedRobot_ShouldBeDeacreaseBattery()
        {
            robot = new Robot("No", 10);
            manager.Add(robot);

            manager.Work(robot.Name, "jobs", 5);

            Assert.AreEqual(robot.Battery, 5);
        }
        [Test]
        public void WhenChargeNotExisting_ExceptionShouldBeThrown()
        {
            robot =  new Robot("Test", 10);

            Assert.Throws<InvalidOperationException>(() => manager.Charge(robot.Name));
        }
        [Test]
        public void WhenchargeRobot_ShouldGetToMaximum()
        {
            robot = new Robot("No", 10);
            manager.Add(robot);

            manager.Work(robot.Name, "jobs", 5);
            manager.Charge(robot.Name);

            Assert.AreEqual(robot.Battery, 10);
        }
    }
} 
