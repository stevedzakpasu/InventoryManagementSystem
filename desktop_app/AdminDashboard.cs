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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            manageCategories1.Show();
            manageUsers1.Hide();
            manageProducts1.Hide();
            manageStocks1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            manageCategories1.Hide();
            manageUsers1.Show();
            manageProducts1.Hide();
            manageStocks1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageCategories1.Hide();
            manageUsers1.Hide();
            manageProducts1.Hide();
            manageStocks1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageCategories1.Hide();
            manageUsers1.Hide();
            manageProducts1.Show();
            manageStocks1.Hide();
        }

        private void manageCategories1_Load(object sender, EventArgs e)
        {

        }

        private void manageProducts1_Load(object sender, EventArgs e)
        {

        }
    }
}
