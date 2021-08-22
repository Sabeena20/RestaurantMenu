using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            Items = item;
            LastUpdated = dateUpdated;
            
        }

        public List<MenuItem> AddItem(MenuItem item)
        {
            Items.Add(item);
            return Items;
        }

        public List<MenuItem> RemoveItem(MenuItem item)
        {
            int itemsToBeRemoved = -1;
            for(int i = 0;i < Items.Count; i++)
            {
                if (Items[i].Equals(item))
                {
                    itemsToBeRemoved = i;
                }
              }
            Items.RemoveAt(itemsToBeRemoved);
            return Items;
        }
        public string MenuUpdate()
        {
            return ("The menu was updated on " + LastUpdated);
        }

        public void PrintItem(MenuItem item)
        {
            Console.WriteLine(item.Description);

        }

        public void PrintMenu()
        {
            for(int i = 0;i < Items.Count; i++)
            {
                Console.WriteLine(Items[i].Description);
            }
        }
    }
}
