using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public interface IUserRepository
    {
        void Add(User d);

        void Edit(User d);

        void Remove(int Id);

        IEnumerable<User> GetUsers();

        User FindById(int Id);
    }
}
