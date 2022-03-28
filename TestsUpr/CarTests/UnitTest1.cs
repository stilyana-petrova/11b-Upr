using CarManager;
using NUnit.Framework;
using System;

namespace CarTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            Car car = new Car("car", "BMW", 12.5, 20.0);
            Assert.IsTrue(true);
        }
        [Test]
        public void ModelShouldThrowArgExWhenNameIsNull()
        {           
            var ex = Assert.Throws<ArgumentException>(() => new Car("car", null, 12.5, 20.0));

            Assert.That(ex.Message, Is.EqualTo("Model cannot be null or empty"));
        }
        [Test]
        public void MakeShouldThrowArgExWhenNameIsNull()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car(null, "BMW", 12.5, 20.0));

            Assert.That(ex.Message, Is.EqualTo("Make cannot be null or empty"));
        }
        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car("car", "BMW", -12.2, 20.0));

            Assert.That(ex.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }
        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsZero()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car("car", "BMW", 0, 20.0));

            Assert.That(ex.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }
        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsZero()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car("car", "BMW", 12.5, 0));

            Assert.That(ex.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }
        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car("car", "BMW", 12.5, -20.5));

            Assert.That(ex.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }
        
        [Test]
        [TestCase(null, "BMW", 12.5, 20.5)]
        [TestCase("car", null, 12.5, 20.5)]
        [TestCase("car", "BMW", 0, 20.5)]
        [TestCase("car", "BMW", -12.5, 20.5)]
        [TestCase("car", "BMW", 12.5, 0)]
        [TestCase("car", "BMW", 12.5, -20.5)]
        public void ValidateAllProperties(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void ShouldRefuelNormally()
        {
            Car car = new Car("car", "BMW", 12.5, 20.0);
           car.Refuel(20);
            double expectedFuelAmount = 20;
            double actualFuelFuelAmount = car.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualFuelFuelAmount);
        }

        [Test]
        public void ShouldRefuelUntilTotalFuelCapacity()
        {
            Car car = new Car("car", "BMW", 12.5, 100);
            car.Refuel(150);
            double expectedFuelAmount = 100;
            double actualFuelFuelAmount = car.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualFuelFuelAmount);
        }

        [Test]
        [TestCase(-10)]
        [TestCase(0)]
        public void ShouldRefuelThrowArgExWhenInputAmountIsBellowZero(double inputAmount)
        {
            Car car = new Car("car", "BMW", 12.5, 100);
            Assert.Throws<ArgumentException>(() => car.Refuel(inputAmount));
        }

        [Test]
        public void ShouldDriveNormally()
        {
            Car car = new Car("car", "BMW", 2, 100);
            car.Refuel(20);
            car.Drive(20);
            double expectedFuelAmount = 19.6;
            double actualFuelFuelAmount = car.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualFuelFuelAmount);
        }
        [Test]
        public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
        {
            Car car = new Car("car", "BMW", 2, 100);
            Assert.Throws < InvalidOperationException>(() => car.Drive(20));
        }
    }
}