using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test1.Models
{
    public class OrderInitializer : DropCreateDatabaseAlways<OrderContext>
    {
        protected override void Seed(OrderContext db)
        {
            db.Orders.Add(new Order { Order_Year = 2012, Time_To_Ship = 4, Total = 220 });
            db.Orders.Add(new Order { Order_Year = 2012, Time_To_Ship = 4, Total = 220 });
            db.Orders.Add(new Order { Order_Year = 2012, Time_To_Ship = 4, Total = 220 });

            base.Seed(db);
        }
    }
}