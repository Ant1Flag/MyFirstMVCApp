using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        OrderContext db = new OrderContext();

        public ActionResult Index()
        {
            IEnumerable<Order> orders = db.Orders;
     
            ViewBag.Orders = orders;
         
            return View();
        }

        [HttpPost]

        public ActionResult OrderSearch(double total)
        {
            var all_Orders = db.Orders.Where(a => a.Total <= total);
            return PartialView(all_Orders);
        }

    }
}