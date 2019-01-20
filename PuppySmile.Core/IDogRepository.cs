using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public interface IDogRepository
    {
        void Add(Dog d);

        void Edit(Dog d);

        void Remove(int Id);

        IEnumerable<Dog> GetDogs();

        Dog FindById(int Id);
    }
}
