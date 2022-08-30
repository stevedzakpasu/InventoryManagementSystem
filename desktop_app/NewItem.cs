using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app
{
    public partial class NewItem : Form
    {

        private readonly ManageItems _parent;
        public string Item_Name, Item_ID, Item_Category, Item_Price, Item_Stock,Item_Reorder;

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length < 3)
            {

                MessageBox.Show("Enter Valid Item Name");
                return;
            }
            if (button.Text == "Add")
            {
                Item item = new Item(null, nameTextBox.Text.Trim(),categoryTextBox.Text.Trim(), priceTextBox.Text.Trim(), stockTextBox.Text.Trim(), reorderTextBox.Text.Trim());
                DbItem.AddItem(item);
                Clear();
            }
            if (button.Text == "Update")
            {
                Item item = new Item(idTextBox.Text.Trim(), nameTextBox.Text.Trim(), categoryTextBox.Text.Trim(), priceTextBox.Text.Trim(), stockTextBox.Text.Trim(), reorderTextBox.Text.Trim());
                DbItem.UpdateItem(item, idTextBox.Text.Trim());
            }
            this.Close();
            _parent.Display();

        }

        public NewItem(ManageItems parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            categoryTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            stockTextBox.Text = string.Empty;
            reorderTextBox.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            header.Text = "Update Item";
            button.Text = "Update";
            nameTextBox.Text = Item_Name;
            idTextBox.Text = Item_ID;
            priceTextBox.Text = Item_Price;
            categoryTextBox.Text = Item_Category;
            stockTextBox.Text = Item_Stock;
            reorderTextBox.Text = Item_Reorder;
        }



    }
}
