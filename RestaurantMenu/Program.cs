using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MenuItem item1 = new MenuItem(18.99, "Chicken Biryani", "Entree", true);
            MenuItem item2 = new MenuItem(17.99, "Sambar Rice", "Entree", true);
        }
    }
}
