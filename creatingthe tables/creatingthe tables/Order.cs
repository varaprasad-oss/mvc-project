using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace creatingthe_tables
{
    class Order
    {
        [Key]
        public int Orderid { get; set; }
        public string OrderName { get; set; }
        public string Categery { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
