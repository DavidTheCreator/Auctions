using Auctions.Models.Database;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Models.Initializers {
    public class UserInitializer {
        public static string[][] users = new string[][] {
            new string[] { "David", "Stanimirovic", "davidstanimirovic@gmail.com", "Male", "davidstanimirovic", "david123" },
            new string[] { "Marko", "Stefanovic", "markostefanovic@gmail.com", "Male", "markostefanovic", "marko123" },
            new string[] { "Jovana", "Stojanovic","jovanastojanovic@gmail.com", "Female", "jovanastojanovic", "jovana123" },
            new string[] { "Marina", "Velickovic", "marinavelickocic@gmail.com", "Female",  "marinavelickocic", "marin123" },
        };

        private static string[] admin = new string [] {
            "Admin", "Admin", "admin@microsoft.com", "Male", "admin", "admin123"
        };

        private static bool addUser(string[] row, UserManager<User> user_manager, string role) {
            string first_name = row[0];
            string last_name = row[1];
            string email = row[2];
            string gender = row[3];
            string username = row[4];
            string password = row[5];

            if(user_manager.FindByNameAsync(username).Result != null) {
                return false;
            }

            User user = new User() {
                first_name = first_name,
                last_name = last_name,
                Email = email,
                gender = gender,
                UserName = username
            };

            var result = user_manager.CreateAsync(user, password).Result;
            if(!result.Succeeded) {
                return false;
            }

            result = user_manager.AddToRoleAsync(user, role).Result;

            if(!result.Succeeded) {
                return false;
            }

            return true;
        }

        public static void initialize (UserManager<User> user_manager) {
            foreach(string[] row in UserInitializer.users) {
                bool result = addUser(row, user_manager, Roles.user.Name);
                if(!result) {
                    return;
                }
            }

            addUser(UserInitializer.admin, user_manager, Roles.admin.Name);
        }
    }
}