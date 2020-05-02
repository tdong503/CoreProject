using System.Collections.Generic;

namespace CoreProject.Models
{
    public class UserContextSeeder
    {
        public static void Seed(UserContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var users = new List<User>
            {
                new User { UserName = "Tom" },
                new User { UserName = "Mary" }
            };
            
            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}