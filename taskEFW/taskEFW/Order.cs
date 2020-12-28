using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace taskEFW
{
        class Order
        {
          
            [Key]
            public int OrderId { get; set; }
            public string OrderName { get; set; }
            public string Category { get; set; }

            public int ProductId { get; set; }
            public ProductsAmazon Product { get; set; }
        }

}
