using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class Oblast
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OblastId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        // Adding a Public Key to Misto table 1-many
        public virtual ICollection<Misto> Mistos { get; set; }
    }
}
