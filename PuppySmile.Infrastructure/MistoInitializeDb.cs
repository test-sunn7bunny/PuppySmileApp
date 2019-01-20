using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class MistoInitializeDb : DropCreateDatabaseIfModelChanges<MistoContext>
    {
        protected override void Seed(MistoContext context)
        {
            context.Mistos.Add(new Misto
            {
                //MistoId = 1,
                Name = "Київ",
                OblastId = 1,
            });
            context.Mistos.Add(new Misto
            {
                //MistoId = 2,
                Name = "Харків",
                OblastId = 2,
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
