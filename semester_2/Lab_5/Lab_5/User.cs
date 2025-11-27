using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class User
    {
        public string? Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }

        public User() { }

        public User(string username, string password, string email, int age, string gender)
        {
            Username = username;
            PasswordHash = password;
            Email = email;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Username},{PasswordHash},{Email}";
        }
    }
}
