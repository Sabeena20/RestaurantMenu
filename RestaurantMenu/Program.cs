using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MenuItem item1 = new MenuItem(18.99, "Chicken Biryani", "Entree", true);
            MenuItem item2 = new MenuItem(17.99, "Sambar Rice", "Entree", true);

            DateTime today = DateTime.Now;
            System.Collections.Generic.List<MenuItem> menu = new List<MenuItem>();

            Menu foodMenu = new Menu(today, menu);

            foodMenu.PrintMenu();
            foodMenu.PrintItem(item2);
            foodMenu.PrintItem(item1);
        }
    }
}
