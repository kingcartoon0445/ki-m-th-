using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopeeeeee.Models
{
    public class Accounts
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public string Avartar { get; set; }
        public bool Status { get; set; }
        public List<Carts> Carts { get; set; }
        public List<Invoices> Invoices { get; set; }
    }
}
