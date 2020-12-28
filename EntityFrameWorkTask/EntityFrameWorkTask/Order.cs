using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameWorkTask
{
    class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime  OrderDate { get; set; }
        public int OrderPrice { get; set; }
        public int Quanity { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
