using MySql.Data.MySqlClient; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app
{
    class DbCategory
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "server = localhost; userid = root; password = Stevedabest10!; database= inventory;";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("My SQL Connection \n" +ex.Message, "Error");

            }
           return conn;

        }

        public static void AddCategory(Category cat)
        {
            string sql = "INSERT INTO categories VALUES (NULL, @Category_Name)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Category_Name", MySqlDbType.VarChar).Value = cat.Category_Name;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
            }
            catch(MySqlException ex )
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        
        public static void UpdateCategory(Category cat, string id)
        {
            string sql = "UPDATE categories SET category_name = @Category_Name WHERE category_id = @Category_ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Category_Name", MySqlDbType.VarChar).Value = cat.Category_Name;
            cmd.Parameters.Add("@Category_ID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public static void DeleteCategory(String id)
        {
            string sql = "DELETE FROM categories WHERE category_id = @Category_ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Category_ID", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb2 = new DataTable();
            adp.Fill(tb2);
            dgv.DataSource = tb2;
            con.Close();


        }


    }
}
