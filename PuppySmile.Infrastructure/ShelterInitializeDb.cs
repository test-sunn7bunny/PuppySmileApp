using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class ShelterInitializeDb : DropCreateDatabaseIfModelChanges<ShelterContext>
    {
        protected override void Seed(ShelterContext context)
        {
            context.Shelters.Add(new Shelter
            {
                //ShelterId = 1,
                Name = "Pups Buds",
                MistoId = 1,
            });
            context.Shelters.Add(new Shelter
            {
                //ShelterId = 2,
                Name = "Pups 4 Hugs",
                MistoId = 2,
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
