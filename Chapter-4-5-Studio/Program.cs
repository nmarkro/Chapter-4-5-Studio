using Chapter_4_5_Studio;
using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddNewItem(new MenuItem("Chips", "Fried Potato Chips", "Appetizer", 5.00, false));
            menu.AddNewItem(new MenuItem("Steak", "Grilled steak", "Main Course", 15.00, false));
            menu.AddNewItem(new MenuItem("Ice Cream", "Chocolate or Vanilla Ice Cream", "Desert", 8.00, true));

            Console.WriteLine(menu.PrintFullMenu() + "\n");
            Console.WriteLine(menu.PrintItem("Steak") + "\n");

            menu.RemoveItem("Chips");
            Console.WriteLine(menu.PrintFullMenu());
        }
    }
}
