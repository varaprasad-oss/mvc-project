using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkTask
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int  ProductPrice{ get; set; }
        public string ProductStatus { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
