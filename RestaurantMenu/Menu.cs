using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime d, List<MenuItem> i)
        {
            LastUpdated = d;
            Items = i;
            
        }
    }
}
