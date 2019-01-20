using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class ShelterStaffInitializeDb : DropCreateDatabaseIfModelChanges<ShelterStaffContext>
    {
        protected override void Seed(ShelterStaffContext context)
        {
            context.ShelterStaffs.Add(new ShelterStaff
            {
                //ShelterStaffId = 1,
                ShelterId = 1,
                UserId = 2,
            });
            context.ShelterStaffs.Add(new ShelterStaff
            {
                //ShelterStaffId = 2,
                ShelterId = 2,
                UserId = 3,
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
