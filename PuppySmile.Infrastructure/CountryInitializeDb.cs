using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class CountryInitializeDb : DropCreateDatabaseIfModelChanges<CountryContext>
    {
        protected override void Seed(CountryContext context)
        {
            context.Countries.Add(new Country
            {
                //CountryId = 1,
                Name = "Україна",
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
