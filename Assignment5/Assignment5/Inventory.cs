using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int slots;
        List<Item> items;

        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            items.Add(item);
            //throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            items.Remove(item);
            //throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Name: {0}\nMod: {1}\nType: {2}\n", item.Name, item.Modifier, item.IType);
            }            
            //throw new NotImplementedException();
        }
    }
}
