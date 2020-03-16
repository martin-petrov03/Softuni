using System;
using System.Collections.Generic;
//using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Warrior attacker;
        private Warrior defender;

        [SetUp]
        public void Setup()
        {
            attacker = new Warrior("a", 25, 35);
            defender = new Warrior("b", 20, 60);
        }

        [Test]
        public void ConstructorShouldInitializeTheWarriors()
        {
            Arena arena = new Arena();
            var list = new List<Warrior>();
            CollectionAssert.AreEqual(list, arena.Warriors);
        }

        [Test]
        public void ArenaShouldReturnCorrectEnrolledWarriors()
        {
            Arena arena = new Arena();
            arena.Enroll(attacker);
            arena.Enroll(defender);

            var expected = new List<Warrior> { attacker, defender };

            CollectionAssert.AreEqual(expected, arena.Warriors);
        }

        [Test]
        public void EnrollShouldAddTheWarrior()
        {
            Arena arena = new Arena();
            arena.Enroll(attacker);
            arena.Enroll(defender);

            Assert.AreEqual(2, arena.Count);
        }

        [Test]
        public void EnrollShouldThrowInvalidOperationException()
        {
            Arena arena = new Arena();
            arena.Enroll(attacker);

            Assert
                .Throws<InvalidOperationException>(() => arena.Enroll(attacker));
        }

        [Test]
        public void FightShouldThrowInvalidOperationExceptionWithNull()
        {            
            Arena arena = new Arena();
            arena.Enroll(attacker);
            arena.Enroll(defender);

            Assert
                .Throws<InvalidOperationException>(() => arena.Fight(null, "b"));
        }

        [Test]
        public void FightShouldThrowInvalidOperationException()
        {
            Arena arena = new Arena();
            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>
                (() => arena.Fight("a", "b"));
        }

        [Test]
        public void FightShouldThrowInvalidOperationExceptionWithInvalidWarrior()
        {       
            Arena arena = new Arena();
            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>
                (() => arena.Fight("a", "b"));
        }

        [Test]
        public void FightShouldFightCorrectly()
        {  
            Arena arena = new Arena();
            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight("a", "b");

            var expectedDefenderoHp = 35;
            var actual = defender.HP;

            Assert.AreEqual(expectedDefenderoHp, actual);
        }
    }
}
