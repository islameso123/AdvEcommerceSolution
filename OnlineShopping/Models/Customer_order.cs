using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Customer_order
    {
        public int customerID { get; set; } //fk
        public Customer _customer { get; set; } //navigation property de el bt3rfo en customerid da fk
        public int orderid { get; set; } // fk
        public order _orders { get; set; } //navigation property de el bt3rfo en orderid da fk
        //both together are pk
    }
}
