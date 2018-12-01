using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Supplier
    {
        public int sid { get; set; }
        public string companyname { get; set; }
        public string cityname { get; set; }
        public string regionname { get; set; }
        public string fax { get; set; }
        public List<product> _products { get; set; }
    }
}
