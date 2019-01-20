using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class ShelterContext : DbContext
    {
        public ShelterContext()
            : base("name=PSAppConnectionString") { }

        public DbSet<Shelter> Shelters { get; set; }
    }
}
