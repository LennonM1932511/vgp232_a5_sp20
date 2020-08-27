using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {        
        List<Item> items;
        public int slotsRemaining;

        public Inventory(int slots)            
        {
            items = new List<Item>(slots);
            slotsRemaining = slots;
        }

        public void Add(Item item)
        {
            if (slotsRemaining == 0)
            {
                Console.WriteLine("Inventory Full");
                return;
            }
            items.Add(item);
            --slotsRemaining;
            Console.WriteLine("{0} added to inventory.", item.Name);

            //throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            items.Remove(item);
            ++slotsRemaining;
            Console.WriteLine("{0} removed from inventory.", item.Name);

        }

        public void ShowInventory()
        {
            Console.WriteLine("\n===INVENTORY===");

            foreach (var item in items)
            {
                Console.WriteLine(">{0}, Mod: {1} ({2})", item.Name, item.Modifier, item.IType);
            }            
        }
    }
}
