using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class product
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public int quantity { get; set; }
        public string pcategory { get; set; }
        public decimal price { get; set; }
        public List<Customer> _customer { get; set; }
        public List<Supplier> _supplier { get; set; }
    }
}
