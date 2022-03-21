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
        
    }
}