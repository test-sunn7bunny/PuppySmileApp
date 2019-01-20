using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class Breed
    {
        public Breed()
        {
            this.Dogs = new HashSet<Dog>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BreedId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Dog> Dogs { get; set; }
    }
}
