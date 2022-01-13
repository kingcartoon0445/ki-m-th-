using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopeeeeee.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public Invoices InvoiceId { get; set; }
        public Products ProductId { get; set; }
        public int Quanlity { get; set; }
        public int UnitPrice { get; set; }
    }
}
