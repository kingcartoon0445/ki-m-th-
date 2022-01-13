using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopeeeeee.Models
{
    public class Invoices
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Accounts Accountld { get; set; }
        public DateTime IssuedDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhone { get; set; }
        public int Total { get; set; }
        public bool Status { get; set; }
        public List<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
