using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class Dog
    {
        public Dog()
        {
            this.Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DogId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string PictureAddress { get; set; }

        [Required]
        public int ShelterId { get; set; }

        [Required]
        public int BreedId { get; set; }

        [Required]
        public int Availability { get; set; }

        // Adding a Foreign Key from Shelter table 1-many
        public virtual Shelter Shelter { get; set; }

        // Adding a Foreign Key from Breed table 1-many
        public virtual Breed Breed { get; set; }

        // Adding a Public Key to Order table 1-1
        public virtual ICollection<Order> Orders { get; set; }

    }
}
