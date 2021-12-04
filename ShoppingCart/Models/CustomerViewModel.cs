using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class CustomerViewModel : Customer
    {
        public IList<int> Items { get; set; }
    }
}
