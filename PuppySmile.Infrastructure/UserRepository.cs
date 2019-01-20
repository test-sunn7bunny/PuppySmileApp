using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        UserContext context = new UserContext();

        public void Add(User d)
        {
            context.Users.Add(d);
            context.SaveChanges();
            //throw new NotImplementedException();
        }
        public void Edit(User d)
        {
            context.Entry(d).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            User d = context.Users.Find(Id);
            context.Users.Remove(d);
            var saveChanges = context.SaveChanges();
        }

        public User FindById(int Id)
        {
            var result = (from r in context.Users where r.UserId == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }
    }
}
