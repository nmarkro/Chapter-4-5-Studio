using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_4_5_Studio
{
    class Menu
    {
        public Dictionary<string, MenuItem> MenuItems { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu()
        {
            MenuItems = new Dictionary<string, MenuItem>();
            LastUpdated = DateTime.Now;
        }

        public Menu(Dictionary<string, MenuItem> menuItems)
        {
            MenuItems = menuItems;
            LastUpdated = DateTime.Now;
        }

        public void AddNewItem(MenuItem newItem)
        {
            MenuItems.Add(newItem.Name, newItem);
            LastUpdated = DateTime.Now;
        }

        public void RemoveItem(string name)
        {
            MenuItems.Remove(name);
            LastUpdated = DateTime.Now;
        }

        public string PrintItem(string name)
        {
            return MenuItems[name].ToString();
        }

        public string PrintFullMenu()
        {
            string retMessage = "";
            foreach (KeyValuePair<string, MenuItem> item in MenuItems)
            {
                retMessage += (item.Value.IsNew ? "*NEW* " : "") + item.Value.ToString() + "\n";
            }
            retMessage += "Last Updated: " + LastUpdated.ToString();
            return retMessage;
        }
    }
}
