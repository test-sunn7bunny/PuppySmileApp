using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=PSAppConnectionString") {}

    public DbSet<User> Users { get; set; }
    }
}
