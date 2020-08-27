using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5");

            Character myCharacter = new Character("Razia", RaceCatagory.Elf, 100);

            myCharacter.TakeDamage(10);

            myCharacter.RestoreHealth(10);

            // create inventory and add items
            Inventory inventory = new Inventory(10);
            Item sword = new Item("sword", 1, ItemType.equipment);
            inventory.Add(sword);

            Item shield = new Item("shield", 1, ItemType.equipment);
            inventory.Add(shield);

            Item potion = new Item("potion", 5, ItemType.consumable);
            inventory.Add(potion);

            Item bosskey = new Item("bosskey", 1, ItemType.key);
            inventory.Add(bosskey);

            // remove potion
            inventory.Remove(potion);
            
            // show inventory
            inventory.ShowInventory();

            Console.WriteLine("\nThe game has ended with {0} with {1} health", myCharacter.Name, myCharacter.HealthPoints);
        }
    }
}
