namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Xml.Schema;

    [TestFixture]
    public class CarManagerTests
    {
        [SetUp]
        public void Setup()
        { }

        [Test]
        [TestCase("VW", "Golf", 10, 100)]
        [TestCase("BMW", "3", 20, 200)]
        public void CarConstructorShouldSetAllDataCorrectly(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            //Arrange-Act
            Car car = new Car
                (make: make,
                 model: model,
                fuelConsumption: fuelConsumption,
                fuelCapacity: fuelCapacity);

            //Assert
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
            Assert.AreEqual(car.FuelAmount, 0); // 
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CarConstuctorShouldThrowArgumentExeptionIfMakeIsNullOrEmpty(string make)
        {
            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Car(make, "Golf", 10, 100));

        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CarConstuctorShouldThrowArgumentExeptionIfModelIsNullOrEmpty(string model)
        {
            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Car("BMW", model, 10, 100));

        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarConstuctorShouldThrowArgumentExeptionIfFuelConsumptionConnotBeZeroOrNegative(double fuelConsumption)
        {
            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Car("BMW", "3", fuelConsumption, 100));

        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarConstuctorShouldThrowArgumentExeptionIfFuelCapacityConnotBeZeroOrNegative(double fuelCapacity)
        {
            //Arrage-Action-Assert
            Assert.Throws<ArgumentException>(() => new Car("BMW", "3", 10, fuelCapacity));

        }
        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void CarConstuctorShouldThrowArgumentExeptionIfRefuelConnotBeZeroOrNegative(double refuel)
        {
            //Arrage
            Car car = new Car("Vw", "Golf", 10, 100);

            //Act-Assert
            Assert.Throws<ArgumentException>(() => car.Refuel(refuel));

        }

        [Test]
        [TestCase(100, 50, 50)]
        [TestCase(200, 350, 200)]
        public void RefuelShouldWorkIfIsValid(double capacity, double refuel, double expResult)
        {
            //Arrage
            Car car = new Car("Vw", "Golf", 10, capacity);
            car.Refuel(refuel);


            //Act-Assert
            var actualResult = car.FuelAmount;

            Assert.AreEqual(expResult, actualResult);

        }

        [Test]
        [TestCase(10, 50, 505)]
        [TestCase(15, 30, 201)]
        public void DriveShouldThrowsExceptionIfFuelAmountNotEnough(double fuelConsumption, double refuel, double distance)
        {
            //Arrage
            Car car = new Car("Vw", "Golf", fuelConsumption, 100);
            car.Refuel(refuel);


            //Act-Assert
            var actualResult = car.FuelAmount;

            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));

        }

        [Test]
        [TestCase(10, 100, 100, 50, 95)]
        public void DriveShouldFuelBaseOnDrivenKm(double fuelConsumption, double fuelCapacity, double refuel ,double distance , double expFuel)
        {
            //Arrage
            Car car = new Car("Vw", "Golf", fuelConsumption, fuelCapacity);
            car.Refuel(refuel);


            //Act-Assert
            car.Drive(distance);

            var expValue =expFuel;
            var actualResult = car.FuelAmount;

            Assert.AreEqual(expValue, actualResult);

        }
    }
}