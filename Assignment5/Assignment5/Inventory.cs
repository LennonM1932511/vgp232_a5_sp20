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
                Console.WriteLine($"Name: {item.Name}\tMod: {item.Modifier}\tType: {item.IType}");
            }            
            //throw new NotImplementedException();
        }
    }
}
