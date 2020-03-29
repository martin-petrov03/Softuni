namespace BlueOrigin.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private const string InitialName = "Battleship";
        private const int InitialCapacity = 5;

        private Spaceship spaceship;
        private List<Astronaut> astronauts;

        [SetUp]
        public void Setup()
        {            
            spaceship = new Spaceship(InitialName, InitialCapacity);
        }

        [Test]
        public void ConstructorShouldSetPropertiesCorrectly()
        {            
            Assert.That(spaceship.Name, Is.EqualTo(InitialName));
            Assert.That(spaceship.Capacity, Is.EqualTo(InitialCapacity));
            Assert.That(spaceship.Count, Is.EqualTo(0));
        }

        [Test]
        public void ShouldThrowExceptionWhenInvalidNameIsGiven()
        {
            Assert.Throws<ArgumentNullException>(() => new Spaceship(null, InitialCapacity));
        }

        [Test]
        public void ShouldThrowExceptionWhenInvalidCapacityIsGiven()
        {
            Assert.Throws<ArgumentException>(() => new Spaceship(InitialName, -11));
        }
        
        [Test]
        public void AddMethodShouldAddAstronautCorrectly()
        {
            Astronaut astronaut = new Astronaut("Tom", 41);
            spaceship.Add(astronaut);
            Assert.That(spaceship.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenTheAstronautIsAlreadyIn()
        {
            Astronaut astronaut = new Astronaut("Tom", 41);
            spaceship.Add(astronaut);
            Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut));
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenTheSpaceshipIsFull()
        {
            Astronaut astronaut1 = new Astronaut("Tom", 21);
            Astronaut astronaut2 = new Astronaut("John", 99);
            Astronaut astronaut3 = new Astronaut("Mike", 0);
            Astronaut astronaut4 = new Astronaut("Martin", 45);
            Astronaut astronaut5 = new Astronaut("Peter", 77);
            Astronaut astronaut6 = new Astronaut("George", 81);

            spaceship.Add(astronaut1);
            spaceship.Add(astronaut2);
            spaceship.Add(astronaut3);
            spaceship.Add(astronaut4);
            spaceship.Add(astronaut5);

            Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut6));
        }

        [Test]
        public void RemoveMethodShouldRemoveAstronautCorrectly()
        {
            Astronaut astronaut1 = new Astronaut("Tom", 41);
            Astronaut astronaut2 = new Astronaut("Mike", 0);

            spaceship.Add(astronaut1);
            spaceship.Add(astronaut2);
            spaceship.Remove(astronaut1.Name);

            Assert.That(spaceship.Remove(astronaut2.Name), Is.EqualTo(true));
            Assert.That(spaceship.Count, Is.EqualTo(0));
        }

        [Test]
        public void RemoveMethodShould()
        {            
            Assert.That(spaceship.Remove("Mike"), Is.EqualTo(false));            
        }
    }
}