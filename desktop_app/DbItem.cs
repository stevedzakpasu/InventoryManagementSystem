using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace desktop_app
{
    class DbItem
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "server = localhost; userid = root; password = Stevedabest10!; database= inventory;";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("My SQL Connection \n" + ex.Message, "Error");

            }
            return conn;

        }


        public static void AddItem(Item item)
        {
            string sql = "INSERT INTO items VALUES (NULL, @Item_Name, @Item_Category, @Item_Price, @Item_Stock, @Item_Reorder)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Item_Name", MySqlDbType.VarChar).Value = item.Item_Name;
            cmd.Parameters.Add("@Item_Category", MySqlDbType.VarChar).Value = item.Item_Category;
            cmd.Parameters.Add("@Item_Price", MySqlDbType.VarChar).Value = item.Item_Price;
            cmd.Parameters.Add("@Item_Stock", MySqlDbType.VarChar).Value = item.Item_Stock;
            cmd.Parameters.Add("@Item_Reorder", MySqlDbType.VarChar).Value = item.Item_Reorder;

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

        public static void UpdateItem(Item item, string id)
        {
            string sql = "UPDATE items SET item_name = @Item_Name, item_category = @Item_Category, item_price = @Item_Price, available_stock = @Item_Stock, reorder_level = @Item_Reorder WHERE item_id = @Item_ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Item_Name", MySqlDbType.VarChar).Value = item.Item_Name;
            cmd.Parameters.Add("@Item_ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Item_Category", MySqlDbType.VarChar).Value = item.Item_Category;
            cmd.Parameters.Add("@Item_Price", MySqlDbType.VarChar).Value = item.Item_Price;
            cmd.Parameters.Add("@Item_Stock", MySqlDbType.VarChar).Value = item.Item_Stock;
            cmd.Parameters.Add("@Item_Reorder", MySqlDbType.VarChar).Value = item.Item_Reorder;

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

        public static void DeleteItem(String id)
        {
            string sql = "DELETE FROM items WHERE item_id = @Item_ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Item_ID", MySqlDbType.VarChar).Value = id;

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
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dgv.DataSource = tb1;
            con.Close();


        }



    }
}
