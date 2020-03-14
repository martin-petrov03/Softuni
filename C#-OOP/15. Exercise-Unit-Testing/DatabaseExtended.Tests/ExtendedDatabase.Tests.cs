using System;
using ExtendedDataStorage;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldBeInitializedWith16Elements()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert.AreEqual(0, db.Count);
        }

        [Test]
        public void ConstructorShouldBeInitializedWithGivenPeople()
        {
            Person[] array = new Person[]
            {
                new Person(123321, "dsad")
            };

            ExtendedDatabase db = new ExtendedDatabase(array);

            Assert.AreEqual(1, db.Count);
        }

        [Test]
        public void ConstructorShouldThrowArgumentException()
        {
            Person[] array = new Person[17];

            Assert
                .Throws<ArgumentException>(() =>
                {
                    ExtendedDatabase db = new ExtendedDatabase(array);
                });
        }

        [TestCase(1, "aaa", 2, "aaa")]
        [TestCase(1, "aaa", 1, "bbb")]
        [TestCase(1, "aaa", 1, "aaa")]
        public void AddMethodShouldThrowInvalidOperationException(long id1, string userName1, long id2, string userName2)
        {
            Person[] array = new Person[]
            {
                new Person(id1, userName1)               
            };

            ExtendedDatabase db = new ExtendedDatabase(array);
            
            Assert
                .Throws<InvalidOperationException>(() => db.Add(new Person(id2, userName2)));
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationException()
        {
            Person[] array = new Person[16]
            {
                new Person(01, "dsad1"),
                new Person(02, "dsad2"),
                new Person(03, "dsad3"),
                new Person(04, "dsad4"),
                new Person(05, "dsad5"),
                new Person(06, "dsad6"),
                new Person(07, "dsad7"),
                new Person(08, "dsad8"),
                new Person(09, "dsad9"),
                new Person(10, "dsad10"),
                new Person(11, "dsad11"),
                new Person(12, "dsad12"),
                new Person(13, "dsad13"),
                new Person(14, "dsad14"),
                new Person(15, "dsad15"),
                new Person(16, "dsad16")
            };

            ExtendedDatabase db = new ExtendedDatabase(array);

            Assert
                .Throws<InvalidOperationException>(() => db.Add(new Person(17, "aaa")));
        }

        [Test]
        public void RemoveMethodShouldDeleteLastElement()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            db.Add(new Person(1, "a"));
            db.Add(new Person(2, "aa"));
            db.Remove();

            Assert.AreEqual(1, db.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowInvalidOperationException()
        {
            ExtendedDatabase db = new ExtendedDatabase();                        

            Assert
                .Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void FindByUsernameMethodShouldReturnTheUser()
        {
            Person person = new Person(1, "a");
            ExtendedDatabase db = new ExtendedDatabase();

            db.Add(person);

            Assert.AreEqual(person, db.FindByUsername("a"));
        }

        [Test]
        public void FindByUsernameMethodShouldThrowArgumentNullException()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert
                .Throws<ArgumentNullException>(() => db.FindByUsername(null));
        }

        [Test]
        public void FindByUsernameMethodShouldThrowInvalidOperationException()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert
                .Throws<InvalidOperationException>(() => db.FindByUsername("a"));
        }

        [Test]
        public void FindByIdMethodShouldReturnTheUser()
        {
            Person person = new Person(1, "a");
            ExtendedDatabase db = new ExtendedDatabase();

            db.Add(person);

            Assert.AreEqual(person, db.FindById(1));
        }

        [Test]
        public void FindByIdMethodShouldThrowArgumentOutOfRangeException()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert
                .Throws<ArgumentOutOfRangeException>(() => db.FindById(-1));
        }

        [Test]
        public void FindByIdMethodShouldThrowInvalidOperationException()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert
                .Throws<InvalidOperationException>(() => db.FindById(1));
        }
    }
}