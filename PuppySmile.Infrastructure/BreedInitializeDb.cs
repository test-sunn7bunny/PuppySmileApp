using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class BreedInitializeDb : DropCreateDatabaseIfModelChanges<BreedContext>
    {
        protected override void Seed(BreedContext context)
        {
            context.Breeds.Add(new Breed
            {
                //BreedId = 1,
                Name = "Чеширський кітовий тер'єр",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 2,
                Name = "Джек-Рассел тер'єр",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 3,
                Name = "Таун-Хаус тер'єр",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 4,
                Name = "Тік-Так тер'єр",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 5,
                Name = "Лайф-Хак тер'єр1",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 6,
                Name = "Лайф-Хак тер'єр2",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 7,
                Name = "Лайф-Хак тер'єр3",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 8,
                Name = "Лайф-Хак тер'єр4",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 9,
                Name = "Лайф-Хак тер'єр5",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 10,
                Name = "Лайф-Хак тер'єр6",
            });
            context.Breeds.Add(new Breed
            {
                //BreedId = 11,
                Name = "Лайф-Хак тер'єр7",
            });

            context.SaveChanges();

            base.Seed(context);


        }
    }
}
