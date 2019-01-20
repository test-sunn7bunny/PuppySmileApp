using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class OblastInitializeDb : DropCreateDatabaseIfModelChanges<OblastContext>
    {
        protected override void Seed(OblastContext context)
        {
            context.Oblasts.Add(new Oblast
            {
                //OblastId = 1,
                Name ="Київська",
                CountryId = 1,
            });
            context.Oblasts.Add(new Oblast
            {
                //OblastId = 2,
                Name = "Харківська",
                CountryId = 1,
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
