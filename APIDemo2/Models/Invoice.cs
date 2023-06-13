using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIDemo2.Models
{
    public class Invoice
    {

        public int InvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public List<Detail> Details { get; set; }
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }

        public bool State { get; set; }

    }
}
