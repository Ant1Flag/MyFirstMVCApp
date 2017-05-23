using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Order_Year { get; set; }
        public int Time_To_Ship { get; set; }
        public double Total { get; set; }
    }
}