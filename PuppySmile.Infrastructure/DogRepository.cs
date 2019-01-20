using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class DogRepository : IDogRepository
    {
        DogContext context = new DogContext();

        public void Add(Dog d)
        {
            context.Dogs.Add(d);
            context.SaveChanges();
            //throw new NotImplementedException();
        }
        public void Edit(Dog d)
        {
            context.Entry(d).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            Dog d = context.Dogs.Find(Id);
            context.Dogs.Remove(d);
            var saveChanges = context.SaveChanges();
        }

        public Dog FindById(int Id)
        {
            var result = (from r in context.Dogs where r.DogId == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable<Dog> GetDogs()
        {
            return context.Dogs;
        }
    }
}
