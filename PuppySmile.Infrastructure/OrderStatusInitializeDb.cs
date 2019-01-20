using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppySmile.Core;

namespace PuppySmile.Infrastructure
{
    public class OrderStatusInitializeDb : DropCreateDatabaseIfModelChanges<OrderStatusContext>
    {
        protected override void Seed(OrderStatusContext context)
        {
            context.OrderStatuses.Add(new OrderStatus
            {
                //OrderStatusId = 0,
                Name = "Забирайте хоч зараз",
            });
            context.OrderStatuses.Add(new OrderStatus
            {
                //OrderStatusId = 1,
                Name = "Скоро цього песика заберуть",
            });
            context.OrderStatuses.Add(new OrderStatus
            {
                //OrderStatusId = 2,
                Name = "Цей пухнастик вже знайшов свою сім'ю",
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
