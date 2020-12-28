using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkTask
{
    class ContextClass1:DbContext
    {
        private string connect;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            connect = "Data Source = 192.168.50.95; Initial Catalog = vgudipati; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
            optionsBuilder.UseSqlServer(connect);
            base.OnConfiguring(optionsBuilder);
        }
            public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Productss { get; set; }
        
    }
}
