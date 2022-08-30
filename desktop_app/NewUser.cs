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
    public partial class NewUser : Form
    {
        private readonly ManageUsers _parent;
        public string Username, UserID, UserPassword,UserRole  ;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Trim().Length < 3)
            {

                MessageBox.Show("Enter Valid username");
                return;
            }
            if (AddButton.Text == "Add")
            {
                User user = new User(null, UsernameTextBox.Text.Trim(), PasswordTextBox.Text.Trim(), RoleTextBox.Text.Trim());
                DbUser.AddUser(user);
                Clear();
            }
            if (AddButton.Text == "Update")
            {
                User user = new User(IDTextBox.Text.Trim(),  UsernameTextBox.Text.Trim(), PasswordTextBox.Text.Trim(), RoleTextBox.Text.Trim());
                DbUser.UpdateUser(user, IDTextBox.Text.Trim());
            }
            this.Close();
            _parent.Display();
        }

        public NewUser(ManageUsers parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Clear()
        {
            IDTextBox.Text = string.Empty;
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            RoleTextBox.Text = string.Empty;

        }
        public void UpdateInfo()
        {
            header.Text = "Update Items";
            AddButton.Text = "Update";
            UsernameTextBox.Text = Username;
            PasswordTextBox.Text = UserPassword;
            IDTextBox.Text = UserID;
            RoleTextBox.Text = UserRole;

            

        }
    }
}
