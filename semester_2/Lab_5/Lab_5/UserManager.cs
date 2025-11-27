using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_5
{
    public class UserManager
    {
        public Dictionary<string, User> Users { get; set; } = new();

        private const string FilePath = "users.json";

        public UserManager()
        {
            LoadUsersFromFileJson();
        }
        public void SaveUsersToFileJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            try
            {
                var json = JsonSerializer.Serialize(Users, options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in saving!!!: {ex.Message}");
            }
        }
        public void LoadUsersFromFileJson()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    var json = File.ReadAllText(FilePath);
                    var loadedUsers = JsonSerializer.Deserialize<Dictionary<string, User>>(json);

                    if (loadedUsers != null)
                    {
                        Users = loadedUsers;
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Error in loading: {ex.Message}");
                    Users = new Dictionary<string, User>();
                }
            }
        }
        public static string GenerateSalt(int length = 32)
        {
            byte[] saltBytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        public static string HashPassword(string password, string salt)
        {
            string saltedPassword = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(bytes);
            }
        }
        public void AddUser(User user)
        {
            Users[user.Username.ToLower()] = user;
        }

        public bool CheckCredentials(string username, string password)
        {
            if (Users.TryGetValue(username.ToLower(), out User user))
            {
                string enteredHash = HashPassword(password, user.Salt);
                return enteredHash.Equals(user.PasswordHash, StringComparison.Ordinal);
            }
            return false;
        }
    }
}