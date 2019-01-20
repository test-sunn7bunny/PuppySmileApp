using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class OblastContext : DbContext
    {
        public OblastContext()
            : base("name=PSAppConnectionString")
        {
        }

        public DbSet<Oblast> Oblasts { get; set; }
    }
}
