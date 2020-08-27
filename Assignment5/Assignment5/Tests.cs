using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class Tests
    {
        Character character;
        Inventory inventory;
        int slots = 10;

        [SetUp]
        public void Setup()
        {
            character = new Character("Razia", RaceCatagory.Human, 100);
            inventory = new Inventory(slots);
        }

        [Test]
        public void Character_TakeDamage()
        {
            // store current health before method
            int temp = character.HealthPoints;
            int damage = 10;

            // take damage
            character.TakeDamage(damage);
            
            // compare current health and expected health
            Assert.AreEqual(character.HealthPoints, temp - damage);
        }

        [Test]
        public void Character_Restore()
        {
            // store current health before method
            int temp = character.HealthPoints;
            int restore = 7;

            // restore health
            character.RestoreHealth(restore);

            // compare current health and expected health
            Assert.AreEqual(character.HealthPoints, temp + restore);
        }

        [Test]
        public void Inventory_Add()
        {
            // add item, slots should reduce by 1
            Item sword = new Item("sword", 1, ItemType.equipment);
            inventory.Add(sword);

            // remaining slots should be 9
            Assert.IsTrue(inventory.slotsRemaining == slots - 1);
        }

        [Test]
        public void Inventory_Remove()
        {
            // add 2 items, slots should reduce by 2
            Item sword = new Item("sword", 1, ItemType.equipment);
            inventory.Add(sword);

            Item shield = new Item("shield", 1, ItemType.equipment);
            inventory.Add(shield);

            // remove 1 item, slots should increase by 1
            inventory.Remove(sword);

            // remaining slots should be 9
            Assert.IsTrue(inventory.slotsRemaining == slots - 1);
        }
    }
}
