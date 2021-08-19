using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNewItemAdded { get; set; }

        public MenuItem(double price,string description,string category,bool isnewItemAdded)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNewItemAdded = isnewItemAdded;
        }

        public string NewItem()
        {
            if (IsNewItemAdded)
            {
                return ("This item added is new.");
            }
            else 
            {
                return ("The added item is not new.");
            }
       }

       // public override bool Equals(object obj)
        //{
           //if(obj == this)
            //{
                //return true;
            //}
           //if
        }
    }

