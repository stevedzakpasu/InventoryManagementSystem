using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace desktop_app
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; userid = root; password = Stevedabest10!; database= inventory;");
        MySqlCommand cmd;
        
       



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username, userPassword, admin, user;
            username = usernameTextBox.Text;
            userPassword = hashPassword( passwordTextBox.Text);
            admin = "admin";
            user = "user";

            try
            {

                string query = "SELECT * FROM users WHERE username = '"+username+"' AND user_password = '"+userPassword+"' AND role = '"+admin+"'";
                string query2 = "SELECT * FROM users WHERE username = '" + username + "' AND user_password = '" + userPassword + "' AND role = '"+user+"'";
                conn.Open();
                MySqlCommand get_usernames = new MySqlCommand(query, conn);
                MySqlCommand get_usernames2 = new MySqlCommand(query2, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, conn);
                DataTable dTable = new DataTable();
                DataTable dTable2 = new DataTable();
                adapter.Fill(dTable);
                adapter2.Fill(dTable2);

              if(dTable.Rows.Count > 0)
                {
                    username = usernameTextBox.Text;
                    userPassword = hashPassword (passwordTextBox.Text);
                    AdminDashboard dashboard = new AdminDashboard();
                    this.Hide();
                    dashboard.Show();

                    
                }
              else if (dTable2.Rows.Count > 0)
                {
                    username = usernameTextBox.Text;
                    userPassword = hashPassword(passwordTextBox.Text);
                    AttendantDashboard dashboard = new AttendantDashboard();
                    this.Hide();
                    dashboard.Show();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public static string hashPassword(string password)
        {
            var sha = SHA256.Create();

            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}

