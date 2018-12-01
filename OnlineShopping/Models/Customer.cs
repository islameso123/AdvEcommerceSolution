using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Customer
    {
        public int customerID { get; set; } //pk
        public string address { get; set; }
        public string name { get; set; }
        public DateTime birthdate { get; set; }
        public bool gender { get; set; }
        public string email { get; set; }
        public List<order> _orders { get; set; }
        public List<product> _products { get; set; }
    }
}
