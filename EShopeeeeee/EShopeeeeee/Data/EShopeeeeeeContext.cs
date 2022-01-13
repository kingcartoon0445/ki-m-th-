using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EShopeeeeee.Models;

namespace EShopeeeeee.Data
{
    public class EShopeeeeeeContext : DbContext
    {
        public EShopeeeeeeContext (DbContextOptions<EShopeeeeeeContext> options)
            : base(options)
        {
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
