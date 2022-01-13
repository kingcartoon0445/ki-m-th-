using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopeeeeee.Models
{
    public class Carts
    {
        public int id { get; set; }
        public Accounts AccountId { get; set; }
        public Products ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
