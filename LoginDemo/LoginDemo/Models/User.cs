using System;
using SQLite;

namespace LoginDemo.Models
{
    public class User
    {
        [PrimaryKey]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User () {}
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation() 
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
