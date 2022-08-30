using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app
{
    internal class Category
    {
        public Category(string category_ID, string category_Name)
        {
            Category_ID = category_ID;
            Category_Name = category_Name;
        }

        public string Category_ID { get; set; }
        public string Category_Name { get; set; }
    }
}
