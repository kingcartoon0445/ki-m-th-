using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopeeeeee.Models
{
    public class ProductTypes
    {
        public int id { get; set; }

        public string Name { get; set; }

        public bool Stratus { get; set; }
        public List<Products> Products { get; set; }
    }
}
