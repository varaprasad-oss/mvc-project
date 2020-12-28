using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace taskEFW
{
    class ProductsAmazon
    {

        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }


        public ICollection<Order> OrdersAmazon { get; set; }
    }
    

}

