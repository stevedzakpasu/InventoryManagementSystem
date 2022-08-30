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
    public partial class ManageItems : UserControl
    {
        NewItem form;
        public void Display()
        {
            DbCategory.DisplayAndSearch("SELECT * FROM items", dataGridView2);

        }
        public ManageItems()
        {
            InitializeComponent();
            form = new NewItem(this);
        }

        private void manageCategories1_Load(object sender, EventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DbCategory.DisplayAndSearch("SELECT * FROM items WHERE item_name LIKE'%" + searchBox.Text + "%'", dataGridView2);
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbItem.DeleteItem(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
            if (e.ColumnIndex == 3)
            {
                form.Clear();
                form.Item_ID = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.Item_Name = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.Item_Category = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.Item_Price = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.Item_Stock = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.Item_Reorder = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();


                return;
            }
        }
    }
}
