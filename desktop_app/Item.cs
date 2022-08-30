using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app
{
    internal class Item
    {
        public Item(string item_ID, string item_Name, string item_Category, string item_Price, string item_Stock, string item_Reorder)
        {
            Item_ID = item_ID;
            Item_Name = item_Name;
            Item_Category = item_Category;
            Item_Price = item_Price;
            Item_Stock = item_Stock;
            Item_Reorder = item_Reorder;
        }

        public string Item_ID { get; set; }
        public string Item_Name { get; set; }
        public string Item_Category { get; set; }
        public string Item_Price { get; set; }
        public string Item_Stock { get; set; }
        public string Item_Reorder { get; set; }

    }
}
