using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.LILO
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } 
        public DateTime RegistrationDate { get; set; }
    }

    

    public class UserManager
    {
        private static UserManager _instance;

        public static UserManager Instance()
        {
            if (_instance is null)
                _instance = new UserManager();
            return _instance;
        
        }   

        private UserManager() 
        {

        }

        public async Task SaveUserToFile(User user)
        {
            var jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json");

            try
            {
                File.Delete(jsonFilePath);

                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(user, jsonOptions);

                File.WriteAllText(jsonFilePath, json);
                Console.WriteLine($"User {user.Email} saved to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user: {ex.Message}");
            }
        }

        public User LoadUserFromFile(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonSerializer.Deserialize<User>(json) ?? new User();
            }
            return new User();
        }
    }
}
