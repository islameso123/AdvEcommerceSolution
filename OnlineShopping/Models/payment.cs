using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class payment
    {
        public int pid { get; set; } //pk
        public string pname { get; set; }
        public  string bankname { get; set; }
        public order _order { get; set; }
    }
}
