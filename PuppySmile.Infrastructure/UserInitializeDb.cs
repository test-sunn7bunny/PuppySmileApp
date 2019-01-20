using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class UserInitializeDb : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            //password = Base64 encoded "testpw"
            context.Users.Add(new User
            {
                UserId = 1,
                Name = "Admin",
                Email = "admin@test.org",
                Password = "dGVzdHB3",
                ConfirmPassword = "dGVzdHB3"
            });
            context.Users.Add(new User
            {
                UserId = 2,
                Name = "Pups Buds",
                Email = "admin@pb.org",
                Password = "dGVzdHB3",
                ConfirmPassword = "dGVzdHB3"
            });
            context.Users.Add(new User
            {
                UserId = 4,
                Name = "Pups for Hugs",
                Email = "admin@pfg.org",
                Password = "dGVzdHB3",
                ConfirmPassword = "dGVzdHB3"
            });
            context.Users.Add(new User
            {
                UserId = 6,
                Name = "Helga Swan",
                Email = "helga@sunn7y.com",
                Password = "dGVzdHB3",
                ConfirmPassword = "dGVzdHB3"
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}