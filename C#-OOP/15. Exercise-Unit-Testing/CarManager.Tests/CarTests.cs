using System;
using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateCarSuccessfully()
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }

        [TestCase(null, "Golf", 2, 100)]
        [TestCase("VW", null, 2, 100)]
        [TestCase("VW", "Golf", null, 100)]
        [TestCase("VW", "Golf", 2, null)]
        [TestCase("VW", "Golf", 0, 100)]
        [TestCase("VW", "Golf", -12, 100)]
        [TestCase("VW", "Golf", 2, 0)]
        [TestCase("VW", "Golf", 2, -1)]
        [TestCase("VW", "Golf", 0, 0)]
        [TestCase("VW", "Golf", -1, -1)]
        public void ModelShouldThrowArgumentException(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert
                .Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void ShouldRefuelNormally()
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(10);

            Assert.AreEqual(10, car.FuelAmount);
        }

        [TestCase(100)]
        [TestCase(101)]
        public void ShouldRefuelUntilTheTotalFuelCapacity(double fuelToRefuel)
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuelToRefuel);

            Assert.AreEqual(100, car.FuelAmount);
        }

        [TestCase(0)]
        [TestCase(-100)]        
        public void RefuelShouldThrowArgumentExceptionWhenInputAmountIsBellowOrEqualZero(double fuelToRefuel)
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert
                .Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }       

        [Test]
        public void ShouldDriveNormally()
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(50);
            car.Drive(50);

            Assert.AreEqual(49, car.FuelAmount);
        }

        [Test]
        public void DriveShouldThrowArgumentExceptionWhenFuelAmountIsNotEnough()
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert
                .Throws<InvalidOperationException>(() => car.Drive(50));
        }
    }
}