using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class AdminInitializeDb : DropCreateDatabaseIfModelChanges<AdminContext>
    {
        protected override void Seed(AdminContext context)
        {
            context.Admins.Add(new Admin
            {
                AdminId = 1,
                UserId = 1,
            });
            context.SaveChanges();

            base.Seed(context);
        }

    }
}