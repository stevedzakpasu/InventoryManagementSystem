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
    public partial class ManageCategories : UserControl
    {
        NewCategory form;
        public void Display()
        {
            DbCategory.DisplayAndSearch("SELECT category_id, category_name FROM categories", dataGridView1);

        }
        public ManageCategories()
        {
            InitializeComponent();
            form = new NewCategory(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form.Clear();
            form.ShowDialog();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Display();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            DbCategory.DisplayAndSearch("SELECT category_id, category_name FROM categories WHERE category_name LIKE'%"+searchBox.Text+"%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this row?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    DbCategory.DeleteCategory(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }if (e.ColumnIndex == 1)
            {
                form.Clear();
                form.Category_Name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.Category_ID = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
               
                return;
            }
        }
    }
}
