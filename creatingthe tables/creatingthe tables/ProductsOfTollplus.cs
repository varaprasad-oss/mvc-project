using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace creatingthe_tables
{
    class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductStatus { get; set; }
        public ICollection<Order> OrdersOfTollplus{get;set;}
    }
}
