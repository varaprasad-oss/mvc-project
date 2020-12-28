using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace creatingthe_tables
{
    class ContextCreating:DbContext
    {
        private string ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionString = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            optionsBuilder.UseSqlServer(ConnectionString);


            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Order> OrdersOfTollplus { get; set; }
        public DbSet<Product> ProductsOfTollplus { get; set; }

    }
}
