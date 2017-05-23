using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Order_Date { get; set; }
        public string Ship_Date { get; set; }
        public int Order_ID { get; set; }
        public string Contact_Name { get; set; }
        public double Contact_Total { get; set; }
    }
}