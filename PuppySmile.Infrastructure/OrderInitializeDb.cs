using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class OrderInitializeDb : DropCreateDatabaseIfModelChanges<OrderContext>
    {
        protected override void Seed(OrderContext context)
        {
            context.Orders.Add(new Order
            {
                //OrderId = 1,
                UserId = 3,
                DogId = 3,
                OrderStatusId = 1,
            });
            context.Orders.Add(new Order
            {
                //OrderId = 2,
                UserId = 4,
                DogId = 5,
                OrderStatusId = 1,
            });
            context.Orders.Add(new Order
            {
                //OrderId = 3,
                UserId = 3,
                DogId = 4,
                OrderStatusId = 2,
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
