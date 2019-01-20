using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    interface IShelterRepository
    {
        void Add(Shelter d);

        void Edit(Shelter d);

        void Remove(int Id);

        IEnumerable<Shelter> GetShelters();

        Shelter FindById(int Id);
    }
}
