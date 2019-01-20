using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppySmile.Core
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public int DogId { get; set; }

        public int OrderStatusId { get; set; }

        public virtual User User { get; set; }

        public virtual Dog Dog { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }
    }
}
