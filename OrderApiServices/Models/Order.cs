using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApiServices.Models
{
    public class Order
    {
        public int serial { get; set; }
        public string productName { get; set; }
        public string price { get; set; }
    }
}
