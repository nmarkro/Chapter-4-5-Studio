using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter_4_5_Studio
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, string description, string category, double price, bool isNew)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            IsNew = isNew;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                Name == item.Name &&
                Description == item.Description &&
                Category == item.Category &&
                Price == item.Price &&
                IsNew == item.IsNew;
        }

        public override string ToString()
        {
            return Category + ": " + Name + " - " + Description + " - $" + Price; 
        }
    }
}
