namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class SoftParkTest
    {
        private SoftPark softPark;

        [SetUp]
        public void Setup()
        {
            softPark = new SoftPark();
        }

        [Test]
        public void ConstructorShouldCreateTwelveEmptyParkingSpots()
        {
            Assert.That(softPark.Parking.Count, Is.EqualTo(12));
        }

        [Test]
        public void ConstructorShouldCreateCorrectSpots()
        {
            Dictionary<string, Car> myParking = new Dictionary<string, Car>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            foreach (var kvp in softPark.Parking)
            {
                Assert.That(myParking.ContainsKey(kvp.Key), Is.EqualTo(true));

                Assert.That(myParking[kvp.Key], Is.EqualTo(null));
            }
        }

        [Test]
        public void ParkingOnInvalidSpotShouldThrowException()
        {
            Assert.Throws<ArgumentException>(
                () => this.softPark.ParkCar("D1", new Car("BMW", "CBA321")));
        }

        [Test]
        public void ParkingOnTakenPlaceShouldThrowException()
        {
            this.softPark.ParkCar("A1", new Car("Audi", "ABC123"));

            Assert.Throws<ArgumentException>(
                () => this.softPark.ParkCar("A1", new Car("BMW", "CBA321")));
        }

        [Test]
        public void TryParkingSameCarOnAnotherSpotShouldThrowException()
        {
            Car car = new Car("BMW", "CBA321");
            this.softPark.ParkCar("A1", car);

            Assert.Throws<InvalidOperationException>(
                () => this.softPark.ParkCar("B1", car));
        }

        [Test]
        public void SuccessfulParkedCarShouldReturnMessage()
        {
            string regNum = "CBA321";
            Car car = new Car("BMW", regNum);

            string actualResult = this.softPark.ParkCar("A1", car);
            string expectedResult = $"Car:{regNum} parked successfully!";

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TryRemoveCarFromNonExistingSpotShouldThrowException()
        {
            Assert.Throws<ArgumentException>(
                () => this.softPark.RemoveCar("D1", new Car("Audi", "ABC123")));
        }

        [Test]
        public void TryRemoveCarFromWrongSpotShouldThrowException()
        {
            Assert.Throws<ArgumentException>(
                () => this.softPark.RemoveCar("A1", new Car("Audi", "ABC123")));
        }

        [Test]
        public void SuccessfulRemoveCarShouldReturnExpectedMessage()
        {
            Car car = new Car("Mazda", "ABC123");
            this.softPark.ParkCar("A1", car);

            string actualResult = this.softPark.RemoveCar("A1", car);
            string expectedResult = $"Remove car:{car.RegistrationNumber} successfully!";

            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Assert.That(this.softPark.Parking["A1"], Is.EqualTo(null));
        }
    }
}