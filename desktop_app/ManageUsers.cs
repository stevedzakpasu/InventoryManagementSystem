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
    public partial class ManageUsers : UserControl
    {
        NewUser form;

        public void Display()
        {
            DbCategory.DisplayAndSearch("SELECT * FROM users", dataGridView4);

        }
        public ManageUsers()
        {
            InitializeComponent();
            form = new NewUser(this);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbUser.DisplayAndSearch("SELECT * FROM users WHERE username LIKE'%" + textBox1.Text + "%'", dataGridView4);
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbUser.DeleteUser(dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
            if (e.ColumnIndex == 1)
            {
                form.Clear();
                form.UserID = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.UserPassword = dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.Username = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.UserRole = dataGridView4.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();

                return;
            }
        }
    }
}
