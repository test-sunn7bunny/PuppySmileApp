using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PuppySmile.Core
{
    public class Shelter
    {
        public Shelter()
        {
            this.Dogs = new HashSet<Dog>();
            this.Orders = new HashSet<Order>();
            this.ShelterStaffs = new HashSet<ShelterStaff>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShelterId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int MistoId { get; set; }

        // Adding a Foreign Key from Misto table
        public virtual Misto Misto { get; set; }

        // Adding a Public Key to Dog table 1-many
        public virtual ICollection<Dog> Dogs { get; set; }

        // Adding a Public Key to Order table 1-many
        public virtual ICollection<Order> Orders { get; set; }

        // Adding a Public Key to Order table 1-many
        public virtual ICollection<ShelterStaff> ShelterStaffs { get; set; }
    }
}