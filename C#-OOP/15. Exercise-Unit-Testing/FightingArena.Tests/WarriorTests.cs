using System;
//using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(null, 100, 20)]
        [TestCase("", 100, 20)]
        [TestCase(" ", 100, 20)]
        [TestCase("  ", 100, 20)]
        [TestCase("a", 0, 20)]        
        [TestCase("a", -100, 20)]        
        [TestCase("a", 100, -20)]
        public void WarriorShouldThrowArgumentException(string name, int damage, int hp)
        {
            Assert
                .Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [TestCase(10)]
        [TestCase(29)]
        [TestCase(0)]
        public void WarriorAttackedWithLessThan30HpShouldThrowInvalidOperationException(int hp)
        {
            Warrior attacker = new Warrior("a", 10, 40);
            Warrior defender = new Warrior("b", 10, hp);

            Assert.Throws<InvalidOperationException>
                (() => attacker.Attack(defender));
        }
        
        [TestCase(50)]
        [TestCase(41)]
        public void AtackingStrongerOpponentShouldThrowInvalidOperationException(int damage)
        {
            Warrior attacker = new Warrior("a", 10, 40);
            Warrior defender = new Warrior("b", damage, 40);

            Assert.Throws<InvalidOperationException>
                (() => attacker.Attack(defender));
        }

        [TestCase(22, 40)]
        [TestCase(49, 40)]
        [TestCase(50, 40)]
        public void WarriorShoudAttackCorrectly(int damage, int hp)
        {
            Warrior attacker = new Warrior("a", damage, hp);
            Warrior defender = new Warrior("b", 20, 50);

            attacker.Attack(defender);

            int expected = 50 - damage;
            int actual = defender.HP;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(51, 40)]
        [TestCase(52, 40)]
        [TestCase(120, 40)]
        public void WarriorShoudAttackCorrectlyWithMoreDamage(int damage, int hp)
        {
            Warrior attacker = new Warrior("a", damage, hp);
            Warrior defender = new Warrior("b", 20, 50);

            attacker.Attack(defender);

            int expected = 0;
            int actual = defender.HP;

            Assert.AreEqual(expected, actual);
        }
    }
}