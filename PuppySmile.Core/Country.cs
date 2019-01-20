using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class Country
    {
        public Country()
        {
            this.Oblasts = new HashSet<Oblast>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }

//        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        // Adding a Public Key to Oblast table
        public virtual ICollection<Oblast> Oblasts { get; set; }

    }
}
