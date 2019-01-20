using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class ShelterStaff
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShelterStaffId { get; set; }

        [Required]
        public int ShelterId { get; set; }

        [Required]
        public int UserId { get; set; }

        // Adding a Foreign Key from Shelter table
        public virtual Shelter Shelter { get; set; }

        // Adding a Foreign Key from User table
        public virtual User User { get; set; }
    }
}
