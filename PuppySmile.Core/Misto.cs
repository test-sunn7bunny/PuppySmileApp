using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class Misto
    {
        public Misto()
        {
            this.Shelters = new HashSet<Shelter>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MistoId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int OblastId { get; set; }

        // Adding a Foreign Key from Oblast table
        public virtual Oblast Oblast { get; set; }

        // Adding a Public Key to Shelter table 1-many
        public virtual ICollection<Shelter> Shelters { get; set; }
    }
}
