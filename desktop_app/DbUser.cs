using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app
{
    internal class DbUser
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

        public static void AddUser(User user)
        {
            string sql = "INSERT INTO users VALUES (NULL, @Username, @UserPassword, @UserRole)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = user.Username;
            cmd.Parameters.Add("@UserPassword", MySqlDbType.VarChar).Value = hashPassword(user.UserPassword);
            cmd.Parameters.Add("@UserRole", MySqlDbType.VarChar).Value = user.UserRole;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public static void UpdateUser(User user, string id)
        {
            string sql = "UPDATE users SET username = @Username, user_password = @UserPassword, role = @UserRole WHERE user_id = @UserID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = user.Username;
            cmd.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@UserRole", MySqlDbType.VarChar).Value = user.UserRole;
            cmd.Parameters.Add("@UserPassword", MySqlDbType.VarChar).Value = hashPassword( user.UserPassword);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
            }
            catch (MySqlException ex) { 
          
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public static void DeleteUser(String id)
        {
            string sql = "DELETE FROM usere WHERE user_id = @UserID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = id;


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
        public static string hashPassword(string password)
        {
            var sha = SHA256.Create();

            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);

        }

    }
}
