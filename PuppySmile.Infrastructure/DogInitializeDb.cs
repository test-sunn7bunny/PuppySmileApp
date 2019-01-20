using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class DogInitializeDb : DropCreateDatabaseIfModelChanges<DogContext>
    {
        protected override void Seed(DogContext context)
        {

            context.Dogs.Add(new Dog
            {
                //DogId = 1,
                Name = "Шрек",
                PictureAddress = "~/pics/1.jpg",
                ShelterId = 2,
                BreedId = 1,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 2,
                Name = "Пушко",
                PictureAddress = "~/pics/2.jpg",
                ShelterId = 1,
                BreedId = 2,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 3,
                Name = "Мік",
                PictureAddress = "~/pics/3.jpg",
                ShelterId = 2,
                BreedId = 3,
                Availability = 2,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 4,
                Name = "Міні",
                PictureAddress = "~/pics/4.jpg",
                ShelterId = 1,
                BreedId = 4,
                Availability = 0,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 5,
                Name = "Міні",
                PictureAddress = "~/pics/5.jpg",
                ShelterId = 1,
                BreedId = 5,
                Availability = 2,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 6,
                Name = "Міні",
                PictureAddress = "~/pics/6.jpg",
                ShelterId = 1,
                BreedId = 6,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 7,
                Name = "Міні",
                PictureAddress = "~/pics/7.jpg",
                ShelterId = 1,
                BreedId = 7,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 8,
                Name = "Мін",
                PictureAddress = "~/pics/8.jpg",
                ShelterId = 2,
                BreedId = 8,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 9,
                Name = "Міні",
                PictureAddress = "~/pics/9.jpg",
                ShelterId = 1,
                BreedId = 9,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 10,
                Name = "Міні",
                PictureAddress = "~/pics/10.jpg",
                ShelterId = 2,
                BreedId = 10,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 11,
                Name = "Міні",
                PictureAddress = "~/pics/11.jpg",
                ShelterId = 1,
                BreedId = 11,
                Availability = 1,
            });
            context.Dogs.Add(new Dog
            {
                //DogId = 12,
                Name = "Міні",
                PictureAddress = "~/pics/11.jpg",
                ShelterId = 1,
                BreedId = 11,
                Availability = 1,
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
