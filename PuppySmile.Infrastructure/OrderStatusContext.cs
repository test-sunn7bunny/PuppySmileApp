using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class OrderStatusContext : DbContext
    {
        public OrderStatusContext()
            : base("name=PSAppConnectionString") { }

        public DbSet<OrderStatus> OrderStatuses { get; set; }
    }
}
