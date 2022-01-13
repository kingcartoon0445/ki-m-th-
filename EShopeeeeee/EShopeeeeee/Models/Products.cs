using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopeeeeee.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public ProductTypes ProductTypeId { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public List<Carts> Carts { get; set; }
        public List<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
