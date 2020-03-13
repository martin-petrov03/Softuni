using System;
using DataStorage;
using NUnit.Framework;

namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldBeInitializedWith16Elements()
        {
            int[] array = new int[16];
            Database db = new Database(array);

            Assert.AreEqual(16, db.Count);            
        }

        [Test]
        public void ConstructorShouldThrowInvalidOperationException()
        {
            int[] array = new int[20];

            Assert
                .Throws<InvalidOperationException>(() =>
                {
                    Database db = new Database(array);
                });
        }

        [Test]
        public void AddMethodShouldAddCorrectlyAndIncreaseCount()
        {
            Database db = new Database();

            db.Add(12);
            db.Add(12);
            db.Add(12);

            Assert.AreEqual(3, db.Count);
        }

        [Test]
        public void AddMethodShouldAddOnTheNextEmptyIndex()
        {
            int[] array = { 1, 2, 3, 4 };
            Database db = new Database(array);

            db.Add(5);
            db.Add(6);
            db.Add(7);

            Assert.AreEqual(7, db.Count);
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationException()
        {
            int[] array = new int[16];
            Database db = new Database(array);

            Assert
                .Throws<InvalidOperationException>(() => db.Add(1));
        }

        [Test]
        public void RemoveMethodShouldRemoveCorrectlyLastElementAndDecreaseCount()
        {
            Database db = new Database();
            db.Add(1);
            db.Add(2);
            db.Add(3);
            db.Remove();

            Assert.AreEqual(2, db.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowInvalidOperationException()
        {
            Database db = new Database();

            Assert
                .Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void FetchShouldFetchDataCorrectly()
        {
            Database db = new Database();
            db.Add(1);
            db.Add(2);
            db.Add(3);
            db.Add(4);
            db.Remove();

            int[] expectedArray = { 1, 2, 3 };
            int[] actualArray = db.Fetch();

            Assert.AreEqual(expectedArray, actualArray);      
        }
    }
}