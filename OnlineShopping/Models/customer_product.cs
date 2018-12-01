using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class customer_product
    {
        public int customerID { get; set; } //fk
        public Customer _customer { get; set; } //nav prop
        public int pid { get; set; } //fk
        public product product { get; set; } //nav prop
    }
}
