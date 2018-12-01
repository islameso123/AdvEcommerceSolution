using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class product_supplier
    {
        public int pid { get; set; } //fk
        public product _product { get; set; }
        public int sid { get; set; } //fk
        public Supplier _supplier { get; set; }
    }

}
