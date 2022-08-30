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
    public partial class NewCategory : Form
    {
        private readonly ManageCategories _parent;
        public string Category_Name, Category_ID;       
        public NewCategory(ManageCategories parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            idTextBox.Text = string.Empty;
            txtCat.Text = string.Empty;
        }
        public void UpdateInfo()
        {
            label1.Text = "Update Category";
            addCatBtn.Text = "Update";
            txtCat.Text = Category_Name;
            idTextBox.Text = Category_ID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCat.Text.Trim().Length < 3)
            {
             
                MessageBox.Show("Enter Valid Category Name");
                return;
            }
            if(addCatBtn.Text == "Add")
            {
                Category cat = new Category(null, txtCat.Text.Trim());
                DbCategory.AddCategory(cat);
                Clear();
            }if (addCatBtn.Text == "Update")
            {
                Category cat = new Category(idTextBox.Text.Trim(), txtCat.Text.Trim());
                DbCategory.UpdateCategory(cat, idTextBox.Text.Trim());
            }
            this.Close();
            _parent.Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
