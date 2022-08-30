using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app
{
    internal class User
    {
        public User(string userID, string username, string userPassword, string userRole)
        {
            UserID = userID;
            Username = username;
            UserPassword = userPassword;
            UserRole = userRole;
        }

        public string UserID { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }

    }
}
