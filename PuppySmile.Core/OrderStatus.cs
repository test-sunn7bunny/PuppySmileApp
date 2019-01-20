using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class OrderStatus
    {
        public OrderStatus()
        {
            this.Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderStatusId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // Adding a Public Key to Oblast table
        public virtual ICollection<Order> Orders{ get; set; }
    }
}
