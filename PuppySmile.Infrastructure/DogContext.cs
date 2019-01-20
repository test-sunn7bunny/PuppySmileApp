using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure 
{
    public class DogContext : DbContext
    {
        public DogContext()
            : base("name=PSAppConnectionString") { }
            
    public DbSet<Dog> Dogs { get; set; }

        public System.Data.Entity.DbSet<PuppySmile.Core.Breed> Breeds { get; set; }

        public System.Data.Entity.DbSet<PuppySmile.Core.Shelter> Shelters { get; set; }
    }   
}
