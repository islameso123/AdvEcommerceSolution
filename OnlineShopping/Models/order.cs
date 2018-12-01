using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class order
    {
        public int orderid { get; set; } //pk
        public int quantity { get; set; }
        public decimal price { get; set; }
        public DateTime orderdate { get; set; }
        public decimal discount { get; set; }
        public DateTime deliverytime { get; set; }
        public int pid { get; set; } //fk
        public payment _payment { get; set; } //navigation property
        public List<Customer> _customers { get; set; }
    }
}